using Android.App;
using Android.OS;

namespace app.source.activity
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