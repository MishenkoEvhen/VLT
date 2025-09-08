using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Читаем расстояние (L) и время (T) из текстбоксов
                double distance = double.Parse(textBox1.Text); // Відстань
                double time = double.Parse(textBox2.Text);     // Час

                // Проверка на деление на ноль
                if (time == 0)
                {
                    MessageBox.Show("Час не може бути 0!");
                    return;
                }

                // Формула V = L / T
                double speed = distance / time;

                // Выводим результат в textBox2
                textBox3.Text = speed.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть правильні числа!");
            }
        }
    }
}
