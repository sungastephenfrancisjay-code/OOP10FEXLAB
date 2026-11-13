using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConProj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listBox1.Items.Add(comboBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select from the menu.");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                string orderSummary = "You ordered:\n\n";
                foreach (var item in listBox1.Items)
                {
                    orderSummary += "- " + item.ToString() + "\n";
                }
                MessageBox.Show(orderSummary, "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 queueMonitor = new Form2();
                queueMonitor.Show();

                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Your order list is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex != -1)
            {
                
                listBox1.Items.Remove(listBox1.SelectedItem);

                
            }
            else
            {
                MessageBox.Show("Please select an order to cancel.");
            }
        }
    }
}
