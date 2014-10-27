using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class VehicleUI : Form
    {
        Vehicle aVehicle = new Vehicle();
        private double min=0;
        private double max = 0;
        private double average;
        public VehicleUI()
        {
            InitializeComponent();
        }
        
        private void showButton_Click(object sender, EventArgs e)
        {

            minSpeedTextBox.Text=min.ToString();
            maxSpeedTextBox.Text=max.ToString();
            averageTextBox.Text = average.ToString();


        }

        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicle.Name = vehicleNameTextBox.Text;
            aVehicle.RegNo = regNoTextBox.Text;

            MessageBox.Show("Account Created");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
             aVehicle.Speed = Convert.ToDouble(speedTextBox.Text);
            min= aVehicle.GetMinSpeed();
            max = aVehicle.GetMaxSpeed();
            average = aVehicle.GetAverage();
            
            speedTextBox.Text = "";
        }
    }
}
