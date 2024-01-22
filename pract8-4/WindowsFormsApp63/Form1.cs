using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp63
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            char[] arr = s.ToCharArray();
            int len=arr.Length;
            for(int i=0; i<len/2; i++)
            {
                (arr[i], arr[len - i - 1]) = (arr [len - i - 1], arr[i]);

            }
            textBox2.Text=new string(arr);
        }
    }
}
