
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Жареное_мясо
	
{   [Serializable]
	class Program
	{public static int  Sash=100;
		static int lolka=0;
		public static Kalendar kalendar=new Kalendar(2,5,1995);
	static	Item[]inventory=new Item[20];
	public static List<Dolg>dodl=new List<Dolg>();
	static Location[]pepka=new Location[]
	{   
		new Location("Коробка",100,0,"Из под спичечного шкафа  Kamfpapakenpufen"),
		new Location("Где то в big sity",200,1000,"big sity, big smoke, we are buy all number nine"),
		new Location("В деревне Кавказ",300,5000,"ООООООО!!! ГОРЫ КАВКААААЗАААА!!!"),
		new Location("На дне морского H20 океана",400,10000,"Даже тут найдётся рабочая сила"),
		new Location("В туалете",500,15000,"НЕ МЕШАЙ!!!"),
		new Location("В городе Россия",600,20000,"Как же красив страна Москва"),
		new Location("Польша",700,25000,"Ты всё ещё не можешь в космос((("),
		new Location("Космическая Ракета-ТурбоСлива",1000,100000,"Вы улетели в космос на сливовой тяге"),
		new Location("Открытый Космос 2020",1100,150000,"КаК тЕбЕ тАкОе МаСкОн ИлА"),
		new Location("Марс",1500,200000,"ДЫН ДЫН ДЫН МЫ ЖАРИМ КАРТОШКУ"),
		new Location("Венера",2000,400000,"Просто Венера..."),
		new Location("Поверхность Чёрной дыры",2500,500000,"Я ВСЕГДА В САМОЙ ГУЩЕ СОБЫТИЙ"),
		new Location("Я в коридорно коридорном пространственно 24-мерном измерении турбо слив",3000,500000,"Вставить Текст"),
		new Location("Где-то",5000,1000000,"Додумайте сами"),
			
	};
		static void dobavka(Item rey)
		{ for(int i=0; i<inventory.Length;i++)
			{ if(inventory[i]==null)
				{ 
					inventory[i]=rey;
						break;
			    }
			}
		}   public static List<People>rab=new List<People>();
		
		public static void Main(string[] args)
		{  
			debil();
			
				
			
			
            
			Console.BackgroundColor=ConsoleColor.White;
			Console.ForegroundColor=ConsoleColor.DarkBlue;
			MessageBox.Show("Привет, добро пожаловать в ЖАРЕНОЕ МЯСО \n \n Что бы ознакомиться с игрой набери help","Начало");
			
			pepka[0].keka=true;
		string command;
			do
		{   
				command=Console.ReadLine();
				Console.Clear();
				switch(command)
				{
					case "rr":
						foreach(People palka in rab)
						{
							Console.WriteLine(palka.Class+" "+palka.Imya+" = Имя работника \n "+palka.dolgod+" = Работоспособность "+palka.exp+" = Опыт_работы "+palka.cash+" = Зарпалата ");
						}
						break;
					case "newname":
						Console.WriteLine("Введите имя работника или директора");
						string name=Console.ReadLine();
						foreach(People pisok in rab)
						{
							if(pisok.Imya==name && pisok!=null)
							{    Console.WriteLine("Введите новое имя");
								string novoeIma=Console.ReadLine();
									pisok.Imya=novoeIma;
								break;
							}			
						}
						break;
					case "npeople":
						Console.WriteLine("Введите Имя нового работника");
						string NeVName=Console.ReadLine();
						Console.WriteLine("Введите Плату которую можете заплатить");
						try 
						{int plata=Convert.ToInt32(Console.ReadLine());
							
							
							
						
						int h=0;
						int zx=0;
						Console.WriteLine("Введите ID вашего нового рабочего");
						Console.WriteLine("0 Обычный работяга минимум стоит 0 золотых");
							Console.WriteLine("1 Гастритбитер стоит минимум 100 золотых, кусает твои биты");
							Console.WriteLine("2 Вышибала стоит минимум 200, работает лучше, лучше вас");
							Console.WriteLine("3 Программист стоит минимум 250, *Происходит Взлом котлеток*");
						int IDrab=Convert.ToInt32(Console.ReadLine());
						
						for(int g=0;g<inventory.Length;g++)
						{
							if(inventory[g]!=null)
							{  zx+=inventory[g].bonusexc;
								h+=inventory[g].bonusdoce;
							}
						}
					    
						if(plata<=Sash && plata>0)
						{   People dibil=null;
							Random zen=new Random();
							switch(IDrab)
							{
								case 0:
									Console.WriteLine("Вы купили работника и нет не раба");
									dibil=new Robotnik(7+h,zen.Next(1,plata)+zx,plata,NeVName);
								break;
							case 1:
								Console.WriteLine("Вы купили кусателя байтов, кусь");
								dibil=new Gastarbaiter(10+h,zen.Next(1,plata)+zx,plata,NeVName);
								break;
							case 2:
								Console.WriteLine("Вы купили... Нет вас купили");
								dibil=new Vishibala(5+h,zen.Next(1,plata)+zx,plata,NeVName);
								break;
							case 3:
								Console.WriteLine("Происходит взлом вашего холодильника");
								dibil=new Programmist(10+h,zen.Next(1,plata)+zx,plata,NeVName);
								break;
							}
							
							if(plata>=dibil.minplata)
							{Sash-=plata;
								rab.Add(dibil);}
							else
							{
								Console.WriteLine("Почему тут так мало, жмот");
							}
						}
						else if(plata<=0)
						{
							Console.WriteLine("Дибил ты шо воздухом платишь?");
						}
						else 
						{
							Console.WriteLine("У тэбя нету money, приходи когда будут money");
						}}catch(FormatException lololo)
						{
							Console.WriteLine("Ты буквами платить будешь, балда тупая?");	
						}
						break;
					case "work":
						kalendar.nextday();
						
						
						for(int i=0; i<dodl.Count;i++)
						{
							
							dodl[i].upddolg();
							
						}
							
						
						Sobitia bebel=new Sobitia(kalendar.day,kalendar.month,kalendar.year);
						Console.WriteLine(bebel.names);
							Console.WriteLine(bebel.dis);
						
						Console.WriteLine("Вы поработали");
						int fef=Sash;
						foreach(People gog in rab)
						{
							gog.rabotat();
							Sash+=pepka[lolka].doxod;
						}							
						for(int i=0; i<rab.Count;i++)
						{
							if(rab[i].dolgod<=0 )
							{
								Console.WriteLine("Один работник ушёл его имя : "+rab[i].Imya);
								rab.Remove(rab[i]);
							}
						}
						for(int i=0; i<inventory.Length;i++)
						{
							if(inventory[i]!=null)
							{
								kalendar.day+=inventory[i].timebonus;
								Sash+=(int)((Sash-fef)*inventory[i].percentbonus);
							}
						}
						Console.WriteLine("Вы заработали = "+(Sash-fef));
						break;
					case "stats":
						Console.WriteLine("Календарь:"+" "+kalendar.tostring());
						Console.WriteLine("Ваше money = "+ Sash);
						Console.WriteLine("Инвентарь:");
							for(int i=0; i<inventory.Length;i++)
							{   if(inventory[i]!=null)
							Console.WriteLine(inventory[i].Name);
						}
							Console.WriteLine("Ваша текущая локация и все остальные \n"+pepka[lolka].namel+"\n"+pepka[lolka].opisanie);
						break;
					case "help":
						Console.WriteLine("Введите \"rr\" что-бы узнать ваших работников" );
						Console.WriteLine("Введите \"newname\" что-бы  поменять имя вашего рабочего ");
						Console.WriteLine("Введите \"npeople\" что-бы купить нового работника");
						Console.WriteLine("Введите \"work\" что-бы работать :D");
						Console.WriteLine("Введите \"stats\"что-бы посмотреть ваше money и прочее");
						Console.WriteLine("Введите \"exit\" что-бы выйти из игры");
						Console.WriteLine("Введите \"shop\"что-бы открыть магазин");
						Console.WriteLine("Введите \"storyl\" что-бы хоть чутка узнать о сюжете");
						Console.WriteLine("Введите \"nlocation\" что-бы узнать о всех локациях");
						Console.WriteLine("Введите \"buynl\" что бы купить новую локацию");
						Console.WriteLine("Введите \"save\" что бы сохранить свою игру");
						Console.WriteLine("Введите \"back\" что бы выйти в главное меню");
						break;
					case "shop":
						Shop.zazala();
						Console.WriteLine("Введите айди предмета который хотите купить");
						int eee=0;
					    try
						{
						eee=Convert.ToInt32(Console.ReadLine());
						Item georgiy=Shop.buy(eee);
					    dobavka(georgiy);
						if(georgiy!=null)
						{
							Console.WriteLine("Вы успешно купили свой ItEm");	
						}else
							Console.WriteLine("Не купил, дебил!");					    
						}catch(FormatException heee)
						{
							Console.WriteLine("Я же сказал цифру а не кирпич, дебил...");
						}
						break;
					case "storyl":
						Console.WriteLine("Эта история повествует о том, как ваш главный герой в поисках \nнеизменных богатств  отправился далеко в далёкие земли\nчто-бы заполучить богатства вы готовы?");
					break;
				case "nlocation":
					Console.WriteLine("Гляньте на эти произведения исскуства");
					
					for(int b=0;b<pepka.Length;b++)
					{
						Console.WriteLine(b+" "+pepka[b].namel+" "+pepka[b].keka+"===="+pepka[b].stoits+"$");
						
					}
					int ID=Convert.ToInt32(Console.ReadLine());
					if(pepka[ID].keka)
					{
					lolka=ID;
					Console.WriteLine("Вы успешно сменили локацию");
					} else
					{Console.WriteLine("ЭЭэээээээээ Купи гараж");
						
					}
					
					
					
					break;
				case "buynl":
					Console.WriteLine("Купите себе новый дом, а то как лохи живёте");
					for(int b=0;b<pepka.Length;b++)
					{
						Console.WriteLine(b+" "+pepka[b].namel+" "+pepka[b].keka+"===="+pepka[b].stoits+"$");
					}
					try
					{
						int heh=Convert.ToInt32(Console.ReadLine());
						if(pepka[heh]!=null &&  pepka[heh].stoits<=Sash && !pepka[heh].keka )
					{
						Sash-=pepka[heh].stoits;
						lolka=heh;
						Console.WriteLine("Вы купили новую локацию, молодец");
						pepka[heh].keka=true;	
					}else
					{
						Console.WriteLine("Ты дебил, не купил, вали отсюда");
					}
					}catch(FormatException hehe)
					{
						Console.WriteLine("Как ты хочешь за кирпичи купить локацию, ты фундук?");
					}
					break;
				case "save":
					FileStream saveone=new FileStream("Жареное Мясо.Kazahwagen",FileMode.Create);
					BinaryWriter load=new BinaryWriter(saveone);
					load.Write(rab.Count);
					foreach(People pp in rab)
					{
						load.Write(pp.dolgod);
						load.Write(pp.cash);
						load.Write(pp.Class);
						load.Write(pp.exp);
						load.Write(pp.Imya);
						load.Write(pp.minplata);
					}
					load.Write(inventory.Length);
					for(int ii=0; ii<inventory.Length; ii++)
					{		
						if(inventory[ii]!=null)
						{
						load.Write(inventory[ii].ID);
						} 
						else
						{
							load.Write(84296);
						}
					}
					load.Write(pepka.Length);
					for(int ll=0;ll<pepka.Length;ll++)
					{
						load.Write(pepka[ll].doxod);
						load.Write(pepka[ll].keka);
						load.Write(pepka[ll].namel);
						load.Write(pepka[ll].opisanie);
						load.Write(pepka[ll].stoits);
					}
					load.Write(Sash);
					load.Write(kalendar.day);
						load.Write(kalendar.month);
						load.Write(kalendar.year);
					saveone.Close();
					Console.WriteLine("Вы успешно сохранили игру");
				break;
			case "back":
				debil();
			break;
				case "im idiot":
					Sash+=100000;
						Console.WriteLine("Congratulation you really Idiot");
					break;
				case "im stypid":
					Program.kalendar.year+=1;
						Console.WriteLine("Congratulation you really Stypid");
					break;
				case "day":
					Program.kalendar.day+=10;
						Console.WriteLine("nice");
					break;
					
				}
		}while(command!="exit");
			
		}public static void load()
		{
			FileStream stream=new FileStream("Жареное мясо.Kazahwagen",FileMode.Open);
				BinaryReader reader=new BinaryReader(stream);
				int dlinamassiva=reader.ReadInt32();
				rab.Clear();
				
				for(int i=0;i<dlinamassiva;i++)
				{ 
					int dolgod=
					reader.ReadInt32();
					int Cash=
					reader.ReadInt32();
					string Class=
					reader.ReadString();
					int exp=
					reader.ReadInt32();
					string Imya=
					reader.ReadString();
					int minplata=
					reader.ReadInt32();
					switch(Class)
					{case "Rabotnik":
						rab.Add(new Robotnik(dolgod,exp,Cash,Imya));	
						break;
					case "Gastarbaiter":
						rab.Add(new Gastarbaiter(dolgod,exp,Cash,Imya));	
                        break;
                        case "Vishibala":
						rab.Add(new Vishibala(dolgod,exp,Cash,Imya));	
                        break;
                       case "Programmist":
                        rab.Add(new Programmist(dolgod,exp,Cash,Imya));
                        break;
                                              
					}	
				}
				reader.ReadInt32();
				for(int ii=0; ii<inventory.Length; ii++)
					{		
					int Inventory=
					reader.ReadInt32();
					if(Inventory<7000)
					inventory[ii]=new Item(Inventory);

					}
				    reader.ReadInt32();
					for(int ll=0;ll<pepka.Length;ll++)
					{   int doxod=
						reader.ReadInt32();
						bool keka=
						reader.ReadBoolean();
						string namel=
						reader.ReadString();
						string opisanie=
						reader.ReadString();
						int stoits=
				     	reader.ReadInt32();
						pepka[ll]=
							new Location(namel,doxod,stoits,opisanie);
						pepka[ll].keka=keka;
					}
					Sash=
					reader.ReadInt32();
					kalendar.day=
					reader.ReadInt32();
					kalendar.month=
					reader.ReadInt32();
					kalendar.year=
					reader.ReadInt32();
					
					reader.Close();
					
					
				
		}
		public static void debil()
		{ Form okno=new Form();
		FlowLayoutPanel oknoo=new FlowLayoutPanel();
		oknoo.Height=1600;
		okno.BackgroundImageLayout=ImageLayout.Zoom;
		okno.BackgroundImage=new Bitmap("roasted_meat.png");
			Button one=new Button();
			okno.Width=1900;
			okno.Height=1600;
			one.Width=100;
			one.Height=50;
			one.BackColor=Color.Orange;
			one.Text ="Начать играть";
			one.Click+= delegate { okno.Close(); };
			Button two=new Button();
			two.Width=100;
			two.Height=50;
			two.BackColor=Color.Orange;
			two.Text= "Авторы";
			two.Click+= delegate{ MessageBox.Show( "POWERKAPLIA=>Программист создатель\n Kazahwagen=>Программист создатель\n keyfalter=> дебил\n ","Авторы дебилы" );};
			Button free=new Button();
			free.Width=100;
				free.Height=50;
			free.BackColor=Color.Orange;
			free.Text="Загрузить";
			free.Click+=delegate{load();};
			Button fo=new Button();
			fo.Width=100;
			fo.Height=50;
			fo.BackColor=Color.Orange;
			fo.Text="Выйти из игры";
			fo.Click+= delegate { System.Environment.Exit(0); };
			oknoo.Controls.Add(one);
			oknoo.Controls.Add(two);
			oknoo.Controls.Add(free);
			oknoo.Controls.Add(fo);
			okno.Controls.Add(oknoo);
			okno.ShowDialog();
		}
	}
}