
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

	[Activity(Label = "SignupDirector")]
	public class SignupDirector : Activity
	{
		private Button student, tutor;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.LoginDirector);
			// Create your application here
			loadAllBaseViews();

			setUpAllActions();
		}

		private void loadAllBaseViews()
		{
			student = FindViewById<Button>(Resource.Id.Studentbutton);
			tutor = FindViewById<Button>(Resource.Id.Tutorbutton);
		}
		private void setUpAllActions()
		{
			student.Click += StudentButton_Click; ;
			tutor.Click += Tutor_Click;
		}
		private void StudentButton_Click(object sender, EventArgs e)
		{
			StartActivity(typeof(SignUpA));
		}

		private void Tutor_Click(object sender, EventArgs e)
		{
			StartActivity(typeof(SignUpTutorA));
		}
	}
}
