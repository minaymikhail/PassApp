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

    [Activity(Label = "StudentLoginA")]
    public class StudentLoginA : Activity
    {

        Button editProfile, sessionSignUp, confirmAttendance, viewRegisteredSession, contactSLC;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.StudentLogin);

            loadAllBaseViews();
            setUpAllActions();
        }

        private void loadAllBaseViews()
        {
            editProfile = FindViewById<Button>(Resource.Id.editProfile);
            sessionSignUp = FindViewById<Button>(Resource.Id.sessionSignUp);
            confirmAttendance = FindViewById<Button>(Resource.Id.confirmAttendance);
            viewRegisteredSession = FindViewById<Button>(Resource.Id.viewRegisteredSession);
            contactSLC = FindViewById<Button>(Resource.Id.contactSLC);
        }


        private void setUpAllActions()
        {
            editProfile.Click += editProfile_Click;
            sessionSignUp.Click += sessionSignUp_Click;
            confirmAttendance.Click += confirmAttendance_Click;
            viewRegisteredSession.Click += viewRegisteredSession_Click;
            contactSLC.Click += contactSLC_Click;

        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void sessionSignUp_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void confirmAttendance_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void viewRegisteredSession_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void contactSLC_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}