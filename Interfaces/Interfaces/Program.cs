using System;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter m1 = new Mitarbeiter("Florent",21,"M001k");
            m1.printData();

            Kunde k1 = new Kunde("K001");
            Console.WriteLine("Wie heißt du?");
            k1.name = Console.ReadLine();
            Console.WriteLine("Wie alt bist du?");
            k1.alter = Convert.ToInt32(Console.ReadLine());
            k1.printData();

            Kunde k2 = new Kunde("Max Mustermann", 30 ,"K002");
            k2.printData();

            Console.ReadLine();
        }
    }
}