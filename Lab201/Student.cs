using System;

namespace Lab2
{
	public class Student
	{
		private string name;
		private string id;
		private int yearOfBirth;
		private bool isActive;

		public string Name
		{
			set
			{
				name = value;
			}
			get
			{
				return name;
			}
		}
		public string Id
		{
			set
			{
				id = value;
			}
			get
			{ return id;}
		}
		public int YearOfBirth
		{
			set
			{ 
				if (value >=1950 && value <= 2000) {
					yearOfBirth = DateTime.Now.Year - value;
				} 
				else {
					Console.WriteLine ("{0} :error try setting invalid year-of-birth value!",id);

				}
			}
			get
			{
				return yearOfBirth;

			}
		}

		public bool IsActive
		{
			set
			{
				isActive = value;
			}
			get
			{
				if (isActive == true) {
					
					return isActive;
				} else {
					
					return isActive;
				}
			}
		}

		public Student ()
		{
			Name = "John Doe";
			Id = "unknow";
			YearOfBirth = 1995;
			IsActive = false;

		}
		public Student(string n,string i)
		{
			Name = n;
			Id = i;
			YearOfBirth = 1995;
			IsActive = true;

		}
		public Student(string n,string i,int y)
		{
			Name = n;
			Id = i;
			YearOfBirth = y;
			IsActive = true;

		}
		public Student(string n,string i,int y,bool a)
		{
			Name = n;
			Id = i;
			YearOfBirth = y;
			IsActive = a;

		}


		public override string ToString ()
		{
			if (isActive) {
				return string.Format ("[Student:{0},({1}), age = {2},is active student]",Name,Id,YearOfBirth);
			} else {
				return string.Format ("[Student:{0},({1}), age = {2},is NOT active student]",Name,Id,YearOfBirth);
			}

		}

	}
}

