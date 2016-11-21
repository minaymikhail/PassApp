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
	public class Session
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; } // auto set when isnerted to the db
		public string courseName { get; set; }
		public string description { get; set; }
		public string location { get; set; }
		public string tutorName { get; set; }
		public string startTime { get; set; }
		public string endTime { get; set; }
		public string date { get; set; }

		public Session() { } // must have a default constructor to use SQLite methods 

		public Session(string name, string description, string location, string tutorName, string startTime, string endTime, string date)
		{
			this.courseName = courseName;
			this.description = description;
			this.location = location;
			this.tutorName = tutorName;
			this.startTime = startTime;
			this.endTime = endTime;
			this.date = date;
		}



		public override string ToString() // called when object geven to list for default list display
		{
			return courseName + "\n" + description + "\n" + location + "\n" + tutorName;
		}

	}
}