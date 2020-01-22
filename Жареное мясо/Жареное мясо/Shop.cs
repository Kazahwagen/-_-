
using System;

namespace Жареное_мясо
{
   
	public class Shop
	{
		private static Item[]zuzulba=new Item[20];
			public static void zazala()
		{
			for(int i=0; i<zuzulba.Length; i++)
			{
				if(zuzulba[i]!=null)
					Console.WriteLine(zuzulba[i].ID+" "+zuzulba[i].Name+"\n"+zuzulba[i].des+"\n "+zuzulba[i].Stoimost+"$ \n"+zuzulba[i].Rarity+"\n \n");
				
			}
			
			
		}
			public static Item buy(int ID)
			{
				for(int zen=0;zen<zuzulba.Length;zen++)
				{
					if(zuzulba[zen]!=null && zuzulba[zen].ID==ID)
					{
						if(zuzulba[zen].Stoimost<=Program.Sash)
						{
							Program.Sash-=zuzulba[zen].Stoimost;
							return zuzulba[zen];
						}
						else
						{
							Console.WriteLine("Нету ваших money");
							break;
						}
						
					}
					
				}return null;
			}
		 static Shop()
		{
		 	
			for(int i=0;i<8;i++)
			{  
				zuzulba[i]=new Item(i); 
			}
			
		}
	}
}
