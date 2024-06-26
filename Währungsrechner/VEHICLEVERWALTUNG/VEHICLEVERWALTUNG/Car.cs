using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEHICLEVERWALTUNG
{
    internal class Car : Vehicles
    {
        public int doors;



        public Car() 
        {

        }

        public Car(string _model, string _brand, int _year, int _doors)
        {
            model = _model;
            brand = _brand;
            year = _year;
            doors = _doors;
        }

        public override void description()
        {
            base.description();
            Console.WriteLine("This car has " + doors + " doors");
        }
    }

}
