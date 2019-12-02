using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTEO
{
    public partial class Form1 : Form
    {

        string[] kof = { "1", "2", "3", "4", "5" };
        double J1, J2, Ak = 0;

        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages[1].AutoScroll = true;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";

            comboBox2.SelectedItem = "1";
            comboBox3.SelectedItem = "1";
            comboBox4.SelectedItem = "1";
            comboBox5.SelectedItem = "1";
            comboBox6.SelectedItem = "1";
            comboBox7.SelectedItem = "1";
            comboBox8.SelectedItem = "1";
            comboBox9.SelectedItem = "1";
            comboBox10.SelectedItem = "1";
            comboBox11.SelectedItem = "1";
            comboBox12.SelectedItem = "1";
            comboBox13.SelectedItem = "1";
            comboBox14.SelectedItem = "1";
            comboBox15.SelectedItem = "1";
            comboBox16.SelectedItem = "1";
            comboBox17.SelectedItem = "1";
            comboBox18.SelectedItem = "1";
            comboBox19.SelectedItem = "1";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Sum = 0;

            if (textBox1.Text != String.Empty)
            {
                Sum += Convert.ToDouble(textBox1.Text);
                textBox18.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(comboBox2.Text)).ToString();
                textBox27.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(comboBox19.Text)).ToString();
                J1 += Convert.ToDouble(textBox1.Text) * Convert.ToDouble(comboBox2.Text);
                J2 += Convert.ToDouble(textBox1.Text) * Convert.ToDouble(comboBox19.Text);
            }
            else
            {
                MessageBox.Show("Введите коэффициет весомост в показатель №1");
            }

            if (textBox2.Text != String.Empty)
            {
                    Sum += Convert.ToDouble(textBox2.Text);
                    textBox17.Text = (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(comboBox3.Text)).ToString();
                    textBox26.Text = (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(comboBox18.Text)).ToString();
                    J1 += Convert.ToDouble(textBox2.Text) * Convert.ToDouble(comboBox3.Text);
                    J2 += Convert.ToDouble(textBox2.Text) * Convert.ToDouble(comboBox18.Text);
            }
            else
            {
                MessageBox.Show("Введите коэффициет весомост в показатель №2");
            }

            if (textBox3.Text != String.Empty)
            {
                Sum += Convert.ToDouble(textBox3.Text);
                textBox16.Text = (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(comboBox4.Text)).ToString();
                textBox25.Text = (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(comboBox17.Text)).ToString();
                J1 += Convert.ToDouble(textBox3.Text) * Convert.ToDouble(comboBox4.Text);
                J2 += Convert.ToDouble(textBox3.Text) * Convert.ToDouble(comboBox17.Text);
            }
            else
            {
                MessageBox.Show("Введите коэффициет весомост в показатель №3");
            }

            if (textBox4.Text != String.Empty)
            {
                Sum += Convert.ToDouble(textBox4.Text);
                textBox15.Text = (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(comboBox5.Text)).ToString();
                textBox24.Text = (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(comboBox16.Text)).ToString();
                J1 += Convert.ToDouble(textBox4.Text) * Convert.ToDouble(comboBox5.Text);
                J2 += Convert.ToDouble(textBox4.Text) * Convert.ToDouble(comboBox16.Text);
            }
            else
            {
                MessageBox.Show("Введите коэффициет весомост в показатель №4");
            }

            if (textBox5.Text != String.Empty)
            {
                Sum += Convert.ToDouble(textBox5.Text);
                textBox14.Text = (Convert.ToDouble(textBox5.Text) * Convert.ToDouble(comboBox6.Text)).ToString();
                textBox23.Text = (Convert.ToDouble(textBox5.Text) * Convert.ToDouble(comboBox15.Text)).ToString();
                J1 += Convert.ToDouble(textBox5.Text) * Convert.ToDouble(comboBox6.Text);
                J2 += Convert.ToDouble(textBox5.Text) * Convert.ToDouble(comboBox15.Text);
            }
            else
            {
                MessageBox.Show("Введите коэффициет весомост в показатель №5");
            }

            if (textBox6.Text != String.Empty)
            {
                Sum += Convert.ToDouble(textBox6.Text);
                textBox13.Text = (Convert.ToDouble(textBox6.Text) * Convert.ToDouble(comboBox7.Text)).ToString();
                textBox22.Text = (Convert.ToDouble(textBox6.Text) * Convert.ToDouble(comboBox14.Text)).ToString();
                J1 += Convert.ToDouble(textBox6.Text) * Convert.ToDouble(comboBox7.Text);
                J2 += Convert.ToDouble(textBox6.Text) * Convert.ToDouble(comboBox14.Text);
            }
            else
            {
                MessageBox.Show("Введите коэффициет весомост в показатель №6");
            }

            if (textBox7.Text != String.Empty)
            {
                Sum += Convert.ToDouble(textBox7.Text);
                textBox12.Text = (Convert.ToDouble(textBox7.Text) * Convert.ToDouble(comboBox8.Text)).ToString();
                textBox21.Text = (Convert.ToDouble(textBox7.Text) * Convert.ToDouble(comboBox13.Text)).ToString();
                J1 += Convert.ToDouble(textBox7.Text) * Convert.ToDouble(comboBox8.Text);
                J2 += Convert.ToDouble(textBox7.Text) * Convert.ToDouble(comboBox13.Text);
            }
            else
            {
                MessageBox.Show("Введите коэффициет весомост в показатель №6");
            }

            if (textBox8.Text != String.Empty)
            {
                Sum += Convert.ToDouble(textBox8.Text);
                textBox11.Text = (Convert.ToDouble(textBox8.Text) * Convert.ToDouble(comboBox9.Text)).ToString();
                textBox20.Text = (Convert.ToDouble(textBox8.Text) * Convert.ToDouble(comboBox12.Text)).ToString();
                J1 += Convert.ToDouble(textBox8.Text) * Convert.ToDouble(comboBox9.Text);
                J2 += Convert.ToDouble(textBox8.Text) * Convert.ToDouble(comboBox12.Text);
            }
            else
            {
                MessageBox.Show("Введите коэффициет весомост в показатель №6");
            }

            if (textBox9.Text != String.Empty)
            {
                Sum += Convert.ToDouble(textBox9.Text);
                textBox10.Text = (Convert.ToDouble(textBox9.Text) * Convert.ToDouble(comboBox10.Text)).ToString();
                textBox19.Text = (Convert.ToDouble(textBox9.Text) * Convert.ToDouble(comboBox11.Text)).ToString();
                J1 += Convert.ToDouble(textBox9.Text) * Convert.ToDouble(comboBox10.Text);
                J2 += Convert.ToDouble(textBox9.Text) * Convert.ToDouble(comboBox11.Text);
            }
            else
            {
                MessageBox.Show("Введите коэффициет весомост в показатель №6");
            }

            if (Sum > 1)
            {
                MessageBox.Show("Коэффициент весомости не может быть больше 1! Сейчас Коэффициент весомости = " + Sum);
                Sum = 0;
                label19.Text = "J1 = ? J2 = ?  Ak = ?";
            }
            //textBox10.Text = Sum.ToString(); проверка
            label18.Text = "Коэффициент весомости = " + Sum;
            Ak = 0;
            Ak = J1 / J2;
            label19.Text = "J1 = " + J1 + " J2 = " + J2 + " Ak = " + Ak;
            J1 = J2 = Ak = 0;
        }
    }
}

