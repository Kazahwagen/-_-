
using System;

namespace Жареное_мясо
{

	public class Location
	{ public string namel; 
		public int doxod;
		public int stoits;
	public string opisanie;
	public bool keka;
		public Location(string namel, int doxod, int stoits, string opisanie)
		{  this.namel=namel;
		this.doxod=doxod;
		this.stoits=stoits; 
		this.opisanie=opisanie;
	    keka=false;
		}
	}
}
