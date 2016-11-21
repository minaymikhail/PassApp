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
	public class SessionStudentClass
	{
		[PrimaryKey, AutoIncrement]
		public int courseID { get; set; } // auto set when isnerted to the db
		public int studentId { get; set; }

		public SessionStudentClass() { } // must have a default constructor to use SQLite methods 

		public SessionStudentClass(int courseID, int studentId)
		{
			this.courseID = courseID;
			this.studentId = studentId;
		}

	}
}