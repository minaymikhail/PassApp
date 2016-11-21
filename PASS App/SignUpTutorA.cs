
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
    [Activity(Label = "SignUpTutorA")]
    public class SignUpTutorA : Activity
    {
        Button submitButton, cancelButton;
		String firstName, lastName, email, password, confirmPassword;
		int studentID;
		LocalDataAccessLayer lda = LocalDataAccessLayer.getInstance();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.SignUpTutor);
            loadAllBaseViews();
            setUpAllActions();
        }

        private void loadAllBaseViews()
        {
			submitButton = FindViewById<Button>(Resource.Id.tutorSubmit);
			cancelButton = FindViewById<Button>(Resource.Id.tutorCancel);
			firstName = FindViewById<EditText>(Resource.Id.firstName).Text;
			lastName = FindViewById<EditText>(Resource.Id.lastName).Text;
			email = FindViewById<EditText>(Resource.Id.email).Text;
			studentID = Int32.Parse(FindViewById<EditText>(Resource.Id.studentID).Text);
			password = FindViewById<EditText>(Resource.Id.password).Text;
			confirmPassword = FindViewById<EditText>(Resource.Id.confirmPassword).Text;
        }

        private void setUpAllActions()
        {
            submitButton.Click += SubmitButton_Click;
            cancelButton.Click += CancelButton_Click;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (password.Equals(confirmPassword))
			{
				lda.addTutor(new Tutor(firstName, lastName, email, studentID, password));
				Finish();
			}
			else {
				//throw new NotImplementedException();
				StartActivity(typeof(StudentLoginA));
				//AlertDialog.Builder alert = new AlertDialog.Builder();
				//alert.SetMessage("Password does not match");


			}

        }

        private void CancelButton_Click(object sender, EventArgs e) { Finish(); }



    }
}
