using System;
using System.Collections.Generic;
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
    class LocalDataAccessLayer
    {
        //Code for singlton design pattern setup
        private static LocalDataAccessLayer data = null;
        public static LocalDataAccessLayer getInstance()
        {
            if(data == null)
                data = new LocalDataAccessLayer();

            return data;
        }

        //Regular class data and methods
        private SQLiteConnection dbConnection = null;

        /*=====================================================================
        * Constructor
        =====================================================================*/
        private LocalDataAccessLayer()
        {
            setUpDB();
        }

        /*=====================================================================
         * Deconstructor (Called when the object is destroyed)
         * closes connection to the database
          =====================================================================*/
        ~LocalDataAccessLayer()
        {
            shutDown();
        }

        /*=====================================================================
        * Deconstructor (Called when the object is destroyed);
         =====================================================================*/
        private void shutDown()
        {
            if (dbConnection != null)
                dbConnection.Close();
        }

        /*=====================================================================
         * Initial setup of tables in the database
         =====================================================================*/
        private void setUpTables()
        {
            dbConnection.CreateTable<Student>(); // example table being created
			dbConnection.CreateTable<Tutor>();
			dbConnection.CreateTable<Session>();
			dbConnection.CreateTable<SessionTutorClass>();
			dbConnection.CreateTable<SessionStudentClass>();
        }
        /*=====================================================================
         * Initial connection to the database
         =====================================================================*/
        private void setUpDB()
        {
          //get the path to where the application can store internal data 
          string folderPath = System.Environment.GetFolderPath( System.Environment.SpecialFolder.ApplicationData );
          string dbFileName = "AppData.db"; // name we want to give to our db file
          string fullDBPath = System.IO.Path.Combine(folderPath,dbFileName); // properly formate the path for the system we are on

          //if file does not already exist it will be created for us
          dbConnection = new SQLiteConnection(fullDBPath);
          setUpTables(); // this happens very time.
        }

        public void addStudent(Student info)
        {
            dbConnection.Insert(info);
        }

		public void addTutor(Tutor info)
		{
			dbConnection.Insert(info);
		}

		public void addSession(Session info)
		{
			dbConnection.Insert(info);
		}

		public void addSessionStudentRecord(SessionStudentClass info)
		{
			dbConnection.Insert(info);
		}

		public void addSessionTutorRecord(SessionTutorClass info)
		{
			dbConnection.Insert(info);
		}

        public Student getStudentByID(int id)
        {
            return dbConnection.Get<Student>(id);
        }

		public Tutor getTutorByID(int id)
		{
			return dbConnection.Get<Tutor>(id);
		}

		public Session getSessionByID(int id)
		{
			return dbConnection.Get<Session>(id);
		}

		public SessionStudentClass getSessionStudentRecord(int id)
		{
			return dbConnection.Get<SessionStudentClass>(id);
		}

		public SessionTutorClass getSessionTutorRecord(int id)
		{
			return dbConnection.Get<SessionTutorClass>(id);
		}

        public void deleteStudentByID(int id)
        {
            dbConnection.Delete<Student>(id);
        }

		public void deleteTutorByID(int id)
		{
			dbConnection.Delete<Student>(id);
		}

		public void deleteSessionByID(int id)
		{
			dbConnection.Delete<Student>(id);
		}


		public void deleteSessionStudentRecord(int id)
		{
			dbConnection.Delete<SessionStudentClass>(id);
		}

		public void deleteSessionTutorRecord(int id)
		{
			dbConnection.Delete<SessionTutorClass>(id);
		}

        public void updateStudentInfo(Student info)
        {
            dbConnection.Update(info);
        }

		public void updateTutorInfo(Tutor info)
		{
			dbConnection.Update(info);
		}

		public void updateSessionInfo(Session info)
		{
			dbConnection.Update(info);
		}

        public List<Student> getAllStudents()
        {
            //gets all elements in the Student table and packages it into a List
            return new List<Student>(dbConnection.Table<Student>());
        }

		public List<Tutor> getAllTutor()
		{
			//gets all elements in the Student table and packages it into a List
			return new List<Tutor>(dbConnection.Table<Tutor>());
		}

		public List<Session> getAllSession()
		{
			//gets all elements in the Student table and packages it into a List
			return new List<Session>(dbConnection.Table<Session>());
		}

        public List<Student> getAllStudentsOrdered()
        {
            //gets all elements in the Student table and packages it into a List
			return new List<Student>(dbConnection.Table<Student>().OrderBy(st => st.lastName));
        }

		public List<Tutor> getAllTutorsOrdered()
		{
			//gets all elements in the Student table and packages it into a List
			return new List<Tutor>(dbConnection.Table<Tutor>().OrderBy(st => st.lastName));
		}

		public List<Session> getAllSessionOrdered()
		{
			//gets all elements in the Student table and packages it into a List
			return new List<Session>(dbConnection.Table<Session>().OrderBy(st => st.courseName));
		}
    }
}