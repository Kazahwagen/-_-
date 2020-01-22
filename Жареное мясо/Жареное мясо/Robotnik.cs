
using System;

namespace Жареное_мясо
{
    
	public  class Robotnik: People
	{  public override void rabotat()
			
		{ 
			dolgod--;
			if(dolgod % 2==0)
			{
				Program.Sash-=cash;
			}
				
			Program.Sash+=exp;
			Console.WriteLine("Делаю сасисочки \n");
			
			
		}
			
			
		public Robotnik(int dolgot, int exp, int cash, string Imya):base(dolgot, exp, cash, Imya)
		{
			Class="Rabotnik";
			minplata=0;
			
			
		}
	}
}
