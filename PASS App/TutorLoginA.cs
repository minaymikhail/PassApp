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
	[Activity(Label = "TutorLoginA")]
	public class TutorLoginA : Activity
	{
		private string email, password;
		private Button confirmLoginButton, forgotPasswordButton;
		private LocalDataAccessLayer lda = LocalDataAccessLayer.getInstance();
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.TutorLogin);

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
			List<Tutor> tutors = lda.getAllTutor();
			for (int i = 0; i < tutors.Count; i++)
			{
				if (email.Equals(tutors[i].email))
				{

					if (password.Equals(tutors[i].password))
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