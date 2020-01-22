
using System;

namespace Жареное_мясо
{

	public class Vishibala: People
	{
		public override void rabotat()
			
		{ 
			dolgod--;
			if(dolgod % 2==0)
			{
				Program.Sash-=cash;
			}
				
			Program.Sash+=exp*2;
			Console.WriteLine("Делаю Деньги \n");
			
			
		}
		public Vishibala(int dolgot, int exp, int cash, string Imya):base(dolgot, exp, cash, Imya)
		{Class="Vishibala";
			minplata=200;}
	}
}
