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
    [Activity(Label = "LoginA")]
    public class LoginA : Activity
    {
		private string email, password;
        private Button confirmLoginButton, forgotPasswordButton;
		private LocalDataAccessLayer lda = LocalDataAccessLayer.getInstance();
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Login);

            loadAllBaseViews();
            setUpAllActions();
        }
        private void loadAllBaseViews()
        {
			email = FindViewById<EditText>(Resource.Id.emailInput).Text;
			password = FindViewById<EditText>(Resource.Id.passwordInput).Text;
            confirmLoginButton = FindViewById<Button>(Resource.Id.confirmLoginButton);
            forgotPasswordButton = FindViewById<Button>(Resource.Id.forgotPasswordButton);
        }
        private void setUpAllActions()
        {
            confirmLoginButton.Click += ConfirmLoginButton_Click;
            forgotPasswordButton.Click += forgotPasswordButton_Click;
        }
        private void ConfirmLoginButton_Click(object sender, EventArgs e)
        {
			List<Student> students = lda.getAllStudents();
			for (int i = 0; i < students.Count;i++)
			{
				if (email.Equals(students[i].email)) {

					if (password.Equals(students[i].password))
					{
						StartActivity(typeof(TutorProfileA));
					}
					else {
						//password does not match
					}
				}
			}
            
        }

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}