using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IHuman
    {
        // Interface ist eine grob vorlage.. alle Attribute und methoden müssen dann in der abgeleiteten Klasse(n)
        // implementiert werden.
        public string name { get; set; }        // attribute name und automatisch mit einem getter setter..
        public int alter { get; set; }
        public void printData();      // in der abgeleiteten Klasse muss die methode printData ausimplementiert werden


    }
}
