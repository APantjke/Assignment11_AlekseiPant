using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment11_AlekseiPant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pet pet;
        private void enterDataBtn(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string type = comboBoxType.Text;
            decimal age = (decimal)0;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(type) && decimal.TryParse(textBoxAge.Text, out age))
            {
                pet = new Pet(name, type, age);
            }
            else
            {
                MessageBox.Show("Incorrect input!");
            }
        }

        private void displayDataBtn(object sender, EventArgs e)
        {
            if (pet != null)
            {
                listBox1.Items.Add("Pet's name: " + pet.Name);
                listBox1.Items.Add("Pet's type: " + pet.Type);
                listBox1.Items.Add("Pet's age: " + pet.Age);
                listBox1.Items.Add("");
            }
            else
            {
                MessageBox.Show("You need to enter pet's data first!");
            }
        }

        private void exitBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBoxName.Text = "";
            comboBoxType.Text = "";
            textBoxAge.Text = "";
        }
    }
}
