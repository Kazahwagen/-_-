
using System;

namespace Жареное_мясо
{

	public class Programmist: People
	{
		public override void rabotat()
			
		{ 
			dolgod--;
			if(dolgod % 5==0)
			{
				Program.Sash-=cash;
			}
				
			Program.Sash+=exp/5;
			Console.WriteLine("Взламывать котлеты \n");
			
			
		}
		public Programmist(int dolgot, int exp, int cash, string Imya):base(dolgot, exp, cash, Imya)
			{Class="Programmist";
			minplata=250;}

	}
}
