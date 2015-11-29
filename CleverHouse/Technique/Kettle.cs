using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverHouse.Technique
{
    class Kettle:Device
    {
        public Kettle(String Name,bool state, string ColorBeaklight)
        {
            this.Name = Name;
            this.state = state;
            this.color = ColorBeaklight;
        }

        public void ON()
        {
            state = true;
        }
        public void OFF()
        {
            state = false;
        }

        public override string ToString()
        {
            string state;
            if (this.state)
            {
                state = "Включен";
            }
            else
            {
                state = "Выключен";
            }
            return "состояние: " + state + ",  цвет " + color;
        }



        public string ColorBeaklight()
        {
            string newcolor;
            Console.WriteLine("write new light`s color");
            newcolor = Console.ReadLine();
            color = newcolor;
            return color;
        }

        public void Help()
        {
            Console.WriteLine("Доступные команды:");
            Console.WriteLine("ON  for switch on");
            Console.WriteLine("OFF  for switch off");            
            Console.WriteLine("CL for change light`s color");
            Console.WriteLine("Press anykey for continue");
            Console.ReadLine();
        }
    }
}
