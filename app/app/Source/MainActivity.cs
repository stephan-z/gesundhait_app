using Android.App;
using Android.OS;

using App.Source.Connection;
using App.Source.Data;

namespace App.Source
{
    [Activity]
    public class MainActivity : ExtendedActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            //GesundhaitREST rest = new GesundhaitREST();
            //string users = rest.getAllUsers();
            //UserList ul = new UserList();
            //ul.setFromJSON(users);

            //string user = rest.getUserByID(2);
            //User u = new User();
            //u.setFromJSON(user);
            //string json = u.toJSON();
        }        
    }
}

