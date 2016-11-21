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
    public class Student
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; } // auto set when isnerted to the db
        public string firstName { get; set; }
		public string lastName { get; set; }
		public string email { get; set; }
		public int studentId { get; set; }
		public string password { get; set; }

        public Student() { } // must have a default constructor to use SQLite methods 

        public Student(string firstName, string lastName, string email, int studentId, string password)
        {
			this.firstName = firstName;
			this.lastName = lastName;
			this.email = email;
			this.studentId = studentId;
			this.password = password;
        }

		public bool doesPasswordMatch(int enterPassword)
		{
			return password.Equals(enterPassword);
		}
       
   
        public override string ToString() // called when object geven to list for default list display
        {
			return firstName + " " + lastName; 
        }

    }
}