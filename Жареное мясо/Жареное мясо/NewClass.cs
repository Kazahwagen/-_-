
using System;

namespace Жареное_мясо
{

	public class Gastarbaiter: People
	{  public override void rabotat()
			
		{ 
			dolgod--;
			if(dolgod % 3==0)
			{
				Program.Sash-=cash;
			}
				
			Program.Sash+=exp;
			Console.WriteLine("Делаю Калбасачки \n");
			
			
		}
		public Gastarbaiter(int dolgot, int exp, int cash, string Imya):base(dolgot, exp, cash, Imya)
		{Class="Gastarbaiter";
			minplata=100;
			
			
		}
	}
}
