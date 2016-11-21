
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
	[Activity(Label = "CreateSession1A")]
	public class CreateSession1A : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.CreateSession1);
			// Create your application here
			Button nextButton = FindViewById<Button>(Resource.Id.nextButton);
			nextButton.Click += delegate {
				StartActivity(typeof(CreateSession2A));
			};
		}
	}
}
