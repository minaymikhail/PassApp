using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Pass_App
{
    [Activity(Label = "SelectSessionTutorConfirmAttendanceA")]
    public class SelectSessionTutorConfirmAttendanceA : Activity
    {
        Button confirmButton;
        RadioButton acct2121SelectorA, acct2121SelectorB;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.SelectSessionTutorConfirmAttendance);

            loadAllBaseViews();
            setUpAllActions();
        }

        private void loadAllBaseViews()
        {
            confirmButton = FindViewById<Button>(Resource.Id.confirmButton);
            acct2121SelectorA = FindViewById<RadioButton>(Resource.Id.acct2121SelectorA);
            acct2121SelectorB = FindViewById<RadioButton>(Resource.Id.acct2121SelectorB);
        }

        private void setUpAllActions()
        {
            confirmButton.Click += ConfirmButton_Click;
            acct2121SelectorA.Click += Acct2121SelectorA_Click;
            acct2121SelectorB.Click += Acct2121SelectorB_Click;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Acct2121SelectorA_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Acct2121SelectorB_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

