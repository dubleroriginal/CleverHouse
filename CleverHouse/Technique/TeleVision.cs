using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverHouse.Technique
{
    class TeleVision:Device
    {
        
        private int CurrentChanal;

        public TeleVision(String Name,bool state )
        {
            this.Name = Name;
            this.state = state;
            this.BrightnessValue = 50;
            this.CurrentChanal = 1;
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
            return "состояние: " + state + ",  текущий канал " + CurrentChanal + " яркость экрана " + BrightnessValue;
        }


        public int ChangeUp()
        {
            CurrentChanal++;
            if (CurrentChanal > 100)
                CurrentChanal = 1;

            return CurrentChanal;
        }
        public int ChangeDown()
        {
            CurrentChanal--;
            if (CurrentChanal < 1)
                CurrentChanal = 100;

            return CurrentChanal;
        }

        public int ChuseChanal()
        {

            Console.WriteLine("Enter the chanal");
            string Chanal = Console.ReadLine();
            int value = Convert.ToInt32(Chanal);
            CurrentChanal = value;
            
            return CurrentChanal;
        }

        public int Brightness()
        {
            Console.WriteLine("Enter the brightness in persint");
            string ValueOffBrightness = Console.ReadLine();
            int value = Convert.ToInt32(ValueOffBrightness);
            BrightnessValue = value;
            return BrightnessValue;
        }

        public void Help()
        {
            Console.WriteLine("Доступные команды:");
            Console.WriteLine("ON  for switch on");
            Console.WriteLine("OFF  for switch off");
            Console.WriteLine("N next chanal");
            Console.WriteLine("C Chuse chanal");
            Console.WriteLine("P past chanal");
            Console.WriteLine("BR for change brightness");
            Console.WriteLine("Press anykey for continue");
            Console.ReadLine();
        }
    }
}
