using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverHouse.Technique
{
    class Clock:Device
    {
       string TimeAlarm = "0";
        
        
        public Clock(String Name,bool state)
        {
            this.Name = Name;
            this.state = state;
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

            
            return "состояние: " + state + ",  время будильника " + TimeAlarm;
        }

        public string ChangeTime()
        {
            Console.WriteLine("Enter the time of alarm in format hh.mm");
            string ValueTime = Console.ReadLine();
           
            TimeAlarm = ValueTime;
            return TimeAlarm;
        }

        public void Help()
        {
            Console.WriteLine("Доступные команды:");
            Console.WriteLine("ON  for switch on alarm");
            Console.WriteLine("OFF  for switch off alarm");
            Console.WriteLine("CT for change time of alarm");
            Console.WriteLine("Press anykey for continue");
            Console.ReadLine();
        }
    }
}
