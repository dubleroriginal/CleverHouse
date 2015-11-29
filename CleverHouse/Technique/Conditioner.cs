using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverHouse.Technique
{
    class Conditioner:Device
    {
        private int Programm;


        public Conditioner(String Name, bool state, int programm)
        {
            this.Name = Name;
            this.state = state;
            this.Programm=programm;
        }


        public void ON()
        {
            state = true;
        }
        public void OFF()
        {
            state = false;
        }


        public void Hot()
        {
            Programm = 1; 
        }
        public void Odinary()
        {
            Programm = 2; 
        }
        public void Cold()
        {
            Programm = 3; 
        }


        public override string ToString()
        {
            string state,program;
            if (this.state)
            {
                state = "Включен";
            }
            else
            {
                state = "Выключен";
            }

            if(this.Programm==1)
            {
                program = "охлаждение";
            }
            else if (this.Programm == 2)
            {
                program = "проветривание";
            }
            else
            {
                program = "нагрев";
            }

            return "состояние: " + state + ",  режим " + program;
        }

    

        public void Help()
        {
            Console.WriteLine("Доступные команды:");
            Console.WriteLine("ON  for switch on alarm");
            Console.WriteLine("OFF  for switch off alarm");
            Console.WriteLine("C for change programm on cold");
            Console.WriteLine("H for change programm on hot");
            Console.WriteLine("S for change programm on odinary");
            Console.WriteLine("Press anykey for continue");
            Console.ReadLine();
        }

    }
}
