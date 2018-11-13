using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using System.Threading;
using Android.Widget;
using supporttoolbar = Android.Support.V7.Widget.Toolbar;

namespace menutoggle
{
    [Activity(Label = "@string/app_name")]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.content_main);
            Timer tim = new Timer(obj =>
            {
                RunOnUiThread(() =>
                {
                    FindViewById<TextView>(Resource.Id.textbox1).Text = $" {DateTime.Now:T}";
                });
            }, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
        }



    }
}

