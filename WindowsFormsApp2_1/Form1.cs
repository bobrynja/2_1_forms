using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                if ((y < 12) && (y > Math.Abs(x))) textBox3.Text = "Да";
                else if ((y > 12) || (y < Math.Abs(x))) textBox3.Text = "Нет";
                else textBox3.Text = "На границе";
            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных");
            }
        }
    }
}
