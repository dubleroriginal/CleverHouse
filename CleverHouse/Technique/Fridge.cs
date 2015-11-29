using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverHouse.Technique
{
    class Fridge:Device
    {
        private bool stateFrize;
        private int Power;


        public Fridge(string Name,bool State,bool stateFrize,int programm)
        {
            this.Name = Name;
            this.state = state;
            this.stateFrize = stateFrize;
            this.Power = programm;
        }

        public void ON()
        {
            state = true;
        }
        public void OFF()
        {
            state = false;
        }

        public void ONFrize()
        {
            stateFrize = true;
        }
        public void OFFFrize()
        {
            stateFrize = false;
        }

        public override string ToString()
        {
            string state, stateFrize;
            if (this.state)
            {
                state = "Включен";
            }
            else
            {
                state = "Выключен";
            }

            if (this.stateFrize)
            {
                stateFrize = "Включен";
            }
            else
            {
                stateFrize = "Выключен";
            }
            return "состояние: " + state + ", состояние: " + stateFrize +" программа " + Power;
        }

        public int Programm()
        {
            Console.WriteLine("Enter the nedde program at range 1-5");
            string Value = Console.ReadLine();
            int value = Convert.ToInt32(Value);

            if (value >= 1 && value <= 5)
                Power = value;
            else
            {
                Console.WriteLine("it program is absent");
                Console.ReadLine();
            }


               return Power;
        }


        public void Help()
        {
            Console.WriteLine("Доступные команды:");
            Console.WriteLine("ON  for switch on ");
            Console.WriteLine("OFF  for switch off ");
            Console.WriteLine("OnF  for switch on Frize ");
            Console.WriteLine("OfF  for switch off Frize");
            Console.WriteLine("PR for change programm on cold");
            Console.WriteLine("del for delete");
           
            Console.WriteLine("Press anykey for continue");
            Console.ReadLine();
        }
    }
}
