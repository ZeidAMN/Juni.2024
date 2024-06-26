using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEHICLEVERWALTUNG
{
    public class Vehicles
    {

        public string model;
        public string brand;
        public int year;
        private int id;


        public Vehicles()
        {
            
        }

        public Vehicles(string _model, string _brand, int _year)
        {
            model = _model;
            brand = _brand;
            year = _year;
        }

        public virtual void description()
        {
            Console.WriteLine("MODEL: " + model);
            Console.WriteLine("BRAND: " + brand);
            Console.WriteLine("Built in year: " + year);
        }

       





    }

    
}
