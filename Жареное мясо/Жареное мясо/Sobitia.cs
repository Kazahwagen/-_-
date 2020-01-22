
using System;

namespace Жареное_мясо
{

	public class Sobitia
	{  public static bool killkomm=false;
		public int day;
		public int month;
		public int year;
		public string names;
		
		public string dis;
		public Sobitia(int day,int month,int year)
		{ string switcher=day+" "+month+" "+year;
				switch(switcher)
			{
				case "10 5 1995":
						Console.WriteLine("Работник не работник");
					if(Program.rab.Count>0)
					{
                      dis="-Он перестал работать? \n -Да, он дибил просто. \n -Так почините его. Сказал Бульбушмек и умер";	
						Program.rab.RemoveAt(0);
							Console.WriteLine("Вы потеряли крутого чела");}
					else
					{
						Console.WriteLine("-Он перестал работать? Сказал Бурендык \n -Ты шизик? Тут никого нет...");
							Program.Sash-=50;
								Console.WriteLine("Вы потеряли 50 золотых колец");
					} 
                break;
               case "20 5 1995":
                Console.WriteLine("Буржуйский кризис");
                
                if(Program.Sash>1000)
                {dis="-Босс у нас слишком много денег, нам нужно раздать их рабочим. \n -Нет дэбил иди делай мяса!";
                   Program.Sash/=2;
                	Console.WriteLine("Вы потеряли половину своих денег");}
                else
                {
                	Console.WriteLine("-Сэр у нас нет денег, что нам делать? \n -Так идите работать дэбилы!..");
                	Program.Sash*=2;
                	Console.WriteLine("Рабочие работают лучше, ваши деньги удвоились");
                 }break;
               case "30 5 1995":
                Console.WriteLine("Налоговая коммисия");
                Console.WriteLine("-Босс у меня для вас проблемы, Они опять приехали, что собираемся делать?");
                if(Program.Sash>0)
                {
                	
                		Console.WriteLine("У меня есть выбор, kill or pay, что выбрать?");
                	string kill;
                	do
                	{ kill=Console.ReadLine();
                		if(kill=="kill")
                		{
                			killkomm=true;
                			Console.WriteLine("Вы убили коммисию, это повлияет на сюжет");
                			if(Program.rab.Count>0)
                			{
                				Program.rab.RemoveAt(0);
                					Console.WriteLine("Один ваш рабочий сгинул, он был храбрым в этой войне");
                					
                			}else
                			{
                				Console.WriteLine("Никто не умер, потому-что никого нет");
                			}
                		}else if(kill=="pay")
                		{
                			Console.WriteLine("Вы легко отделались бебилы, это повлияет на сюжет");
                			Program.Sash-=500;
                			Console.WriteLine("Вы потеряли 500 монет");
                		}
                		else
                		{
                			Console.WriteLine("Я тебе сказал выбирать");	
                		}

                	}while (kill!="kill" && kill!="pay");
                }break;
               case "10 6 1995":
                Console.WriteLine("Кто-то приехал");
                Console.WriteLine("К вам нагрянула полиция по вашим странным делам, а может и нет");
                if(killkomm)
                {
                	Program.dodl.Add(new Dolg(50,20,"У вас кончился долг"));
                	Console.WriteLine("-Нам стало известно что вы убили нашу коммисию \n Мы делаем вам штраф в размере 50 монет каждый день");
                	Console.WriteLine("На вас накинули долг, вы обязаны платить каждый день 50 монет");
                }else 
                {  
                	Console.WriteLine("Здраствуйте, у вас всё хорошо? Ну и отлично, вот вам монетка");
                	Program.Sash+=1;
                	Console.WriteLine("Вы получили монетку");
                }
                break;
               
               case "25 6 1995":
                Console.WriteLine("Неожиданный безумец");
                Console.WriteLine("Кто то нагрянул к вам, нужно что то сделать");
                
                if(Program.rab.Count>=2)
                { Console.WriteLine("-Сэр, возле нашего помещения обнаружен какой-то безумец \n он ходит по окрестности и кричит \"Change da world, my final message, goodb ye\" что предложите сделать?");
                metka:
                	string vybor=vibor("Да","Нет","Убить","Заплатить","Прогнать","Нанять");
                		
                	switch(vybor)
                { case "Да":
                Console.WriteLine("Что да? Что нам с ним делать балда?");
                goto metka;
                	break;
                case "Нет":
                	Console.WriteLine("Что нет, Нам его прогнать?");
                	goto metka;
                	break;
                case "Убить":
                	foreach(People ded in Program.rab)
                	{
                		ded.dolgod--;
                		
                	}Console.WriteLine("Мы успешно убили безумца, все мы потеряли один день работоспособности");
                	break;
                case "Заплатить":
                	Program.Sash-=100;
                		Console.WriteLine("Мы отдали ему 100 золотых и он ушёл");
                	break;
                case "Прогнать":
                	if(Program.rab.Count>0)	
                	{Program.rab.RemoveAt(0);
                		Console.WriteLine("Мы прогнали его, но какой ценой. Мы потеряли одного бойца");
                	}else
                	{
                		Program.kalendar.nextday();
                		Program.kalendar.nextday();
                		Program.kalendar.nextday();
                		Console.WriteLine("Я сам прогнал его, но загремел в больницу на 3 дня, жестоко");
                	}break;
                	
                case "Нанять":
                	Random rn=new Random();
                	if(rn.NextDouble()<=0.5)
                	{
                		Program.rab.Add(new Robotnik(3,10,10,"Случайный безумец"));
                		Program.Sash-=10;
                			Console.WriteLine("Я заплатил ему 10 монет, он согласился на меня работать.");
                	}else
                	{
                		Program.kalendar.nextday();
                		Program.kalendar.nextday();
                		Program.kalendar.nextday();
                		Console.WriteLine("Он отказался от работы, и я ещё получил по голове, потерял 3 дня в этой психушке");
                		
                	}break;	
                	
                	
                
                	
                	
                }break;

                }break;
	
			}
		}
		public string vibor(params string[] vibori)	
		{   Console.WriteLine("Выберите Вариант ответа");
			for(int i=0; i<vibori.Length;i++)
			{ 
				Console.WriteLine(vibori[i]);	
			}
		  metka:
			string dibil=Console.ReadLine();
			for(int i=0; i<vibori.Length;i++)
			{
				if(dibil==vibori[i])
				{
					return dibil;
				}	
			}goto metka;
			
			
		}
	
	
	}
}
