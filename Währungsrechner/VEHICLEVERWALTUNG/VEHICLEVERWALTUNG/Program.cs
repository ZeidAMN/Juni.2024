using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VEHICLEVERWALTUNG
{
    internal static class Program
    {
        public static List<Vehicles> vehicles = new List<Vehicles>();

        [STAThread]
        static void Main()
        {
            vehicles.Add(new Car("Model S", "Tesla", 2020, 4));
            vehicles.Add(new Car("Civic", "Honda", 2018, 4));
            vehicles.Add(new Car("Mustang", "Ford", 2019, 2));
            vehicles.Add(new Car("Camry", "Toyota", 2021, 4));
            vehicles.Add(new Car("A4", "Audi", 2022, 4));

            vehicles.Add(new Bike("Sportster", "Harley-Davidson", 2019, true));
            vehicles.Add(new Bike("Ninja", "Kawasaki", 2020, false));
            vehicles.Add(new Bike("Gold Wing", "Honda", 2018, true));
            vehicles.Add(new Bike("Ducati Monster", "Ducati", 2021, false));
            vehicles.Add(new Bike("GSX-R1000", "Suzuki", 2022, false));
            //
            //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
            //
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //
            //
            //
            

            








        }
    }
}
