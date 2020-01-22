
using System;

namespace Жареное_мясо
{

	public class Item
	{ public string Name;
    public int Stoimost;
public string Rarity;
public float percentbonus;
public int ID;
			public string des;
			public int bonusdoce;
			public int bonusexc;
			public int timebonus;
			
			
		public Item(int ID)			
		{   
			this.ID=ID;
			switch (ID)
			{
				case 0  :
					Name="Степендия";
						Stoimost=500;
					percentbonus=0.05f;
					des="Это ваша степуха, она крутая и даёт +5% к вашему доходу";
						Rarity="Basic";
						break;
					case 1 :
						Name="Кольцо из колечной кольцности";
						Stoimost=1000;
						percentbonus=0.1f;
						des="Мой Диллер говорит что достал его из колечной страны колечного \n города и в колечном заводе по кольцам даёт +10% к доходу";
						Rarity="Basic";
						
						break;
					case 2:
						Name="Ничего";
						Stoimost=1;
						percentbonus=0.00001f;
						des="А, ну раз так...";
						Rarity="SUPER RARE";
							break;
						case 3:
							Name="Грозный взгляд";
							Stoimost=5000;
							percentbonus=0;
							des="Увеличивает долгосрочность работников на 1 день";
								Rarity="Epic Fearsome";
							bonusdoce=1;
						break;
					case 4:
						Name="Мотивация";
							Stoimost=2000;
						bonusexc=20;
						des="Пессимист это пессимист в квадрате(Даёт +20 к работоспособности всех рабочих)";
							Rarity="Rarity";
							break;
						case 5:
							Name="Крутые собаки";
							Stoimost=5900;
							bonusexc=10;
							percentbonus=0.10f;
							bonusdoce=2;
							des="Круче их только крутые собаки с крутыми очками в крутом доме";
							Rarity="Epic Dog";
							break;
						case 6:
							Name="Часные часы";
							Stoimost=1000;
							bonusexc=0;
								percentbonus=0;
								bonusdoce=0;
								timebonus=2;
								des="Они из часного мира где время подвластно Киберсливе ";
								Rarity="Time";
							break;
						case 7:
							Name="Винтовка колбасина";
							Stoimost=10000;
							percentbonus=1f;
							des="Отстреливает колбаски лучше чем любой рабочий";
							Rarity="*poof*";
							break;
							
							
					default:
						throw new Exception("Ошибка, такого ID не существует");
						
						
			}
			
		}
	}
}
