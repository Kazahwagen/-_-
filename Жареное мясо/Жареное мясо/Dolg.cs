
using System;

namespace Жареное_мясо
{

	public class Dolg
	{ public int Dayplata;
			public int Daytime;
			public string enddolg;
			public void upddolg()
			 {
				Program.Sash-=Dayplata;
				Daytime--;
				if(Daytime<=0)
				{ Program.dodl.Remove(this);
					Console.WriteLine(enddolg);
					

				}
				
				
			}
		public Dolg(int Dayplata, int Daytime, string enddolg)
		{
			this.Dayplata=Dayplata;
			this.Daytime=Daytime;
			this.enddolg=enddolg;
			
			
			
		}
	}
}
