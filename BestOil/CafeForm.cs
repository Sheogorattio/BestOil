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
    public partial class CafeForm : Form
    {
        public Form1 MainWindow;
        public double Total=0;

        public CafeForm(Form1 MainWindow)
        {
            InitializeComponent();
            this.MainWindow = MainWindow;
            this.PriceCocaCola.Text = MainWindow.PriceCC.ToString();
            this.PriceFreePotatoes.Text = MainWindow.PriceFP.ToString();
            this.PriceHamburger.Text = MainWindow.PriceHMB.ToString();
            this.PriceHotDog.Text = MainWindow.PriceHD.ToString();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            if(this.CheckHotDog.Checked)
            {
                Total += MainWindow.PriceHD * Convert.ToInt32(this.QuantHotDog.Text);
            }
            if(this.CheckCocaCola.Checked)
            {
                Total += MainWindow.PriceCC * Convert.ToInt32(this.QuantCocaCola);
            }
            if(this.CheckFreePotatoes.Checked)
            {
                Total += MainWindow.PriceFP * Convert.ToInt32(this.QuantFreePotatoes);
            }
            if(this.CheckHamburger.Checked)
            {
                Total += MainWindow.PriceHMB * Convert.ToInt32(this.QuantHamburger);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MainWindow.Total += Total;
        }
    }
}
