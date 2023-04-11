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
    public partial class Form1 : Form
    {
        public double PriceHD = 4.0;
        public double PriceFP = 3.5;
        public double PriceCC = 5.0;
        public double PriceHMB = 4.0;
        public List<Tuple<string, double>> FuelList = new List<Tuple<string, double>>();
        public double Total { get; set; }
        public Form1()
        {
            Total = 0;
            InitializeComponent();
            this.Text = "BestOil";
        }

        private void PetrolButton_Click(object sender, EventArgs e)
        {
            PetrolForm frm = new PetrolForm();
            frm.MainWindow = this;
            frm.ShowDialog();
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total price is: {Total}");
        }

        private void CafeButton_Click(object sender, EventArgs e)
        {
            CafeForm frm = new CafeForm(this);
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)//About strip menu
        {
            MessageBox.Show("BestOil\nv.0.1 beta");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)//Exit strip menu
        {
            this.Close();
        }
    }
}
