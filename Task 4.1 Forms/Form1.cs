using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4._1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static double Rec(double i, int n)
            {
                return i < n ? Math.Sqrt(i + Rec(++i, n)) : Math.Sqrt(i);
            }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            if (n > 0)
            {
                textBox2.Text += n / Rec(1, n);
            }
            else if (n < 0)
                textBox2.Text += "Ошибка: N меньше 0";
            else if (n == 0)
                textBox2.Text += "Ошибка: N = 0";
        }
    }
}
