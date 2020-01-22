
using System;

namespace Жареное_мясо
{

	 public class People
	{   public string Class;
		public int dolgod;
		public int exp;
		public int cash;
		public string Imya;
		public int minplata;
		public virtual void rabotat()
		{
			
			
			
		}
		public People(int dolgod,int exp, int cash, string Imya)
		{
			this.dolgod=dolgod;
			this.exp=exp;
			this.cash=cash;
			this.Imya=Imya;
			
			
			
		}
	}
}
