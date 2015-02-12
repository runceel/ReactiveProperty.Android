using Android.App;
using Android.OS;
using Android.Widget;
using Codeplex.Reactive.Extensions;
using ReactiveProperty.Android.Test.ViewModels;
using ReactiveProperty.XamarinAndroid;
using ReactiveProperty.XamarinAndroid.Extensions;
using System;

namespace ReactiveProperty.Android.Test.Views
{
    [Activity(Label = "ReactiveProperty.Android.Test", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private MainActivityViewModel vm;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.vm = new MainActivityViewModel();

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // twoway
            this.SetBinding(Resource.Id.EditTextInput,
                (EditText x) => x.Text,
                vm.Input,
                (EditText x) => x.TextChangedAsObservable().ToUnit());
            // oneway
            this.SetBinding(Resource.Id.TextViewOutput,
                (TextView x) => x.Text,
                vm.Output);

            // コマンドとイベントの紐づけ思案中
            this.FindViewById<Button>(Resource.Id.ButtonClear)
                .ClickAsObservable()
                .Subscribe(_ => this.vm.ClearCommand.Execute());
        }
    }
}

