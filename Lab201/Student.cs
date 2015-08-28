using System;

namespace Lab2
{
	public class Student
	{
		public string Name;
		public string id;
		public int YearOfBirth;
		public bool isActive;

		public Student ()
		{
			Name = "John Doe";
			id = "unknow";
			YearOfBirth = 1995;
			isActive = false;

		}
		public Student(string n,string i)
		{
			Name = n;
			id = i;
			YearOfBirth = 1995;
			isActive = true;

		}
		public Student(string n,string i,int y)
		{
			Name = n;
			id = i;
			YearOfBirth = y;
			isActive = true;

		}
		public Student(string n,string i,int y,bool a)
		{
			Name = n;
			id = i;
			YearOfBirth = y;
			isActive = a;

		}
		private string calculate(int x)
		{
			if (x >=1950 && x <= 2000) {
				return Convert.ToString( DateTime.Now.Year - x);
			} 
			else {
				Console.WriteLine ("{0} :error try setting invalid year-of-birth value!",id);
				return "22";
			}

		}
		private string getActive()
		{
			if (isActive == true) {
				return "is active student";
			} else {
				return "is NOT active student";
			}
		}
		public override string ToString ()
		{
			return string.Format ("[Student:{0},({1}), age = {2},{3}]",Name,id,calculate(YearOfBirth),getActive());
		}

	}
}

