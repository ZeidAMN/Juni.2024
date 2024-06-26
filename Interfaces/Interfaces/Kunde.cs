using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Kunde : IHuman
    {
        public string name { get; set; }
        public int alter { get; set; }
        public string kundenid;
        public void printData()
        {
            Console.WriteLine("Der name ist " + name + " Alter : " + alter + " ID : " + kundenid);

        }
        public Kunde(string _kundenid)
        {
            kundenid = _kundenid;
            

        }

        public Kunde(string _name, int _alter, string _kundenid)
        {
            name = _name;
            alter = _alter;
            kundenid = _kundenid;

        }
    }
}
