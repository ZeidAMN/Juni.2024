using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Mitarbeiter : IHuman
    {
        public string name { get; set; }
        public int alter { get; set; }
        public string mitarbeiterid { get; set; }
        public void printData()
        {
            Console.WriteLine("Der name ist " + name + " Alter : " + alter + " ID : " + mitarbeiterid);

        
        }

        public Mitarbeiter(string _name, int _alter, string _mitarbeiterid)
        {
            name = _name;
            alter = _alter;
            mitarbeiterid = _mitarbeiterid;

        }

    }
}
