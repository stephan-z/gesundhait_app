﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace app.source.activity
{
    [Activity(Label = "app", MainLauncher = true, Icon = "@drawable/icon")]
    public class Main : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}
