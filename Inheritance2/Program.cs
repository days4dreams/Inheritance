using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vh = new Inheritance2.Vehicle();
            vh.numberOfWheels = 4;

            Motorbike motor = new Motorbike();
            motor.lengthOfHandlebars = 50;

            Car davesCar = new Inheritance2.Car();
            davesCar.registrationPlate = "AB01 2ZZ";
            davesCar.hasCruiseControl = true;
            davesCar.numberOfDoors = 3;

            Motorbike laurensBike = new Inheritance2.Motorbike();
            laurensBike.numberofPassengers = 2;
            laurensBike.lengthOfHandlebars = 70;
        }
    }
}
