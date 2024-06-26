using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltungssystem
{
    internal class Auto : Fahrzeug
    {
        public int anzahlTueren;


        public Auto()
        {


        }

        public Auto(string _marke, string _modell, int _baujahr, int _anzahlTueren)
        {
            marke = _marke;
            modell = _modell;
            baujahr = _baujahr;
            anzahlTueren = _anzahlTueren;
        }

        public override void BeschreibeFahrzeug()
        {
            Console.WriteLine("Marke:" + marke + " Modell:" + modell + "Baujahr:" + baujahr + "anzahl der Türen:" + anzahlTueren);
        }
    }
}
