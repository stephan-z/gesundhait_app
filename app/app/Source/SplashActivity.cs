using Android.App;
using Android.OS;

using System.Threading.Tasks;

namespace App.Source
{
    [Activity(Theme = "@style/gesundhait.SplashScreen", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : BaseActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Splash);
        }

        protected override async void OnResume()
        {
            base.OnResume();

            // Bisschen Verzögerung
            await Task.Delay(1000);

            StartActivity(typeof(MainActivity));
        }
    }
}