using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace xamarinLogin
{
    [Activity(Label = "xamarinLogin", MainLauncher = true, Icon = "@drawable/LionUp")]
    public class MainActivity : Activity
    {
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //Initializing button from layout
            Button login = FindViewById<Button>(Resource.Id.login);

            //Login button click action
            login.Click += (object sender, EventArgs e) =>
            {
                Android.Widget.Toast.MakeText(this, "Login Button Clicked!", Android.Widget.ToastLength.Short).Show();
            };
        }
    }
}

