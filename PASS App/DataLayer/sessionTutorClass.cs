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
using SQLite;


namespace Pass_App
{
	public class SessionTutorClass
	{
		[PrimaryKey, AutoIncrement]
		public int courseID { get; set; } // auto set when isnerted to the db
		public int tutorId { get; set; }

		public SessionTutorClass() { } // must have a default constructor to use SQLite methods 

		public SessionTutorClass(int courseID, int tutorId)
		{
			this.courseID = courseID;
			this.tutorId = tutorId;
		}

	}
}