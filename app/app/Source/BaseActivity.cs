using Android.App;
using Android.OS;

namespace App.Source
{
    [Activity(Label = "@string/ApplicationTitle", Icon = "@drawable/icon")]
    public class BaseActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}