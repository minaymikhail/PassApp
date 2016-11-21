using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Pass_App
{
    [Activity(Label = "SessionDetailsTutor")]
    public class SessionDetailsTutorA : Activity
    {
        Button returnButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.SessionDetailsTutor);

            loadAllBaseViews();
            setUpAllActions();
        }

        private void loadAllBaseViews()
        {
            returnButton = FindViewById<Button>(Resource.Id.returnButton);
        }

        private void setUpAllActions()
        {
            returnButton.Click += ReturnButton_Click;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

