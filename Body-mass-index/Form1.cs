using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_mass_index
{
    public partial class Form1 : Form
    {
        double height;
        double weight;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           weight = Int32.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            height = Int32.Parse(textBox2.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = (weight/2.205)/((height / 39.37)* (height / 39.37));
            label5.Text =  "BMI: "+ result.ToString("n2");
            if (18.5 < result && result < 25)
            {
                label6.Text = "Status: " +  "normal";
            }
            else if (result < 18.5)
            {
                label6.Text = "Status: " +  "underweight";
            }
            else {
                label6.Text = "Status: " + "overweight";
            }
        }
    }
}
