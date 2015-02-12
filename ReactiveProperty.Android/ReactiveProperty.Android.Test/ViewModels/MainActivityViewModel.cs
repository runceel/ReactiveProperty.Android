using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Codeplex.Reactive;

using System.Reactive.Linq;

namespace ReactiveProperty.Android.Test.ViewModels
{
    public class MainActivityViewModel
    {
        public ReactiveProperty<string> Input { get; private set; }

        public ReactiveProperty<string> Output { get; private set; }

        public ReactiveCommand ClearCommand { get; private set; }

        public MainActivityViewModel()
        {
            this.Input = new ReactiveProperty<string>();
            this.Output = this.Input
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(x => x.ToUpper()).ToReactiveProperty();

            this.ClearCommand = this.Input.Select(x => x == "clear").ToReactiveCommand();
            this.ClearCommand.Subscribe(_ => this.Input.Value = "");
        }
    }
}