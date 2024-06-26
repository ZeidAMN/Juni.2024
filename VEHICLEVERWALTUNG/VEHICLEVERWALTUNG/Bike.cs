using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEHICLEVERWALTUNG
{
    internal class Bike : Vehicles
    {
        public bool has_sidecar;



        public Bike()
        {

        }

        public Bike(string _model, string _brand, int _year, bool _has_sidecar)
        {
            model = _model;
            brand = _brand; 
            year = _year;
            has_sidecar = _has_sidecar;
        }

        public override void description()
        {
            base.description();
            if (has_sidecar == true)
            {
                Console.WriteLine("Has a sidecar");
            }
            else if (has_sidecar == false)
            {
                Console.WriteLine("No sidecar");
            }
            else
            {
                Console.WriteLine("No information found about sidecar");
            }
            
        }
    }
}
