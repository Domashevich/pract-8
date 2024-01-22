using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp62
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                char v = char.ToLower(textBox1.Text[i]);
                if (v == 'а' || v == 'е' || v == 'ё' || v == 'и' || v == 'о' || v == 'у' || v == 'ы' || v == 'э' || v == 'ю' || v == 'я')
                {
                    a++;
                }
            }

            int t = textBox1.Text.Length;
            double d = (double)a / t * 100.0; // Исправленная формула расчета процента
            label2.Text = d.ToString() + "%";
        }
    }
}
    

