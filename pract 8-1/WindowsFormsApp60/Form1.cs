using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a =textBox1.Text.Length;
            int b =textBox2.Text.Length;
            if(a > b)
            {
                label4.Text = ("Первая фамилия больше");

            }
            else if(a < b)
            {
                label4.Text = ("Вторая  фамилия больше");
            }
            else
            {
                label4.Text = ("обе фамилии равны");
            }
        }
    }
}
