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
        DateTime dt1 = new DateTime();//руководитель
        DateTime dt2 = new DateTime();//программист
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

            textBox28.Text = "0";
            textBox29.Text = "0";
            textBox39.Text = "0";
            textBox38.Text = "0";
            textBox51.Text = "0";
            textBox50.Text = "0";
            textBox45.Text = "0";
            textBox44.Text = "0";
            textBox75.Text = "0";
            textBox74.Text = "0";
            textBox63.Text = "0";
            textBox62.Text = "0";
            textBox69.Text = "0";
            textBox68.Text = "0";
            textBox57.Text = "0";
            textBox56.Text = "0";
            textBox87.Text = "0";
            textBox86.Text = "0";
            textBox81.Text = "0";
            textBox80.Text = "0";
            textBox99.Text = "0";
            textBox98.Text = "0";
            textBox93.Text = "0";
            textBox92.Text = "0";
            textBox105.Text = "0";
            textBox104.Text = "0";
            textBox111.Text = "0";
            textBox110.Text = "0";
            textBox129.Text = "0";
            textBox128.Text = "0";
            textBox123.Text = "0";
            textBox122.Text = "0";
            textBox117.Text = "0";
            textBox116.Text = "0";
           
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

        private void button2_Click(object sender, EventArgs e)
        {

            dt1 = dateTimePicker1.Value;
            dt2 = dateTimePicker1.Value;


            if (textBox29.Text.Equals("0")){
                dt2 = dt1;
                textBox30.Text = dt1.ToShortDateString();
                textBox31.Text = dt1.ToShortDateString();
                textBox33.Text = "---";
                textBox32.Text = "---";

            }else
            {
                textBox30.Text = dt1.ToShortDateString();
                textBox33.Text = dt2.ToShortDateString();


                dt1 = dt1.AddDays(Convert.ToDouble(textBox28.Text));
                dt2 = dt2.AddDays(Convert.ToDouble(textBox29.Text));

                textBox31.Text = dt1.ToShortDateString();
                textBox32.Text = dt2.ToShortDateString();
            }

            dt1 = dt1.AddDays(1);
            dt2 = dt2.AddDays(1);
            if (dt1 > dt2)
            {
                dt2 = dt1;
            }
            else
            {
                dt1 = dt2;
            }


            if (textBox39.Text.Equals("0") && textBox38.Text.Equals("0"))
            {
                textBox37.Text = "---";
                textBox36.Text = "---";
                textBox35.Text = "---";
                textBox34.Text = "---";
            }
            else if (textBox39.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox37.Text = "---";
                textBox36.Text = "---";
                textBox35.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox38.Text));
                textBox34.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox38.Text.Equals("0")) {
                dt1 = dt2;
                textBox35.Text = "---";
                textBox34.Text = "---";
                textBox37.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox39.Text));//начальная дата + дни
                textBox36.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox37.Text = dt1.ToShortDateString(); //начальная дата
                textBox35.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox39.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox38.Text));


                textBox36.Text = dt1.ToShortDateString();//конечная дата
                textBox34.Text = dt2.ToShortDateString();
                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
           

            if (textBox51.Text.Equals("0") && textBox50.Text.Equals("0"))
            {
                textBox49.Text = "---";
                textBox48.Text = "---";
                textBox47.Text = "---";
                textBox46.Text = "---";
            }
            else if (textBox51.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox49.Text = "---";
                textBox48.Text = "---";
                textBox47.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox50.Text));
                textBox46.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }else if (textBox50.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox47.Text = "---";
                textBox46.Text = "---";
                textBox49.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox51.Text));//начальная дата + дни
                textBox48.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox49.Text = dt1.ToShortDateString(); //начальная дата
                textBox47.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox51.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox50.Text));


                textBox48.Text = dt1.ToShortDateString();//конечная дата
                textBox46.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }


            if (textBox45.Text.Equals("0") && textBox44.Text.Equals("0"))
            {
                textBox43.Text = "---";
                textBox42.Text = "---";
                textBox41.Text = "---";
                textBox40.Text = "---";
            }
            else if (textBox45.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox43.Text = "---";
                textBox42.Text = "---";
                textBox41.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox44.Text));
                textBox40.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox44.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox41.Text = "---";
                textBox40.Text = "---";
                textBox43.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox45.Text));//начальная дата + дни
                textBox42.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox43.Text = dt1.ToShortDateString(); //начальная дата
                textBox41.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox45.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox44.Text));


                textBox42.Text = dt1.ToShortDateString();//конечная дата
                textBox40.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }

            if (textBox75.Text.Equals("0") && textBox74.Text.Equals("0"))
            {
                textBox73.Text = "---";
                textBox72.Text = "---";
                textBox71.Text = "---";
                textBox70.Text = "---";
            }
            else if (textBox75.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox73.Text = "---";
                textBox72.Text = "---";
                textBox71.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox74.Text));
                textBox70.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox74.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox71.Text = "---";
                textBox70.Text = "---";
                textBox73.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox75.Text));//начальная дата + дни
                textBox72.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox73.Text = dt1.ToShortDateString(); //начальная дата
                textBox71.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox75.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox74.Text));


                textBox72.Text = dt1.ToShortDateString();//конечная дата
                textBox70.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }

            if (textBox63.Text.Equals("0") && textBox62.Text.Equals("0"))
            {
                textBox61.Text = "---";
                textBox60.Text = "---";
                textBox59.Text = "---";
                textBox58.Text = "---";
            }
            else if (textBox63.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox61.Text = "---";
                textBox60.Text = "---";
                textBox59.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox62.Text));
                textBox58.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox62.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox59.Text = "---";
                textBox58.Text = "---";
                textBox61.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox63.Text));//начальная дата + дни
                textBox60.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox61.Text = dt1.ToShortDateString(); //начальная дата
                textBox59.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox63.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox62.Text));


                textBox60.Text = dt1.ToShortDateString();//конечная дата
                textBox58.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }

            if (textBox69.Text.Equals("0") && textBox68.Text.Equals("0"))
            {
                textBox67.Text = "---";
                textBox66.Text = "---";
                textBox65.Text = "---";
                textBox64.Text = "---";
            }
            else if (textBox69.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox67.Text = "---";
                textBox66.Text = "---";
                textBox65.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox68.Text));
                textBox64.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox68.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox65.Text = "---";
                textBox64.Text = "---";
                textBox67.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox69.Text));//начальная дата + дни
                textBox66.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox67.Text = dt1.ToShortDateString(); //начальная дата
                textBox65.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox69.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox68.Text));


                textBox66.Text = dt1.ToShortDateString();//конечная дата
                textBox64.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }

            if (textBox57.Text.Equals("0") && textBox56.Text.Equals("0"))
            {
                textBox55.Text = "---";
                textBox54.Text = "---";
                textBox53.Text = "---";
                textBox52.Text = "---";
            }
            else if (textBox57.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox55.Text = "---";
                textBox54.Text = "---";
                textBox53.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox56.Text));
                textBox52.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox56.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox53.Text = "---";
                textBox52.Text = "---";
                textBox55.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox57.Text));//начальная дата + дни
                textBox54.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox55.Text = dt1.ToShortDateString(); //начальная дата
                textBox53.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox57.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox56.Text));


                textBox54.Text = dt1.ToShortDateString();//конечная дата
                textBox52.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }

            if (textBox87.Text.Equals("0") && textBox86.Text.Equals("0"))
            {
                textBox85.Text = "---";
                textBox84.Text = "---";
                textBox83.Text = "---";
                textBox82.Text = "---";
            }
            else if (textBox87.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox85.Text = "---";
                textBox84.Text = "---";
                textBox83.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox86.Text));
                textBox82.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox86.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox83.Text = "---";
                textBox82.Text = "---";
                textBox85.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox87.Text));//начальная дата + дни
                textBox84.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox85.Text = dt1.ToShortDateString(); //начальная дата
                textBox83.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox87.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox86.Text));


                textBox84.Text = dt1.ToShortDateString();//конечная дата
                textBox82.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }

            if (textBox81.Text.Equals("0") && textBox80.Text.Equals("0"))
            {
                textBox79.Text = "---";
                textBox78.Text = "---";
                textBox77.Text = "---";
                textBox76.Text = "---";
            }
            else if (textBox81.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox79.Text = "---";
                textBox78.Text = "---";
                textBox77.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox80.Text));
                textBox76.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox80.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox77.Text = "---";
                textBox76.Text = "---";
                textBox79.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox81.Text));//начальная дата + дни
                textBox78.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox79.Text = dt1.ToShortDateString(); //начальная дата
                textBox77.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox81.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox80.Text));


                textBox78.Text = dt1.ToShortDateString();//конечная дата
                textBox76.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }

            if (textBox99.Text.Equals("0") && textBox98.Text.Equals("0"))
            {
                textBox97.Text = "---";
                textBox96.Text = "---";
                textBox95.Text = "---";
                textBox94.Text = "---";
            }
            else if (textBox81.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox97.Text = "---";
                textBox96.Text = "---";
                textBox95.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox98.Text));
                textBox94.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox98.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox95.Text = "---";
                textBox94.Text = "---";
                textBox97.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox99.Text));//начальная дата + дни
                textBox96.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox97.Text = dt1.ToShortDateString(); //начальная дата
                textBox95.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox99.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox98.Text));


                textBox96.Text = dt1.ToShortDateString();//конечная дата
                textBox94.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }

            if (textBox93.Text.Equals("0") && textBox92.Text.Equals("0"))
            {
                textBox91.Text = "---";
                textBox90.Text = "---";
                textBox89.Text = "---";
                textBox88.Text = "---";
            }
            else if (textBox93.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox91.Text = "---";
                textBox90.Text = "---";
                textBox89.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox92.Text));
                textBox88.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox92.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox89.Text = "---";
                textBox88.Text = "---";
                textBox91.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox93.Text));//начальная дата + дни
                textBox90.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox91.Text = dt1.ToShortDateString(); //начальная дата
                textBox89.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox93.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox92.Text));


                textBox90.Text = dt1.ToShortDateString();//конечная дата
                textBox88.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }

            if (textBox105.Text.Equals("0") && textBox104.Text.Equals("0"))
            {
                textBox103.Text = "---";
                textBox102.Text = "---";
                textBox101.Text = "---";
                textBox100.Text = "---";
            }
            else if (textBox105.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox103.Text = "---";
                textBox102.Text = "---";
                textBox101.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox104.Text));
                textBox100.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox104.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox101.Text = "---";
                textBox100.Text = "---";
                textBox103.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox105.Text));//начальная дата + дни
                textBox102.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox103.Text = dt1.ToShortDateString(); //начальная дата
                textBox101.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox105.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox104.Text));


                textBox102.Text = dt1.ToShortDateString();//конечная дата
                textBox100.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }

            if (textBox111.Text.Equals("0") && textBox110.Text.Equals("0"))
            {
                textBox109.Text = "---";
                textBox108.Text = "---";
                textBox107.Text = "---";
                textBox106.Text = "---";
            }
            else if (textBox111.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox109.Text = "---";
                textBox108.Text = "---";
                textBox107.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox110.Text));
                textBox106.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox110.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox107.Text = "---";
                textBox106.Text = "---";
                textBox109.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox111.Text));//начальная дата + дни
                textBox108.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }else
            {
                textBox109.Text = dt1.ToShortDateString(); //начальная дата
                textBox107.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox111.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox110.Text));


                textBox108.Text = dt1.ToShortDateString();//конечная дата
                textBox106.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }

            if (textBox129.Text.Equals("0") && textBox128.Text.Equals("0"))
            {
                textBox127.Text = "---";
                textBox126.Text = "---";
                textBox125.Text = "---";
                textBox124.Text = "---";
            }
            else if (textBox129.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox127.Text = "---";
                textBox126.Text = "---";
                textBox125.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox128.Text));
                textBox124.Text = dt2.ToShortDateString();
                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox128.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox125.Text = "---";
                textBox124.Text = "---";
                textBox127.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox129.Text));//начальная дата + дни
                textBox126.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox127.Text = dt1.ToShortDateString(); //начальная дата
                textBox125.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox129.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox128.Text));


                textBox126.Text = dt1.ToShortDateString();//конечная дата
                textBox124.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }

            if (textBox123.Text.Equals("0") && textBox122.Text.Equals("0"))
            {
                textBox121.Text = "---";
                textBox120.Text = "---";
                textBox119.Text = "---";
                textBox118.Text = "---";
            }
            else if (textBox123.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox121.Text = "---";
                textBox120.Text = "---";
                textBox119.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox122.Text));
                textBox118.Text = dt2.ToShortDateString();
                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox122.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox119.Text = "---";
                textBox118.Text = "---";
                textBox121.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox123.Text));//начальная дата + дни
                textBox120.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox121.Text = dt1.ToShortDateString(); //начальная дата
                textBox119.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox123.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox122.Text));


                textBox120.Text = dt1.ToShortDateString();//конечная дата
                textBox118.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }

            if (textBox117.Text.Equals("0") && textBox116.Text.Equals("0"))
            {
                textBox115.Text = "---";
                textBox114.Text = "---";
                textBox113.Text = "---";
                textBox112.Text = "---";
            }
            else if (textBox117.Text.Equals("0"))
            {
                dt2 = dt1;
                textBox115.Text = "---";
                textBox114.Text = "---";
                textBox113.Text = dt2.ToShortDateString();
                dt2 = dt2.AddDays(Convert.ToDouble(textBox116.Text));
                textBox112.Text = dt2.ToShortDateString();
                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else if (textBox116.Text.Equals("0"))
            {
                dt1 = dt2;
                textBox113.Text = "---";
                textBox112.Text = "---";
                textBox115.Text = dt1.ToShortDateString(); //начальная дата
                dt1 = dt1.AddDays(Convert.ToDouble(textBox117.Text));//начальная дата + дни
                textBox114.Text = dt1.ToShortDateString();//конечная дата

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            else
            {
                textBox115.Text = dt1.ToShortDateString(); //начальная дата
                textBox113.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(Convert.ToDouble(textBox117.Text));//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox116.Text));


                textBox114.Text = dt1.ToShortDateString();//конечная дата
                textBox112.Text = dt2.ToShortDateString();

                dt1 = dt1.AddDays(1);
                dt2 = dt2.AddDays(1);
                if (dt1 > dt2)
                {
                    dt2 = dt1;
                }
                else
                {
                    dt1 = dt2;
                }
            }
            
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

