using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverHouse.Technique
{
    class Lamp:Device
    {
             

        public Lamp(string Name,bool state, string LightColor,int Britness)
       {
           this.state = state;
           this.color = LightColor;
           this.BrightnessValue = Britness;
           this.Name = Name;
          
       }


      public  void ON ()
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
          return "состояние: " + state + ", яркость: " + BrightnessValue+" цвет " +color;
      }

      public int Brightness()
        {
            Console.WriteLine("Enter the brightness in persint");
            string ValueOffBrightness = Console.ReadLine();
            int value=Convert.ToInt32(ValueOffBrightness);
            BrightnessValue = value;
            return BrightnessValue;
        }
      public string ColorLoght ()       
      {
          string newcolor;
          Console.WriteLine("write new light`s color");
          newcolor=Console.ReadLine();
          color = newcolor;
          return color;
      }



      public void Help()
        {
            Console.WriteLine("Доступные команды:");
            Console.WriteLine("ON  for switch on");
            Console.WriteLine("OFF  for switch off");
            Console.WriteLine("BR for change brightness");
            Console.WriteLine("CL for change light`s color");
            Console.WriteLine("Press anykey for continue");
            Console.ReadLine();
        }
    }
}
