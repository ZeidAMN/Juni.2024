using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VEHICLEVERWALTUNG
{
    public static class VehicleManagement
    {

        public static void show_description(Vehicles vehicle)
        {
            vehicle.description();
        }

        public static void print_list(List<Vehicles> vehicles)
        {
            StringBuilder text = new StringBuilder();

            foreach (var vehicle in vehicles)
            {
                text.AppendLine("Type: " + (vehicle is Car ? "Car" : "Bike"));
                text.AppendLine("Model: " + vehicle.model);
                text.AppendLine("Brand: " + vehicle.brand);
                text.AppendLine("Year: " + vehicle.year);

                if (vehicle is Car)
                {
                    var car = (Car)vehicle;
                    text.AppendLine("Doors: " + car.doors);
                    
                }
                else if (vehicle is Bike)
                {
                    var bike = (Bike)vehicle;
                    text.AppendLine("Has Sidecar: " + (bike.has_sidecar ? "Yes" : "No"));
                    

                }
            }

            Console.WriteLine("Message content: " + text.ToString());

            MessageBox.Show(text.ToString(), "Vehicle List", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static void add_vehicle(List<Vehicles> vehicles)
        {
            Console.WriteLine("Do you want to add a Car or a Bike? (Car/Bike)");
            string choice = Console.ReadLine().ToUpper();

            Console.Write("Enter Model: ");
            string model = Console.ReadLine();

            Console.Write("Enter Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());

            if (choice == "C")
            {
                Console.Write("Enter Number of Doors: ");
                int doors = int.Parse(Console.ReadLine());

                vehicles.Add(new Car(model, brand, year, doors));
            }
            else if (choice == "B")
            {
                Console.Write("Has Sidecar? (yes/no): ");
                string hasSidecarInput = Console.ReadLine().ToLower();
                bool hasSidecar = hasSidecarInput == "yes";

                vehicles.Add(new Bike(model, brand, year, hasSidecar));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter CAR or BIKE.");
            }


        }

        public static void RemoveVehicle(List<Vehicles> vehicleList, string model)
        {
            bool vehicle_found = false;

            for (int i = 0; i < vehicleList.Count; i++)
            {
                if (vehicleList[i].model == model)
                {
                    vehicleList.RemoveAt(i);
                    vehicle_found = true;
                    MessageBox.Show("Vehicle: " + model + " Removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            if (!vehicle_found)
            {
                MessageBox.Show("Vehicle not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


}

