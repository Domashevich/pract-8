using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char a = textBox1.Text[0];
            int b = textBox2.Text.Length - 1;
            char s = textBox2.Text[b];
            if(s==a)
            {
                label1.Text = ("Верно");
            }
            else 
            {
                label1.Text = ("неверно");
            }
        }
    }
}
