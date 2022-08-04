using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDotNetApllication
{
    internal class FactoryDesign
    {
        public static ICar getCar(string carType)
        {
            ICar car = null;
            if(carType=="Honda")
            {
                car = new Honda();
            }
            else if (carType == "Maruti")
            {
                car = new Maruti();
            }
            else if (carType == "Kia")
            {
                car = new Kia();
            }
            return car;

        }
    }
}
