using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Pass_App
{
    [Activity(Label = "ConfirmAttendanceA")]
    public class ConfirmAttendanceA : Activity
    {
        Button submitButton;
        CheckBox student1, student2, student3, student4, student5, student6, student7, student8;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.ConfirmAttendance);

            loadAllBaseViews();
            setUpAllActions();
        }

        private void loadAllBaseViews()
        {
            submitButton = FindViewById<Button>(Resource.Id.submitButton);
            student1 = FindViewById<CheckBox>(Resource.Id.student1);
            student2 = FindViewById<CheckBox>(Resource.Id.student2);
            student3 = FindViewById<CheckBox>(Resource.Id.student3);
            student4 = FindViewById<CheckBox>(Resource.Id.student4);
            student5 = FindViewById<CheckBox>(Resource.Id.student5);
            student6 = FindViewById<CheckBox>(Resource.Id.student6);
            student7 = FindViewById<CheckBox>(Resource.Id.student7);
            student8 = FindViewById<CheckBox>(Resource.Id.student8);
        }

        private void setUpAllActions()
        {
            submitButton.Click += SubmitButton_Click;
            student1.Click += Student1_Click;
            student2.Click += Student2_Click;
            student3.Click += Student3_Click;
            student4.Click += Student4_Click;
            student5.Click += Student5_Click;
            student6.Click += Student6_Click;
            student7.Click += Student7_Click;
            student8.Click += Student8_Click;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Student1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Student2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Student3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Student4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Student5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Student6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Student7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Student8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

