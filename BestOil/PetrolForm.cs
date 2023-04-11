using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class PetrolForm : Form
    {
        public Form1 MainWindow;
        public double Total;

        public PetrolForm()
        {
            InitializeComponent();
        }

        private void FuelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedFuel = FuelComboBox.SelectedItem.ToString();
            var Price = from couple in MainWindow.FuelList where couple.Item1 == SelectedFuel select couple.Item2;
            this.PriceTextBox.Text = Price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//Accept
        {
            double value = Convert.ToDouble(this.ValueTextBox.Text);
            double total = value * Convert.ToDouble(this.PriceTextBox.Text);
            this.TotalTextBox.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)//Close
        {
            MainWindow.Total += Total;
        }
    }
}
