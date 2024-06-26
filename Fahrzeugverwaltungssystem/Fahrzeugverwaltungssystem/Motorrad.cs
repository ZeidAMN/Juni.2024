using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltungssystem
{
    internal class Motorrad : Fahrzeug
    {
        public bool hatBeiwagen;


        public Motorrad(string _marke, string _modell, int _baujahr, bool _hatBeiwagen)
        {
            marke = _marke;
            modell = _modell;
            baujahr = _baujahr;
            hatBeiwagen = _hatBeiwagen;
        }

        public Motorrad()
        {


        }

        public override void BeschreibeFahrzeug()
        {
            Console.WriteLine("Marke:" + marke + " Modell:" + modell + " Baujahr:" + baujahr + " Hat Beiwagen:" + hatBeiwagen + " Ja : Nein");
        }

        public bool get_hatBeiwagen()
        {
            return hatBeiwagen;

        }

        public void set_hatBeiwagen(bool _hatBeiwagen)
        {
            hatBeiwagen = _hatBeiwagen;

        }
    }
}
