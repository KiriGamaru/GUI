using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI : Form
    {
        private void tb_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        public GUI()
        {
            InitializeComponent();
            // считывем значения из настроек
            labelZ1.Text = Properties.Settings.Default.massage.ToString();
            labelZ2a.Text = Properties.Settings.Default.massageA.ToString();
            labelZ2b.Text = Properties.Settings.Default.massageB.ToString();
            textBoxA.Text = Properties.Settings.Default.a.ToString();
            textBoxB.Text = Properties.Settings.Default.b.ToString();
            textBoxC.Text = Properties.Settings.Default.c.ToString();
            textBoxD.Text = Properties.Settings.Default.d.ToString();
            textBoxN.Text = Properties.Settings.Default.n.ToString();
            textBoxM.Text = Properties.Settings.Default.m.ToString();
            textBox1.Text = Properties.Settings.Default.tx1.ToString();
            textBox2.Text = Properties.Settings.Default.tx2.ToString();
            textBox3.Text = Properties.Settings.Default.tx3.ToString();

            textBoxA.KeyUp += tb_KeyUp;
            textBoxB.KeyUp += tb_KeyUp;
            textBoxC.KeyUp += tb_KeyUp;
            textBoxD.KeyUp += tb_KeyUp;
            textBoxM.KeyUp += tb_KeyUp;
            textBoxN.KeyUp += tb_KeyUp;
            textBox1.KeyUp += tb_KeyUp;
            textBox2.KeyUp += tb_KeyUp;
            textBox3.KeyUp += tb_KeyUp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d, n, m;
            try
            {
                a = int.Parse(this.textBoxA.Text);
                b = int.Parse(this.textBoxB.Text);
                c = int.Parse(this.textBoxC.Text);
                d = int.Parse(this.textBoxD.Text);
                n = int.Parse(this.textBoxN.Text);
                m = int.Parse(this.textBoxM.Text);
                Properties.Settings.Default.a = a;
                Properties.Settings.Default.b = b;
                Properties.Settings.Default.c = c;
                Properties.Settings.Default.d = d;
                Properties.Settings.Default.n = n;
                Properties.Settings.Default.m = m;
                Properties.Settings.Default.Save(); // сохраняем значение
            }
            catch (FormatException)
            {
                return;
            }
                labelZ1.Text = Logic1.Answer(a, b, c, d, n, m);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                Properties.Settings.Default.tx1 = a;
                Properties.Settings.Default.tx2 = b;
                Properties.Settings.Default.Save(); // сохраняем значение
            }
            catch (FormatException)
            {
                return;
            }
            labelZ2a.Text = Logic2a.AnA(a, b);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            int a, c;
            try
            {
                a = int.Parse(this.textBox1.Text);
                c = int.Parse(this.textBox3.Text);
                Properties.Settings.Default.tx1 = a;
                Properties.Settings.Default.tx3 = c;
                Properties.Settings.Default.Save(); // сохраняем значение
            }
            catch (FormatException)
            {
                return;
            }
            labelZ2b.Text = Logic2b.AnB(a, c);
        }

        public class Logic1 // класс логики первой задачи
        {
            public static string Answer(int a, int b, int c, int d, int n, int m)
            {
                string massage = "поезд НЕ стоял на платформе, когда на неё пришёл пассажир";

                
                if (n == a || n == c)
                {
                    if (m >= b && m <= d)
                    {
                        massage = "поезд стоял на платформе, когда на неё пришёл пассажир";
                    }
                }
                else
                {
                    if (n > a && n < c)
                    {
                        massage = "поезд стоял на платформе, когда на неё пришёл пассажир";
                    }
                    else
                    {
                        massage = "поезд НЕ стоял на платформе, когда на неё пришёл пассажир";
                    }
                }
                if (a <= 0 || a > 23 || b <= 0 || b > 59 || c <= 0 || c > 23 || d <= 0 || d > 59 || n <= 0 || n > 23 || m <= 0 || m > 59)
                {
                    massage = "введённые данные не удовлетворяют условию задачи";

                }
                //  передаем значение в параметры
                Properties.Settings.Default.massage = massage;
                Properties.Settings.Default.Save(); // сохраняем значение
                return massage;
            }
        }
        
        public class Logic2a //класс логики второй задачи a)
        {
            public static string AnA (int a, int b)
            {
                int k1 = 0;
                double i = a, m = 0;
                while (m <= b)
                {
                    m = i / 100 * 2;
                    i = i * 1.02;
                    k1++;
                }
                string massageA = $"величина ежемесячного увеличения вклада превысит {b} руб. за {k1} месяца(ев)";
                //  передаем значение в параметры
                Properties.Settings.Default.massageA = massageA;
                Properties.Settings.Default.Save(); // сохраняем значение
                return massageA;
            }
        }
        public class Logic2b //класс логики второй задачи b)
        {
            public static string AnB(int a, int c)
            {
                int k2 = 0;
                double j = a;
                while (j <= c)
                {
                    j = j * 1.02;
                    k2++;
                }
                string massageB = $"размер вклада превысит {c} руб. за {k2} месяца(ев)";
                //  передаем значение в параметры
                Properties.Settings.Default.massageB = massageB;
                Properties.Settings.Default.Save(); // сохраняем значение
                return massageB;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";
            textBoxD.Text = "";
            textBoxM.Text = "";
            textBoxN.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            labelZ1.Text = "";
            labelZ2a.Text = "";
            labelZ2b.Text = "";
            Properties.Settings.Default.a = 0;
            Properties.Settings.Default.b = 0;
            Properties.Settings.Default.c = 0;
            Properties.Settings.Default.d = 0;
            Properties.Settings.Default.n = 0;
            Properties.Settings.Default.m = 0;
            Properties.Settings.Default.tx1 = 0;
            Properties.Settings.Default.tx2 = 0;
            Properties.Settings.Default.tx3 = 0;
            Properties.Settings.Default.massage = "";
            Properties.Settings.Default.massageA = "";
            Properties.Settings.Default.massageB = "";
            Properties.Settings.Default.Save(); // сохраняем значение
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
