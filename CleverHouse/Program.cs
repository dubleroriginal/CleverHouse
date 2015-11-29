using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CleverHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string BaseColor="White";
            string BaseName1 = "Lamp1";
            string BaseName2 = "Kettle1";
            string BaseName3 = "TV1";
            string BaseName4 = "Clock1";
            string BaseName5 = "Fridge1";
            string BaseName6 = "Conditioner1";

            bool IsExite=false;

           
              List<Technique.Lamp> Lamps;
              List<Technique.Kettle> Kettles;
              List<Technique.TeleVision> TVs;
              List<Technique.Clock> Clocks;
              List<Technique.Fridge> Fridges;
              List<Technique.Conditioner> Conditioners;

             // Создание 1го элемента типа лампа Lamp
              Lamps = new List<Technique.Lamp>();
              Technique.Lamp lamp = new Technique.Lamp(BaseName1,false,BaseColor,50);             
              Lamps.Add(lamp);
              // Создание 1го элемента типа чайник Kettle
               Kettles = new List<Technique.Kettle>();
               Technique.Kettle kettle = new Technique.Kettle(BaseName2, false, BaseColor);
               Kettles.Add(kettle);
               // Создание 1го элемента типа чайник TeleVision
               TVs = new List<Technique.TeleVision>();
               Technique.TeleVision tv = new Technique.TeleVision(BaseName3, false);
               TVs.Add(tv);
               // Создание 1го элемента типа чайник Clock
               Clocks = new List<Technique.Clock>();
               Technique.Clock cl = new Technique.Clock(BaseName4, false);
               Clocks.Add(cl);
               // Создание 1го элемента типа чайник Fridge
               Fridges = new List<Technique.Fridge>();
               Technique.Fridge fr = new Technique.Fridge(BaseName5, false,false,1);
               Fridges.Add(fr);
               // Создание 1го элемента типа чайник Conditioner
               Conditioners = new List<Technique.Conditioner>();
               Technique.Conditioner con = new Technique.Conditioner(BaseName6,false,2);
               Conditioners.Add(con);




               while (!IsExite)
               {
                   Console.Clear();
                   foreach (var l in Lamps)
                   {
                       Console.WriteLine("Название:    " + l.Name + ", " + l.ToString());
                   }
                   foreach (var k in Kettles)
                   {
                       Console.WriteLine("Название:    " + k.Name + ", " + k.ToString());
                   }
                   foreach (var t in TVs)
                   {
                       Console.WriteLine("Название:    " + t.Name + ", " + t.ToString());
                   }
                   foreach (var c in Clocks)
                   {
                       Console.WriteLine("Название:    " + c.Name + ", " + c.ToString());
                   }
                   foreach (var fridge in Fridges)
                   {
                       Console.WriteLine("Название:    " + fridge.Name + ", " + fridge.ToString());
                   }
                   foreach (var cond in Conditioners)
                   {
                       Console.WriteLine("Название:    " + cond.Name + ", " +cond.ToString());
                   }
                   Console.WriteLine();



                   string Search_Name;
                   Console.WriteLine("Enter the Type of the device whot parametr you whont to change");
                   Search_Name = Console.ReadLine();
                   Console.WriteLine();


                   switch (Search_Name)
                   {
                       case "exit":
                           IsExite = true;
                           break;
                       
                       case "Lamp":
                           Lamp(Lamps);
                           break;

                       case "Kettle":
                           Kettle(Kettles);
                           break;

                       case "TV":
                           TV(TVs);
                           break;

                       case "Clock":
                           Clock(Clocks);
                           break;

                       case "Fridge":
                           Fridge(Fridges);
                           break;

                       case "Con":
                           Conditioner(Conditioners);
                           break;

                       default:
                           Help();
                           break;


                   }

               }       
        }


        static void Lamp(List<Technique.Lamp>  Lamps)
        {
            string BaseColor = "White";
            string BaseName = "Lamp1";
            bool ToMenu = false;
            
           
                       
            while (!ToMenu)
            {

                Console.Clear();
                foreach (var l in Lamps)
                {
                    Console.WriteLine("Название:    " + l.Name + ", " + l.ToString());
                }

                string Search_Name;
                   Console.WriteLine("Enter name of the device");
                   Search_Name = Console.ReadLine();
                   Console.WriteLine();



                   if (Search_Name == "add")
                   {
                       string name;
                       bool HasName=false;

                       Console.WriteLine("Enter name of the Lamp");
                       name = Console.ReadLine();

                       for (int lam = 0; lam < Lamps.Count; lam++)
                       {
                           if (Lamps[lam].Name!= name)
                           {
                               HasName = true;
                           }
                           else
                           {
                               HasName = false;
                               Console.WriteLine("The device whith this name hes already");
                               Console.WriteLine("");
                               Console.WriteLine("Press any key for continue");
                               Console.ReadLine();
                           }
                                                      
                       }
                       if (HasName == true)
                       {
                           HasName = false;
                           Technique.Lamp lampp = new Technique.Lamp(name, false, BaseColor, 50);                         
                           Lamps.Add(lampp);
                       }
                       

                   }
                                 

                   if (Search_Name == "beak")
                       {
                           ToMenu = true;
                       }




                  for(int lam=0;lam<Lamps.Count;lam++)
                  {
                      if(Lamps[lam].Name==Search_Name)
                      {
                                                   
                          Console.Write("Введите команду: ");
                          string commands = Console.ReadLine();


                          switch (commands)
                          {
                              case "ON":
                                  Lamps[lam].ON();
                                  break;
                              case "OFF":
                                  Lamps[lam].OFF();
                                  break;
                              case "BR":
                                  Lamps[lam].Brightness();
                                  break;
                              case "CL":
                                  Lamps[lam].ColorLoght();
                                  break;
                              case "del":
                                  Lamps.RemoveAt(lam);
                                  break;
                              
                              default:
                                  Lamps[0].Help();
                                  break;
                          }
                                                   
                      }

                                                
                  }
            }
            }
        static void Kettle(List<Technique.Kettle> Kettles)
        {
            string BaseColor = "White"; 
            bool ToMenu = false;



            while (!ToMenu)
            {

                Console.Clear();
                foreach (var k in Kettles)
                {
                    Console.WriteLine("Название:    " + k.Name + ", " + k.ToString());
                }

                string Search_Name;
                Console.WriteLine("Enter name of the device");
                Search_Name = Console.ReadLine();
                Console.WriteLine();



                if (Search_Name == "add")
                {
                    string name;
                    bool HasName = false;

                    Console.WriteLine("Enter name of the Lamp");
                    name = Console.ReadLine();

                    for (int ket = 0; ket < Kettles.Count; ket++)
                    {
                        if (Kettles[ket].Name != name)
                        {
                            HasName = true;
                        }
                        else
                        {
                            HasName = false;
                            Console.WriteLine("The device whith this name hes already");
                            Console.WriteLine("");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadLine();
                        }

                    }
                    if (HasName == true)
                    {
                        HasName = false;
                        Technique.Kettle kettle = new Technique.Kettle(name, false, BaseColor);
                        Kettles.Add(kettle);
                    }


                }


                if (Search_Name == "beak")
                {
                    ToMenu = true;
                }




                for (int ket = 0; ket < Kettles.Count; ket++)
                {
                    if (Kettles[ket].Name == Search_Name)
                    {

                        Console.Write("Введите команду: ");
                        string commands = Console.ReadLine();


                        switch (commands)
                        {
                            case "ON":
                                Kettles[ket].ON();
                                break;

                            case "OFF":
                                Kettles[ket].OFF();
                                break;
                           
                            case "CL":
                                Kettles[ket].ColorBeaklight();
                                break;

                            case "del":
                                Kettles.RemoveAt(ket);
                                break;

                            default:
                                Kettles[0].Help();
                                break;
                        }

                    }


                }
            }
        }
        static void TV(List<Technique.TeleVision> TVs)
        {
             string BaseColor = "White"; 
            bool ToMenu = false;



            while (!ToMenu)
            {

                Console.Clear();
                foreach (var tv in TVs)
                {
                    Console.WriteLine("Название:    " + tv.Name + ", " + tv.ToString());
                }

                string Search_Name;
                Console.WriteLine("Enter name of the device");
                Search_Name = Console.ReadLine();
                Console.WriteLine();



                if (Search_Name == "add")
                {
                    string name;
                    bool HasName = false;

                    Console.WriteLine("Enter name of the TV");
                    name = Console.ReadLine();

                    for (int tv = 0; tv < TVs.Count; tv++)
                    {
                        if (TVs[tv].Name != name)
                        {
                            HasName = true;
                        }
                        else
                        {
                            HasName = false;
                            Console.WriteLine("The device whith this name hes already");
                            Console.WriteLine("");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadLine();
                        }

                    }
                    if (HasName == true)
                    {
                        HasName = false;
                        Technique.TeleVision Tv = new Technique.TeleVision(name, false);
                        TVs.Add(Tv);
                    }


                }


                if (Search_Name == "beak")
                {
                    ToMenu = true;
                }




                for (int tv = 0; tv < TVs.Count; tv++)
                {
                    if (TVs[tv].Name == Search_Name)
                    {

                        Console.Write("Введите команду: ");
                        string commands = Console.ReadLine();


                        switch (commands)
                        {
                            case "ON":
                                TVs[tv].ON();
                                break;

                            case "OFF":
                                TVs[tv].OFF();
                                break;

                            case "N":
                                TVs[tv].ChangeUp();
                                break;

                            case "C":
                                TVs[tv].ChuseChanal();
                                break;

                            case "P":
                                TVs[tv].ChangeDown();
                                break;

                            case "BR":
                                TVs[tv].Brightness();
                                break;

                            case "del":
                                TVs.RemoveAt(tv);
                                break;

                            default:
                                TVs[0].Help();
                                break;
                        }

                    }
                }
            }
        
        }
        static void Clock(List<Technique.Clock> Clocks)
        {
            bool ToMenu = false;



            while (!ToMenu)
            {

                Console.Clear();
                foreach (var cl in Clocks)
                {
                    Console.WriteLine("Название:    " + cl.Name + ", " + cl.ToString());
                }

                string Search_Name;
                Console.WriteLine("Enter name of the device");
                Search_Name = Console.ReadLine();
                Console.WriteLine();



                if (Search_Name == "add")
                {
                    string name;
                    bool HasName = false;

                    Console.WriteLine("Enter name of the Alarm");
                    name = Console.ReadLine();

                    for (int clock = 0; clock < Clocks.Count; clock++)
                    {
                        if (Clocks[clock].Name != name)
                        {
                            HasName = true;
                        }
                        else
                        {
                            HasName = false;
                            Console.WriteLine("The device whith this name hes already");
                            Console.WriteLine("");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadLine();
                        }

                    }
                    if (HasName == true)
                    {
                        HasName = false;
                        Technique.Clock clock = new Technique.Clock(name, false);
                        Clocks.Add(clock);
                    }


                }


                if (Search_Name == "beak")
                {
                    ToMenu = true;
                }




                for (int clock = 0; clock < Clocks.Count; clock++)
                {
                    if (Clocks[clock].Name == Search_Name)
                    {

                        Console.Write("Введите команду: ");
                        string commands = Console.ReadLine();


                        switch (commands)
                        {
                            case "ON":
                                Clocks[clock].ON();
                                break;

                            case "OFF":
                                Clocks[clock].OFF();
                                break;

                            case "CT":
                                Clocks[clock].ChangeTime();
                                break;

                            case "del":
                                Clocks.RemoveAt(clock);
                                break;

                            default:
                                Clocks[0].Help();
                                break;
                        }

                    }
                }
            }
        }
        static void Fridge(List<Technique.Fridge> Fridges)
        {
            bool ToMenu = false;



            while (!ToMenu)
            {

                Console.Clear();
                foreach (var Fr in Fridges)
                {
                    Console.WriteLine("Название:    " + Fr.Name + ", " + Fr.ToString());
                }

                string Search_Name;
                Console.WriteLine("Enter name of the device");
                Search_Name = Console.ReadLine();
                Console.WriteLine();



                if (Search_Name == "add")
                {
                    string name;
                    bool HasName = false;

                    Console.WriteLine("Enter name of the TV");
                    name = Console.ReadLine();

                    for (int fr = 0; fr < Fridges.Count; fr++)
                    {
                        if (Fridges[fr].Name != name)
                        {
                            HasName = true;
                        }
                        else
                        {
                            HasName = false;
                            Console.WriteLine("The device whith this name hes already");
                            Console.WriteLine("");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadLine();
                        }

                    }
                    if (HasName == true)
                    {
                        HasName = false;
                        Technique.Fridge fridge = new Technique.Fridge(name, false,false,1);
                        Fridges.Add(fridge);
                    }


                }


                if (Search_Name == "beak")
                {
                    ToMenu = true;
                }




                for (int fr = 0; fr < Fridges.Count; fr++)
                {
                    if (Fridges[fr].Name == Search_Name)
                    {

                        Console.WriteLine("Введите команду: ");
                        string commands = Console.ReadLine();


                        switch (commands)
                        {
                            case "ON":
                                Fridges[fr].ON();
                                break;

                            case "OFF":
                                Fridges[fr].OFF();
                                break;

                            case "OnF":
                                Fridges[fr].ONFrize();
                                break;

                            case "OfF":
                                Fridges[fr].OFFFrize();
                                break;

                            case "PR":
                                Fridges[fr].Programm();
                                break;
                                                            

                            case "del":
                                Fridges.RemoveAt(fr);
                                break;

                            default:
                                Fridges[0].Help();
                                break;
                        }

                    }
                }
            }
        }
        static void Conditioner(List<Technique.Conditioner> Conditioners)
        {
            bool ToMenu = false;



            while (!ToMenu)
            {

                Console.Clear();
                foreach (var con in Conditioners)
                {
                    Console.WriteLine("Название:    " + con.Name + ", " + con.ToString());
                }

                string Search_Name;
                Console.WriteLine("Enter name of the device");
                Search_Name = Console.ReadLine();
                Console.WriteLine();



                if (Search_Name == "add")
                {
                    string name;
                    bool HasName = false;

                    Console.WriteLine("Enter name of the Conditioner");
                    name = Console.ReadLine();

                    for (int cond = 0; cond < Conditioners.Count; cond++)
                    {
                        if (Conditioners[cond].Name != name)
                        {
                            HasName = true;
                        }
                        else
                        {
                            HasName = false;
                            Console.WriteLine("The device whith this name hes already");
                            Console.WriteLine("");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadLine();
                        }

                    }
                    if (HasName == true)
                    {
                        HasName = false;
                        Technique.Conditioner conditioner = new Technique.Conditioner(name,false,2);
                        Conditioners.Add(conditioner);
                    }


                }


                if (Search_Name == "beak")
                {
                    ToMenu = true;
                }




                for (int cond = 0; cond < Conditioners.Count; cond++)
                {
                    if (Conditioners[cond].Name == Search_Name)
                    {

                        Console.WriteLine("Введите команду: ");
                        string commands = Console.ReadLine();


                        switch (commands)
                        {
                            case "ON":
                                Conditioners[cond].ON();
                                break;

                            case "OFF":
                                Conditioners[cond].OFF();
                                break;

                            case "H":
                                Conditioners[cond].Hot();
                                break;

                            case "S":
                                Conditioners[cond].Odinary();
                                break;

                            case "C":
                                Conditioners[cond].Cold();
                                break;

                            

                            case "del":
                                Conditioners.RemoveAt(cond);
                                break;

                            default:
                                Conditioners[0].Help();
                                break;
                        }

                    }
                }
            }
        }






        static void Help()
        {
            Console.WriteLine("Доступные типы устройств:");
            Console.WriteLine("Lamp");
            Console.WriteLine("Clock");
            Console.WriteLine("Fridge");
            Console.WriteLine("Kettle");
            Console.WriteLine("TV");
            Console.WriteLine("Con   Conditioner");
            Console.WriteLine(""); Console.WriteLine("");

            Console.WriteLine("Доступные команды:");
            Console.WriteLine("exit  for out");
            Console.WriteLine("beak  for return to past menu");
            Console.WriteLine("add after chuse type of the device for create new");            
            Console.WriteLine("");
            Console.WriteLine("Press any key for continue");
            Console.ReadLine();
        }
    }
}
