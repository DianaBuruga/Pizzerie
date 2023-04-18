using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzerie
{
    public partial class OrderForm : Form
    {
        bool isFinished;
        public OrderForm(string pizza, string size, List<string> toppings)
        {
            InitializeComponent();
            order.Text += $"\nPizza:{pizza}\nSize: {size}\nToppings: ";
            foreach(string topping in toppings)
            {
                order.Text += topping + " "; 
            }
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            isFinished = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.PerformStep();
            if (progressBar.Value == progressBar.Maximum && isFinished == false)
            {
                isFinished = true;
                MessageBox.Show("Pizza is done!");
                Application.Exit();
            }
        }
    }
}
