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

namespace APITest
{
    [Activity(Label = "getDeviceLocationActivity")]
    public class getDeviceLocationActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.getDeviceLocationActivity);
            //string data = Intent.GetStringExtra("data" ?? "No data recieved");

            //var txtData = FindViewById<TextView>(Resource.Id.txtData);
            var testButton = FindViewById<Button>(Resource.Id.testButton);
            var backButton = FindViewById<Button>(Resource.Id.backButton);

            //txtData.Text = data;

            testButton.Click += alertDisplay;

            backButton.Click += delegate
            {
                this.Finish();
            };
        }

        private void alertDisplay(object sender, EventArgs e)
        {
            AlertDialog.Builder alertDialog = new AlertDialog.Builder(this);
            alertDialog.SetTitle("Alert");
            alertDialog.SetMessage("This is an alert dialog for testing purposes");
            alertDialog.SetNeutralButton("OK", delegate
            {
                alertDialog.Dispose();
            });
            alertDialog.Show();
        }
    }
}