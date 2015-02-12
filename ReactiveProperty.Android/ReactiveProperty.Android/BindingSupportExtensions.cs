using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reactive.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Codeplex.Reactive;
using Codeplex.Reactive.Extensions;
using System.Reactive;
using System.Linq.Expressions;
using ReactiveProperty.XamarinAndroid.Internal;
using System.Reactive.Disposables;
using Android.Text;

namespace ReactiveProperty.XamarinAndroid
{
    public static class BindingSupportExtensions
    {
        public static IDisposable SetBinding<TView, TProperty>(
            this TView self,
            Expression<Func<TView, TProperty>> propertySelector,
            ReactiveProperty<TProperty> source, Func<TView, IObservable<Unit>> updateSourceTrigger = null)
            where TView : View
        {
            var d = new CompositeDisposable();

            bool isUpdating = false;
            string propertyName;
            var setter = AccessorCache<TView>.LookupSet(propertySelector, out propertyName);
            source
                .Where(_ => !isUpdating)
                .Subscribe(x => setter(self, x))
                .AddTo(d);
            if (updateSourceTrigger != null)
            {
                var getter = AccessorCache<TView>.LookupGet(propertySelector, out propertyName);
                updateSourceTrigger(self).Subscribe(_ =>
                {
                    isUpdating = true;
                    try
                    {
                        source.Value = getter(self);
                    }
                    finally
                    {
                        isUpdating = false;
                    }
                }).AddTo(d);
            }

            return d;
        }

        public static IDisposable SetCommand<T>(this IObservable<T> self, ReactiveCommand<T> command)
        {
            return self
                .Where(_ => command.CanExecute())
                .Subscribe(x => command.Execute(x));
        }

        public static IDisposable SetCommand<T>(this IObservable<T> self, ReactiveCommand command)
        {
            return self
                .Where(_ => command.CanExecute())
                .Subscribe(x => command.Execute());
        }

    }
}