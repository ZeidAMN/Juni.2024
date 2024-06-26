using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VEHICLEVERWALTUNG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.Load += Form1_Load;
            list_box1.Dock = DockStyle.None;
        }

        private void vehicle_list_Click(object sender, EventArgs e)
        {
            {
                // Clear the list box before adding new items
                list_box1.Items.Clear();

                // Populate the list box with the list of vehicles
                foreach (var vehicle in Program.vehicles)
                {
                    list_box1.Items.Add(GetVehicleInfo(vehicle));
                    list_box1.Items.Add(string.Empty);
                }
            }
        }

        private string GetVehicleInfo(Vehicles vehicle)
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine((vehicle is Car ? "Car" : "Bike"));
            info.AppendLine(" | Model: " + vehicle.model);
            info.AppendLine(" | Brand: " + vehicle.brand);
            info.AppendLine(" | Year: " + vehicle.year);

            if (vehicle is Car)
            {
                var car = (Car)vehicle;
                info.AppendLine(" | Doors: " + car.doors);
            }
            else if (vehicle is Bike)
            {
                var bike = (Bike)vehicle;
                info.AppendLine(" | Has Sidecar: " + (bike.has_sidecar ? "Yes" : "No"));
            }


            info.AppendLine();
            info.AppendLine();

            return info.ToString();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            list_box1.Dock = DockStyle.None;
            list_box1.HorizontalScrollbar = true;


            
            cmb_type.Items.AddRange(new string[] { "Car", "Bike" });
            cmb_type.SelectedIndex = 0; 

            // Show/hide fields based on vehicle type selection ??????????????????
            cmb_type.SelectedIndexChanged += (s, ev) =>
            {
                bool isCar = cmb_type.SelectedItem.ToString() == "Car";
                doors_txt.Visible = isCar;
                sidecar_check.Visible = !isCar;
            };

        }



        private void add_vehicle_Click(object sender, EventArgs e)
        {
            string model = model_txt.Text;
            string brand = brand_txt.Text;
            int year = int.Parse(year_txt.Text);
            string vehicleType = cmb_type.SelectedItem.ToString();

            if (vehicleType == "Car")
            {
                int doors = int.Parse(doors_txt.Text);
                Program.vehicles.Add(new Car(model, brand, year, doors));
            }
            else if (vehicleType == "Bike")
            {
                bool hasSidecar = sidecar_check.Checked;
                Program.vehicles.Add(new Bike(model, brand, year, hasSidecar));
            }

            // Optionally, clear the input fields after adding the vehicle
            model_txt.Clear();
            brand_txt.Clear();
            year_txt.Clear();
            doors_txt.Clear();
            sidecar_check.Checked = false;

            // Refresh the ListBox or other control displaying the vehicle list
            RefreshVehicleList();
        }

        private void RefreshVehicleList()
        {
            list_box1.Items.Clear();

            foreach (var vehicle in Program.vehicles)
            {
                list_box1.Items.Add(GetVehicleInfo(vehicle));
                list_box1.Items.Add(string.Empty);
            }
        }


        private void remove_vehicle_Click(object sender, EventArgs e)
        {
            string modelToRemove = remove_vehicle_txt.Text;

            if (!string.IsNullOrEmpty(modelToRemove))
            {
                VehicleManagement.RemoveVehicle(Program.vehicles, modelToRemove);
                RefreshVehicleList();
            }
            else
            {
                MessageBox.Show("Please enter a model name to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
