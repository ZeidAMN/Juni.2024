using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltungssystem
{
    internal class Fahrzeug
    {
        public string marke;
        public string modell;
        public int baujahr;

        public Fahrzeug()
        {


        }

        public Fahrzeug(string _marke, string _modell, int _baujahr)
        {
            marke = _marke;
            modell = _modell;
            baujahr = _baujahr;
        }

        public virtual void BeschreibeFahrzeug()
        {
            Console.WriteLine("Marke:" + marke + " Modell:" + modell +  "Baujahr:" + baujahr);
        }

        public string get_marke()
        {
            return marke;

        }

        public void set_marke(string _marke)
        {
            marke = _marke;

        }

        public string get_modell()
        {
            return modell;

        }

        public void set_model(string _modell)
        {
            modell = _modell;

        }

        public int get_baujahr()
        {
            return baujahr;

        }

        public void set_baujahr(int _baujahr)
        {
            baujahr = _baujahr;

        }
    }
}

