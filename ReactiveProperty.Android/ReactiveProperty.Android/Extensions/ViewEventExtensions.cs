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
using System.Reactive.Linq;

namespace ReactiveProperty.XamarinAndroid.Extensions
{
    public static class ViewEventExtensions
    {
        public static IObservable<EventArgs> SwipeDownEventAsObservable(this Android.InputMethodServices.KeyboardView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.SwipeDownEvent += h,
                h => self.SwipeDownEvent -= h);
        }
        public static IObservable<EventArgs> SwipeLeftEventAsObservable(this Android.InputMethodServices.KeyboardView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.SwipeLeftEvent += h,
                h => self.SwipeLeftEvent -= h);
        }
        public static IObservable<EventArgs> SwipeRightEventAsObservable(this Android.InputMethodServices.KeyboardView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.SwipeRightEvent += h,
                h => self.SwipeRightEvent -= h);
        }
        public static IObservable<EventArgs> SwipeUpEventAsObservable(this Android.InputMethodServices.KeyboardView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.SwipeUpEvent += h,
                h => self.SwipeUpEvent -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.InputMethodServices.KeyboardView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Opengl.GLSurfaceView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Views.View self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ItemSelectionClearedAsObservable(this Android.Widget.AbsListView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ItemSelectionCleared += h,
                h => self.ItemSelectionCleared -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.AbsListView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ItemSelectionClearedAsObservable(this Android.Widget.AdapterView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ItemSelectionCleared += h,
                h => self.ItemSelectionCleared -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.AdapterView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ItemSelectionClearedAsObservable(this Android.Widget.AdapterViewAnimator self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ItemSelectionCleared += h,
                h => self.ItemSelectionCleared -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.AdapterViewAnimator self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ItemSelectionClearedAsObservable(this Android.Widget.AutoCompleteTextView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ItemSelectionCleared += h,
                h => self.ItemSelectionCleared -= h);
        }
        public static IObservable<EventArgs> DismissAsObservable(this Android.Widget.AutoCompleteTextView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Dismiss += h,
                h => self.Dismiss -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.AutoCompleteTextView self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.AutoCompleteTextView self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.AutoCompleteTextView self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.AutoCompleteTextView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.DatePicker self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> NextClickAsObservable(this Android.Widget.MediaController self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.NextClick += h,
                h => self.NextClick -= h);
        }
        public static IObservable<EventArgs> PreviousClickAsObservable(this Android.Widget.MediaController self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.PreviousClick += h,
                h => self.PreviousClick -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.MediaController self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.TextView self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.TextView self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.TextView self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.TextView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.App.FragmentBreadCrumbs self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ExtendedSettingsClickAsObservable(this Android.App.MediaRouteButton self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ExtendedSettingsClick += h,
                h => self.ExtendedSettingsClick -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.App.MediaRouteButton self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Appwidget.AppWidgetHostView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Gestures.GestureOverlayView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.InputMethodServices.ExtractEditText self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.InputMethodServices.ExtractEditText self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.InputMethodServices.ExtractEditText self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.InputMethodServices.ExtractEditText self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Media.TV.TvView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Renderscripts.RSSurfaceView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Renderscripts.RSTextureView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Views.SurfaceView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Views.TextureView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Views.ViewGroup self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Views.ViewStub self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<Android.Webkit.DownloadEventArgs> DownloadAsObservable(this Android.Webkit.WebView self)
        {
            return Observable.FromEvent<EventHandler<Android.Webkit.DownloadEventArgs>, Android.Webkit.DownloadEventArgs>(
                h => (s, e) => h(e),
                h => self.Download += h,
                h => self.Download -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Webkit.WebView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.AbsSeekBar self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ItemSelectionClearedAsObservable(this Android.Widget.AbsSpinner self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ItemSelectionCleared += h,
                h => self.ItemSelectionCleared -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.AbsSpinner self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.AbsoluteLayout self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ActionMenuView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ItemSelectionClearedAsObservable(this Android.Widget.AdapterViewFlipper self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ItemSelectionCleared += h,
                h => self.ItemSelectionCleared -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.AdapterViewFlipper self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.AnalogClock self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.Button self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.Button self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.Button self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.Button self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.CalendarView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.CheckBox self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.CheckBox self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.CheckBox self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.CheckBox self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.CheckedTextView self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.CheckedTextView self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.CheckedTextView self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.CheckedTextView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ChronometerTickAsObservable(this Android.Widget.Chronometer self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ChronometerTick += h,
                h => self.ChronometerTick -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.Chronometer self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.Chronometer self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.Chronometer self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.Chronometer self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.CompoundButton self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.CompoundButton self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.CompoundButton self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.CompoundButton self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.DialerFilter self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.DigitalClock self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.DigitalClock self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.DigitalClock self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.DigitalClock self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.EditText self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.EditText self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.EditText self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.EditText self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ItemSelectionClearedAsObservable(this Android.Widget.ExpandableListView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ItemSelectionCleared += h,
                h => self.ItemSelectionCleared -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ExpandableListView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.FrameLayout self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ItemSelectionClearedAsObservable(this Android.Widget.Gallery self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ItemSelectionCleared += h,
                h => self.ItemSelectionCleared -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.Gallery self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.GridLayout self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ItemSelectionClearedAsObservable(this Android.Widget.GridView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ItemSelectionCleared += h,
                h => self.ItemSelectionCleared -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.GridView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.HorizontalScrollView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ImageButton self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ImageSwitcher self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ImageView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.LinearLayout self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ItemSelectionClearedAsObservable(this Android.Widget.ListView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ItemSelectionCleared += h,
                h => self.ItemSelectionCleared -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ListView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ItemSelectionClearedAsObservable(this Android.Widget.MultiAutoCompleteTextView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ItemSelectionCleared += h,
                h => self.ItemSelectionCleared -= h);
        }
        public static IObservable<EventArgs> DismissAsObservable(this Android.Widget.MultiAutoCompleteTextView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Dismiss += h,
                h => self.Dismiss -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.MultiAutoCompleteTextView self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.MultiAutoCompleteTextView self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.MultiAutoCompleteTextView self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.MultiAutoCompleteTextView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.NumberPicker self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ProgressBar self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.QuickContactBadge self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.RadioButton self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.RadioButton self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.RadioButton self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.RadioButton self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.RadioGroup self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.RatingBar self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.RelativeLayout self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ScrollView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> SearchClickAsObservable(this Android.Widget.SearchView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.SearchClick += h,
                h => self.SearchClick -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.SearchView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.SeekBar self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> DrawerCloseAsObservable(this Android.Widget.SlidingDrawer self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.DrawerClose += h,
                h => self.DrawerClose -= h);
        }
        public static IObservable<EventArgs> DrawerOpenAsObservable(this Android.Widget.SlidingDrawer self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.DrawerOpen += h,
                h => self.DrawerOpen -= h);
        }
        public static IObservable<EventArgs> ScrollEndedAsObservable(this Android.Widget.SlidingDrawer self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ScrollEnded += h,
                h => self.ScrollEnded -= h);
        }
        public static IObservable<EventArgs> ScrollStartedAsObservable(this Android.Widget.SlidingDrawer self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ScrollStarted += h,
                h => self.ScrollStarted -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.SlidingDrawer self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.Space self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ItemSelectionClearedAsObservable(this Android.Widget.Spinner self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ItemSelectionCleared += h,
                h => self.ItemSelectionCleared -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.Spinner self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ItemSelectionClearedAsObservable(this Android.Widget.StackView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ItemSelectionCleared += h,
                h => self.ItemSelectionCleared -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.StackView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.Switch self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.Switch self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.Switch self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.Switch self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.TabHost self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.TabWidget self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.TableLayout self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.TableRow self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.TextClock self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.TextClock self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.TextClock self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.TextClock self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.TextSwitcher self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.TimePicker self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChangedAsObservable(this Android.Widget.ToggleButton self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.AfterTextChanged += h,
                h => self.AfterTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> BeforeTextChangedAsObservable(this Android.Widget.ToggleButton self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.BeforeTextChanged += h,
                h => self.BeforeTextChanged -= h);
        }
        public static IObservable<Android.Text.TextChangedEventArgs> TextChangedAsObservable(this Android.Widget.ToggleButton self)
        {
            return Observable.FromEvent<EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(
                h => (s, e) => h(e),
                h => self.TextChanged += h,
                h => self.TextChanged -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ToggleButton self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> NavigationOnClickAsObservable(this Android.Widget.Toolbar self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.NavigationOnClick += h,
                h => self.NavigationOnClick -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.Toolbar self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.TwoLineListItem self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> CompletionAsObservable(this Android.Widget.VideoView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Completion += h,
                h => self.Completion -= h);
        }
        public static IObservable<EventArgs> PreparedAsObservable(this Android.Widget.VideoView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Prepared += h,
                h => self.Prepared -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.VideoView self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ViewAnimator self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ViewFlipper self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ViewSwitcher self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ZoomButton self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }
        public static IObservable<EventArgs> ZoomInClickAsObservable(this Android.Widget.ZoomControls self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ZoomInClick += h,
                h => self.ZoomInClick -= h);
        }
        public static IObservable<EventArgs> ZoomOutClickAsObservable(this Android.Widget.ZoomControls self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.ZoomOutClick += h,
                h => self.ZoomOutClick -= h);
        }
        public static IObservable<EventArgs> ClickAsObservable(this Android.Widget.ZoomControls self)
        {
            return Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => self.Click += h,
                h => self.Click -= h);
        }

    }
}