
using System;

namespace Жареное_мясо
{

	public class Kalendar
	{ public int day;
			public int month;
			public int year;
			public string tostring()
			{
				return "День"+" "+day+" "+"Месяц"+" "+month+" "+"Год"+" "+year;
					
			}
			public void nextday()
			{
				day++;
				Console.WriteLine("Прошёл день");
				if(day>30)
				{ 
					day=1;;
					month++;;
					Console.WriteLine("Прошёл месяц");
				}
				if(month>12)
				{   month=1 ;
					year++;;
					Console.WriteLine("Прошёл год");
				}
			}
		public Kalendar(int day, int month, int year)
		{this.day=day;
				this.month=month;
				this.year=year;
		  
		}
	}
}
