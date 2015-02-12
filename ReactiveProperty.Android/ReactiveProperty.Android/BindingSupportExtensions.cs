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
            this Activity self,
            int id,
            Expression<Func<TView, TProperty>> propertySelector,
            ReactiveProperty<TProperty> source, Func<TView, IObservable<Unit>> updateSourceTrigger = null)
            where TView : View
        {
            var view = self.FindViewById<TView>(id);
            string propertyName;
            var getter = AccessorCache<TView>.LookupGet(propertySelector, out propertyName);
            var setter = AccessorCache<TView>.LookupSet(propertySelector, out propertyName);

            var d = new CompositeDisposable();

            bool isUpdating = false;
            source
                .Where(_ => !isUpdating)
                .Subscribe(x => setter(view, x))
                .AddTo(d);
            if (updateSourceTrigger != null)
            {
                updateSourceTrigger(view).Subscribe(_ =>
                {
                    isUpdating = true;
                    try
                    {
                        source.Value = getter(view);
                    }
                    finally
                    {
                        isUpdating = false;
                    }
                }).AddTo(d);
            }

            return d;
        }

        public static IDisposable SetBinding<TView, TProperty>(
            this View self,
            int id,
            Expression<Func<TView, TProperty>> propertySelector,
            ReactiveProperty<TProperty> source, Func<TView, IObservable<Unit>> updateSourceTrigger = null)
            where TView : View
        {
            var view = self.FindViewById<TView>(id);
            string propertyName;
            var getter = AccessorCache<TView>.LookupGet(propertySelector, out propertyName);
            var setter = AccessorCache<TView>.LookupSet(propertySelector, out propertyName);

            var d = new CompositeDisposable();

            bool isUpdating = false;
            source
                .Where(_ => !isUpdating)
                .Subscribe(x => setter(view, x))
                .AddTo(d);
            if (updateSourceTrigger != null)
            {
                updateSourceTrigger(view).Subscribe(_ =>
                {
                    isUpdating = true;
                    try
                    {
                        source.Value = getter(view);
                    }
                    finally
                    {
                        isUpdating = false;
                    }
                }).AddTo(d);
            }

            return d;
        }
    }
}