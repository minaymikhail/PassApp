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

namespace Pass_App
{
    [Activity(Label = "SessionDetailsStudentA")]
    public class SessionDetailsStudentA : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SessionDetailsStudent);
            Button back = FindViewById<Button>(Resource.Id.returnButton);
            back.Click += delegate { Finish(); };
            // Create your application here

        }
    }
}
