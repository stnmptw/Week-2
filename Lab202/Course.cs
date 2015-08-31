using System;

namespace Lab2
{
	public class Course
	{
		private string name;
		public string Name
		{
			get { return name; }

			set
			{ name = value;}

		}

		private string courseID;
		public string CourseID
		{
			get { return courseID; }

			set
			{
				int n;
				bool isNumeric = int.TryParse(value, out n);

				if (value.Length == 6 && isNumeric) { courseID = value; }

				else { Console.WriteLine("{0}: error try setting invalid CourseID!",courseID); }
			}

		}

		private string lecturer = "staff";
		public string Lecturer
		{
			get { return lecturer; }

			set
			{ lecturer = value; }

		}
		private int maxStudents = 30;
		public int MaxStudents
		{
			get { return maxStudents; }

			set
			{ 
				if((value >=0 && value <= 80)&&( value>= numStudents))
				{
					maxStudents = value;
				}
				else
				{
					Console.WriteLine("{0}: error try setting invalid Max No. Students!",courseID);
				}

			}

		}
		private int numStudents = 0;
		public int NumStudents
		{
			get { return numStudents; }

			set
			{ if(value >=0 && value <= maxStudents)
				{
					numStudents = value;
				}
			else
			{
				Console.WriteLine("{0}: error try setting invalid No. Students!",courseID);
			}
		}

		}
		public Course ()
		{

		}
		public Course (string N,string C)
		{
			Name = N;
			CourseID = C;

		}
		public Course (string N,string C, string L)
		{
			Name = N;
			CourseID = C;
			Lecturer = L;

		}
		public Course (string N,string C, string L,int M)
		{
			Name = N;
			CourseID = C;
			Lecturer = L;
			MaxStudents = M;

		}
		private string id()
		{
			int n;

			if(CourseID.Length==6 && int.TryParse(CourseID,out n))
			{
				return CourseID;
			}
			else
			{
				Console.WriteLine ("{0}: error try setting invalid CourseID!", CourseID);
				return CourseID;
			}
		}

		public override string ToString ()
		{
			return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]", Name, CourseID, Lecturer, numStudents, MaxStudents);
		}
	}
}

