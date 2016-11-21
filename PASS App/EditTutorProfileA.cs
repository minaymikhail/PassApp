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
    [Activity(Label = "EditTutorProfileA")]
    public class EditTutorProfileA : Activity
    {
        Button submit;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.EditTutorProfile);
            loadAllBaseViews();
            setUpAllActions();
        }

        private void loadAllBaseViews()
        {
            submit = FindViewById<Button>(Resource.Id.submitButton);
        }



        private void setUpAllActions()
        {
            submit.Click += submit_Click;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}