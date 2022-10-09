using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
         
        {
            string x = textBox1.Text;
            string y = textBox2.Text;
            int x_1 = Convert.ToInt32(x);
            int y_1 = Convert.ToInt32(y);
            int sum = x_1 + y_1;
            int mins = x_1 - y_1;  
            int pov = x_1 * y_1;
            int delik = x_1 / y_1;
            textBox3.Text = sum.ToString();
            textBox4.Text = mins.ToString();
            textBox5.Text = pov.ToString();
            textBox6.Text = delik.ToString();



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
