namespace VEHICLEVERWALTUNG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            vehicle_list = new System.Windows.Forms.Button();
            add_vehicle = new System.Windows.Forms.Button();
            remove_vehicle = new System.Windows.Forms.Button();
            exit_button = new System.Windows.Forms.Button();
            list_box1 = new System.Windows.Forms.ListBox();
            doors_txt = new System.Windows.Forms.TextBox();
            year_txt = new System.Windows.Forms.TextBox();
            brand_txt = new System.Windows.Forms.TextBox();
            model_txt = new System.Windows.Forms.TextBox();
            sidecar_check = new System.Windows.Forms.CheckBox();
            cmb_type = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            remove_vehicle_txt = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // vehicle_list
            // 
            vehicle_list.Location = new System.Drawing.Point(12, 12);
            vehicle_list.Name = "vehicle_list";
            vehicle_list.Size = new System.Drawing.Size(100, 100);
            vehicle_list.TabIndex = 0;
            vehicle_list.Text = "Vehicle List";
            vehicle_list.UseVisualStyleBackColor = true;
            vehicle_list.Click += vehicle_list_Click;
            // 
            // add_vehicle
            // 
            add_vehicle.Location = new System.Drawing.Point(1078, 318);
            add_vehicle.Name = "add_vehicle";
            add_vehicle.Size = new System.Drawing.Size(100, 100);
            add_vehicle.TabIndex = 1;
            add_vehicle.Text = "ADD Vehicle";
            add_vehicle.UseVisualStyleBackColor = true;
            add_vehicle.Click += add_vehicle_Click;
            // 
            // remove_vehicle
            // 
            remove_vehicle.Location = new System.Drawing.Point(542, 423);
            remove_vehicle.Name = "remove_vehicle";
            remove_vehicle.Size = new System.Drawing.Size(100, 100);
            remove_vehicle.TabIndex = 2;
            remove_vehicle.Text = "REMOVE Vehicle";
            remove_vehicle.UseVisualStyleBackColor = true;
            remove_vehicle.Click += remove_vehicle_Click;
            // 
            // exit_button
            // 
            exit_button.Location = new System.Drawing.Point(12, 423);
            exit_button.Name = "exit_button";
            exit_button.Size = new System.Drawing.Size(100, 100);
            exit_button.TabIndex = 4;
            exit_button.Text = "EXIT";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // list_box1
            // 
            list_box1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            list_box1.FormattingEnabled = true;
            list_box1.ItemHeight = 23;
            list_box1.Location = new System.Drawing.Point(118, 12);
            list_box1.Name = "list_box1";
            list_box1.Size = new System.Drawing.Size(1060, 303);
            list_box1.TabIndex = 5;
            // 
            // doors_txt
            // 
            doors_txt.Location = new System.Drawing.Point(549, 356);
            doors_txt.Name = "doors_txt";
            doors_txt.Size = new System.Drawing.Size(100, 23);
            doors_txt.TabIndex = 6;
            // 
            // year_txt
            // 
            year_txt.Location = new System.Drawing.Point(442, 356);
            year_txt.Name = "year_txt";
            year_txt.Size = new System.Drawing.Size(100, 23);
            year_txt.TabIndex = 7;
            // 
            // brand_txt
            // 
            brand_txt.Location = new System.Drawing.Point(336, 356);
            brand_txt.Name = "brand_txt";
            brand_txt.Size = new System.Drawing.Size(100, 23);
            brand_txt.TabIndex = 8;
            // 
            // model_txt
            // 
            model_txt.Location = new System.Drawing.Point(230, 356);
            model_txt.Name = "model_txt";
            model_txt.Size = new System.Drawing.Size(100, 23);
            model_txt.TabIndex = 9;
            // 
            // sidecar_check
            // 
            sidecar_check.AutoSize = true;
            sidecar_check.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            sidecar_check.Location = new System.Drawing.Point(655, 358);
            sidecar_check.Name = "sidecar_check";
            sidecar_check.Size = new System.Drawing.Size(189, 21);
            sidecar_check.TabIndex = 10;
            sidecar_check.Text = "tick for sidecar (Bike only)";
            sidecar_check.UseVisualStyleBackColor = true;
            // 
            // cmb_type
            // 
            cmb_type.FormattingEnabled = true;
            cmb_type.Location = new System.Drawing.Point(124, 356);
            cmb_type.Name = "cmb_type";
            cmb_type.Size = new System.Drawing.Size(100, 23);
            cmb_type.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(554, 338);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 15);
            label2.TabIndex = 13;
            label2.Text = "Doors (Car only)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(442, 338);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 15);
            label3.TabIndex = 14;
            label3.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(336, 338);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 15);
            label4.TabIndex = 15;
            label4.Text = "Brand";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(230, 338);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(42, 15);
            label5.TabIndex = 16;
            label5.Text = "Model";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(124, 338);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(68, 15);
            label6.TabIndex = 17;
            label6.Text = "Car or Bike";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(890, 338);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(182, 75);
            label1.TabIndex = 18;
            label1.Text = "IF you click this BUTTON >>>>>\r\nWITHOUT filling out the \r\n<<<<boxes to the left\r\nyou will die in real life\r\n\r\n";
            // 
            // remove_vehicle_txt
            // 
            remove_vehicle_txt.Location = new System.Drawing.Point(436, 463);
            remove_vehicle_txt.Name = "remove_vehicle_txt";
            remove_vehicle_txt.Size = new System.Drawing.Size(100, 23);
            remove_vehicle_txt.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(442, 430);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(94, 30);
            label7.TabIndex = 20;
            label7.Text = "Enter MODEL to\r\nremove from list";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1190, 535);
            Controls.Add(label7);
            Controls.Add(remove_vehicle_txt);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmb_type);
            Controls.Add(sidecar_check);
            Controls.Add(model_txt);
            Controls.Add(brand_txt);
            Controls.Add(year_txt);
            Controls.Add(doors_txt);
            Controls.Add(list_box1);
            Controls.Add(exit_button);
            Controls.Add(remove_vehicle);
            Controls.Add(add_vehicle);
            Controls.Add(vehicle_list);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button vehicle_list;
        private System.Windows.Forms.Button add_vehicle;
        private System.Windows.Forms.Button remove_vehicle;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.ListBox list_box1;
        private System.Windows.Forms.TextBox doors_txt;
        private System.Windows.Forms.TextBox year_txt;
        private System.Windows.Forms.TextBox brand_txt;
        private System.Windows.Forms.TextBox model_txt;
        private System.Windows.Forms.CheckBox sidecar_check;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox remove_vehicle_txt;
        private System.Windows.Forms.Label label7;
    }
}
