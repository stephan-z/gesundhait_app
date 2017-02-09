using Android.App;
using Android.OS;

using app.source.connection;

namespace app.source.activity
{
    [Activity]
    public class MainActivity : ExtendedActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            GesundhaitREST rest = new GesundhaitREST();
            rest.getAllUsers();
            rest.getUserByID(2);
        }        
    }
}

