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
    public partial class PizzaForm : Form
    {
        public PizzaForm()
        {
            InitializeComponent();
        }
        private string GetSelection(GroupBox groupBox)
        {
            foreach (RadioButton radioButton in groupBox.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return null;
        }
        private List<string> GetToppings()
        {
            List<string> topping = new List<string>();
            foreach (CheckBox checkBox in toppingsGroupBox.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    topping.Add(checkBox.Text);
                }
            }
            return topping;
        }

        private void PizzaForm_Load(object sender, EventArgs e)
        {

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            string pizza = GetSelection(pizzaGroupBox);
            string size = GetSelection(sizeGroupBox);
            List<string> toppingsList = GetToppings();

            if (string.IsNullOrEmpty(pizza) || string.IsNullOrEmpty(size))
            {
                MessageBox.Show("Your order is incomplete!");
            }
            else
            {
                this.Hide();
                OrderForm finish = new OrderForm(pizza, size, toppingsList);
                finish.Show();
            }
        }
    }
}
