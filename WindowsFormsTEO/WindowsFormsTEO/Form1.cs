﻿using System;
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
        double day1, day2;
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

            textBox130.Text = "0";
            textBox131.Text = "0";
            textBox132.Text = "0";
            textBox133.Text = "0";
            textBox134.Text = "0";
            textBox135.Text = "0";
            textBox136.Text = "0";
            textBox137.Text = "0";
            textBox167.Text = "0";

            textBox138.Text = "21";
            textBox139.Text = "0";
            textBox140.Text = "0";
            textBox141.Text = "0";
            textBox142.Text = "0";
            textBox143.Text = "0";
            textBox144.Text = "0";
            textBox145.Text = "0";
            textBox146.Text = "0";
            textBox147.Text = "0";

            textBox148.Text = "шт.";
            textBox149.Text = "шт.";
            textBox150.Text = "пачка";

            textBox153.Text = "0";
            textBox152.Text = "0";
            textBox151.Text = "0";

            textBox156.Text = "0";
            textBox155.Text = "0";
            textBox154.Text = "0";

            textBox160.Text = "0";
            textBox159.Text = "0";
            textBox158.Text = "0";
            textBox157.Text = "0";
            textBox169.Text = "0";
            textBox170.Text = "0";

            textBox164.Text = "0";
            textBox162.Text = "0";
            textBox163.Text = "0";
            textBox168.Text = "0";
            textBox166.Text = "0";
            textBox161.Text = "0";
            textBox165.Text = "0";

            ///4 вкладка
            textBox203.Text = "21";
            textBox206.Text = "0,302";
            textBox205.Text = "0,1";
            textBox204.Text = "0,3";
            textBox215.Text = "247";
            textBox216.Text = "8";
            textBox171.Text = "0";
            textBox172.Text = "0";
            textBox178.Text = "0";
            textBox177.Text = "0";
            textBox188.Text = "0";
            textBox187.Text = "0";
            textBox184.Text = "0";
            textBox183.Text = "0";

            textBox178.Text = "0";
            textBox177.Text = "0";
            textBox188.Text = "0";
            textBox187.Text = "0";
            textBox184.Text = "0";
            textBox183.Text = "0";

            textBox253.Text = "0,01";
            textBox252.Text = "0,01";
            textBox251.Text = "0,2";
            textBox250.Text = "0,2";


            textBox248.Text = "247";
            textBox249.Text = "8";

            textBox207.Text = "22500";
            textBox212.Text = "0,2";
            textBox214.Text = "1";
            textBox210.Text = "0,4";
            textBox218.Text = "2,6";
            textBox220.Text = "0,05";

            textBox208.Text = "22500";
            textBox211.Text = "0,2";
            textBox213.Text = "1";
            textBox209.Text = "0,4";
            textBox217.Text = "2,6";
            textBox219.Text = "0,05";

            textBox236.Text = "37300";
            textBox233.Text = "12000";
            textBox234.Text = "22500";
            textBox235.Text = "9000";
            textBox237.Text = "0";

            //5вкладка
            textBox229.Text = "0,33";
            textBox238.Text = "1,6";
            textBox239.Text = "1";


            textBox230.Text = "0";
            textBox231.Text = "0";
            textBox232.Text = "0";


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

            day1 = 0;
            day2 = 0;

            if (textBox29.Text.Equals("0")){
                dt2 = dt1;
                day1 = 1;
                textBox30.Text = dt1.ToShortDateString();
                textBox31.Text = dt1.ToShortDateString();
                textBox33.Text = "---";
                textBox32.Text = "---";

            }else
            {
                textBox30.Text = dt1.ToShortDateString();
                textBox33.Text = dt2.ToShortDateString();

                
                dt1 = dt1.AddDays(Convert.ToDouble(textBox28.Text)-1);
                dt2 = dt2.AddDays(Convert.ToDouble(textBox29.Text) - 1);

                day1 += Convert.ToDouble(textBox28.Text);
                day2 += Convert.ToDouble(textBox29.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox38.Text) - 1);
                textBox34.Text = dt2.ToShortDateString();
                day2 += Convert.ToDouble(textBox38.Text);
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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox39.Text) - 1);//начальная дата + дни
                textBox36.Text = dt1.ToShortDateString();//конечная дата
                day1 += Convert.ToDouble(textBox39.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox39.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox38.Text) - 1);

                day1 += Convert.ToDouble(textBox39.Text);
                day2 += Convert.ToDouble(textBox38.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox50.Text) - 1);
                textBox46.Text = dt2.ToShortDateString();

                day2 += Convert.ToDouble(textBox50.Text);

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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox51.Text) - 1);//начальная дата + дни
                textBox48.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox51.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox51.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox50.Text) - 1);

                day1 += Convert.ToDouble(textBox51.Text);
                day2 += Convert.ToDouble(textBox50.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox44.Text) - 1);
                textBox40.Text = dt2.ToShortDateString();
                day2 += Convert.ToDouble(textBox44.Text);


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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox45.Text) - 1);//начальная дата + дни
                textBox42.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox45.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox45.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox44.Text) - 1);

                day1 += Convert.ToDouble(textBox45.Text);
                day2 += Convert.ToDouble(textBox44.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox74.Text) - 1);
                textBox70.Text = dt2.ToShortDateString();

                day2 += Convert.ToDouble(textBox74.Text);

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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox75.Text) - 1);//начальная дата + дни
                textBox72.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox75.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox75.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox74.Text) - 1);

                day1 += Convert.ToDouble(textBox75.Text);
                day2 += Convert.ToDouble(textBox74.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox62.Text) - 1);
                textBox58.Text = dt2.ToShortDateString();

                day2 += Convert.ToDouble(textBox62.Text);


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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox63.Text) - 1);//начальная дата + дни
                textBox60.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox63.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox63.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox62.Text) - 1);

                day1 += Convert.ToDouble(textBox63.Text);
                day2 += Convert.ToDouble(textBox62.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox68.Text) - 1);
                textBox64.Text = dt2.ToShortDateString();

                day2 += Convert.ToDouble(textBox68.Text);

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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox69.Text) - 1);//начальная дата + дни
                textBox66.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox69.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox69.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox68.Text) - 1);

                day1 += Convert.ToDouble(textBox69.Text);
                day2 += Convert.ToDouble(textBox68.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox56.Text) - 1);
                textBox52.Text = dt2.ToShortDateString();

                day2 += Convert.ToDouble(textBox56.Text);

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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox57.Text) - 1);//начальная дата + дни
                textBox54.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox57.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox57.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox56.Text) - 1);

                day1 += Convert.ToDouble(textBox57.Text);
                day2 += Convert.ToDouble(textBox56.Text);


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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox86.Text) - 1);
                textBox82.Text = dt2.ToShortDateString();

                day2 += Convert.ToDouble(textBox86.Text);

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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox87.Text) - 1);//начальная дата + дни
                textBox84.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox87.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox87.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox86.Text) - 1);

                day1 += Convert.ToDouble(textBox87.Text);
                day2 += Convert.ToDouble(textBox86.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox80.Text) - 1);
                textBox76.Text = dt2.ToShortDateString();

                day2 += Convert.ToDouble(textBox80.Text);


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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox81.Text) - 1);//начальная дата + дни
                textBox78.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox81.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox81.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox80.Text) - 1);

                day1 += Convert.ToDouble(textBox81.Text);
                day2 += Convert.ToDouble(textBox80.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox98.Text) - 1);
                textBox94.Text = dt2.ToShortDateString();

                day2 += Convert.ToDouble(textBox98.Text);

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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox99.Text) - 1);//начальная дата + дни
                textBox96.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox99.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox99.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox98.Text) - 1);

                day1 += Convert.ToDouble(textBox99.Text);
                day2 += Convert.ToDouble(textBox98.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox92.Text) - 1);
                textBox88.Text = dt2.ToShortDateString();

                day2 += Convert.ToDouble(textBox92.Text);

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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox93.Text) - 1);//начальная дата + дни
                textBox90.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox93.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox93.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox92.Text) - 1);

                day1 += Convert.ToDouble(textBox93.Text);
                day2 += Convert.ToDouble(textBox92.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox104.Text) - 1);
                textBox100.Text = dt2.ToShortDateString();

                day2 += Convert.ToDouble(textBox104.Text);

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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox105.Text) - 1);//начальная дата + дни
                textBox102.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox105.Text);


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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox105.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox104.Text) - 1);

                day1 += Convert.ToDouble(textBox105.Text);
                day2 += Convert.ToDouble(textBox104.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox110.Text) - 1);
                textBox106.Text = dt2.ToShortDateString();

                day2 += Convert.ToDouble(textBox110.Text);


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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox111.Text) - 1);//начальная дата + дни
                textBox108.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox111.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox111.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox110.Text) - 1);

                day1 += Convert.ToDouble(textBox111.Text);
                day2 += Convert.ToDouble(textBox110.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox128.Text) - 1);

                day2 += Convert.ToDouble(textBox128.Text);

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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox129.Text) - 1);//начальная дата + дни
                textBox126.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox129.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox129.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox128.Text) - 1);

                day1 += Convert.ToDouble(textBox129.Text);
                day2 += Convert.ToDouble(textBox128.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox122.Text) - 1);
                textBox118.Text = dt2.ToShortDateString();

                day2 += Convert.ToDouble(textBox122.Text);

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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox123.Text) - 1);//начальная дата + дни
                textBox120.Text = dt1.ToShortDateString();//конечная дата

                day1 += Convert.ToDouble(textBox123.Text);

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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox123.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox122.Text) - 1);

                day1 += Convert.ToDouble(textBox123.Text);
                day2 += Convert.ToDouble(textBox122.Text);

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
                dt2 = dt2.AddDays(Convert.ToDouble(textBox116.Text) - 1);
                textBox112.Text = dt2.ToShortDateString();

                day2 += Convert.ToDouble(textBox116.Text);
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
                dt1 = dt1.AddDays(Convert.ToDouble(textBox117.Text) - 1);//начальная дата + дни
                textBox114.Text = dt1.ToShortDateString();//конечная дата
                day1 += Convert.ToDouble(textBox117.Text);
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

                dt1 = dt1.AddDays(Convert.ToDouble(textBox117.Text) - 1);//начальная дата + дни
                dt2 = dt2.AddDays(Convert.ToDouble(textBox116.Text) - 1);

                day1 += Convert.ToDouble(textBox117.Text);
                day2 += Convert.ToDouble(textBox116.Text);

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
            textBox247.Text = "0";
            textBox246.Text = "0";
            textBox247.Text = day1.ToString();
            textBox246.Text = day2.ToString();
            // day1 = 0;
            //day2 = 0;
        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void label103_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Czp1 = 0, Czp2 = 0; //Затраты на заработную плату основную и дополнительную с отчислениями 
            double srZpDay11 = 0, srZpDay12 = 0, srZpDay21 = 0, srZpDay22 = 0, SumZp1 = 0, SumZp2 = 0;
            double colDay;
            double Wd = 0, Wc = 0;
            double Ca = 0; //Сумма амортизационных отчислений.
            double balanceCost1 = 0, balanceCost2 = 0;
            double tj1, tj2;//время работы
            double Fbj = 0; //эффективный фонд времени работы оборудования в год, час;
            double aj1 = 0, aj2 = 0;//норма годовых амортизационных отчислений для j-гo вида оборудования;
            double g1 = 0, g2 = 0;//количество единиц оборудования j-гo вида.
            double Ca1 = 0, Ca2 = 0;


            Wd = Convert.ToDouble(textBox146.Text) + Convert.ToDouble(textBox204.Text);
            Wc = Convert.ToDouble(textBox139.Text);

            colDay = Convert.ToDouble(textBox203.Text);

            srZpDay11 = Convert.ToDouble(textBox171.Text) / colDay;
            srZpDay12 = Convert.ToDouble(textBox172.Text) / colDay;

            textBox174.Text = Math.Round(srZpDay11, 2).ToString();
            textBox173.Text = Math.Round(srZpDay12, 2).ToString();

            textBox176.Text = Math.Round((srZpDay11 * Convert.ToDouble(textBox178.Text) * (1 + Wd) * (1 + Wc)), 2).ToString();
            textBox175.Text = Math.Round((srZpDay12 * Convert.ToDouble(textBox177.Text) * (1 + Wd) * (1 + Wc)), 2).ToString();

            textBox179.Text = Math.Round((Convert.ToDouble(textBox176.Text)+ Convert.ToDouble(textBox175.Text)), 2).ToString();
            SumZp1 = Convert.ToDouble(textBox179.Text);

            Czp1 = SumZp1;
            textBox191.Text = Math.Round(Czp1, 2).ToString();

            srZpDay21 = Convert.ToDouble(textBox188.Text) / colDay;
            srZpDay22 = Convert.ToDouble(textBox187.Text) / colDay;

            textBox186.Text = Math.Round(srZpDay21, 2).ToString();
            textBox185.Text = Math.Round(srZpDay22, 2).ToString();

            textBox182.Text = Math.Round((srZpDay21 * Convert.ToDouble(textBox184.Text) * (1 + Wd) * (1 + Wc)), 2).ToString();
            textBox181.Text = Math.Round((srZpDay22 * Convert.ToDouble(textBox183.Text) * (1 + Wd) * (1 + Wc)), 2).ToString();

            textBox180.Text = Math.Round((Convert.ToDouble(textBox182.Text) + Convert.ToDouble(textBox181.Text)), 2).ToString();
            SumZp2 = Convert.ToDouble(textBox180.Text);

            Czp2 = SumZp2;
            textBox200.Text = Math.Round(Czp2, 2).ToString();
            
            
            ////Амортизационные отчисления ////
            balanceCost1 = Convert.ToDouble(textBox207.Text);
            balanceCost2 = Convert.ToDouble(textBox208.Text);

            tj1 = ((Convert.ToDouble(textBox178.Text)+ Convert.ToDouble(textBox177.Text))* Convert.ToDouble(textBox216.Text));
            tj2 = ((Convert.ToDouble(textBox184.Text) + Convert.ToDouble(textBox183.Text)) * Convert.ToDouble(textBox216.Text));

            Fbj = Convert.ToDouble(textBox248.Text) * Convert.ToDouble(textBox216.Text);

            aj1 = Convert.ToDouble(textBox212.Text);
            aj2 = Convert.ToDouble(textBox211.Text);

            g1 = Convert.ToDouble(textBox214.Text);
            g2 = Convert.ToDouble(textBox213.Text);

            Ca1 = (balanceCost1*tj1*aj1*g1) / Fbj;
            Ca2 = (balanceCost2 * tj2 * aj2 * g2) / Fbj;

            textBox190.Text = Math.Round(Ca1, 2).ToString();
            textBox199.Text = Math.Round(Ca2, 2).ToString();

            ///Затраты на силовую энергию рассчитываются по формуле///
            double Z1 = 0, Z2 = 0;
            Z1 = Convert.ToDouble(textBox210.Text) * tj1 * g1 * Convert.ToDouble(textBox218.Text);
            Z2 = Convert.ToDouble(textBox209.Text) * tj2 * g2 * Convert.ToDouble(textBox217.Text);

            textBox189.Text = Math.Round(Z1, 2).ToString();
            textBox198.Text = Math.Round(Z2, 2).ToString();

            ///Затраты на текущий ремонт оборудования рассчитываются по формуле///
            double Zrem1 = 0, Zrem2 = 0;
            Zrem1 = (Convert.ToDouble(textBox220.Text) * balanceCost1 * tj1) / Fbj;
            Zrem2 = (Convert.ToDouble(textBox219.Text) * balanceCost2 * tj2) / Fbj;

            textBox194.Text = Math.Round(Zrem1, 2).ToString();
            textBox197.Text = Math.Round(Zrem2, 2).ToString();

            ///Затраты на материалы, потребляемые в течение года
            textBox193.Text = Math.Round((balanceCost1* Convert.ToDouble(textBox253.Text)), 2).ToString();
            textBox196.Text = Math.Round((balanceCost2 * Convert.ToDouble(textBox252.Text)), 2).ToString();

            ///Накладные расходы 
            double nakRash1 = 0, nakRash2 = 0;

            nakRash1 = (Convert.ToDouble(textBox191.Text)+ Convert.ToDouble(textBox190.Text)+ Convert.ToDouble(textBox189.Text)+
                Convert.ToDouble(textBox194.Text)+ Convert.ToDouble(textBox193.Text))* Convert.ToDouble(textBox251.Text);
            nakRash2 = (Convert.ToDouble(textBox200.Text) + Convert.ToDouble(textBox199.Text) + Convert.ToDouble(textBox198.Text) +
                Convert.ToDouble(textBox197.Text) + Convert.ToDouble(textBox196.Text)) * Convert.ToDouble(textBox250.Text);

            textBox192.Text = Math.Round(nakRash1, 2).ToString();
            textBox195.Text = Math.Round(nakRash2, 2).ToString();

            ///Итого 
            double yearZatrSum1 = 0, yearZatrSum2 = 0;
            yearZatrSum1 = Convert.ToDouble(textBox191.Text) + Convert.ToDouble(textBox190.Text) + Convert.ToDouble(textBox189.Text) +
                Convert.ToDouble(textBox194.Text) + Convert.ToDouble(textBox193.Text) + Convert.ToDouble(textBox192.Text);

            yearZatrSum2 = Convert.ToDouble(textBox200.Text) + Convert.ToDouble(textBox199.Text) + Convert.ToDouble(textBox198.Text) +
                Convert.ToDouble(textBox197.Text) + Convert.ToDouble(textBox196.Text) + Convert.ToDouble(textBox195.Text);

            textBox202.Text = Math.Round(yearZatrSum1, 2).ToString();
            textBox201.Text = Math.Round(yearZatrSum2, 2).ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            ///Приведенные затраты Зi на единицу работ
            
            double zatr1 = 0, zatr2 = 0;
            zatr1 = Convert.ToDouble(textBox202.Text) + Convert.ToDouble(textBox229.Text) * Convert.ToDouble(textBox232.Text);
            zatr2 = Convert.ToDouble(textBox201.Text) + Convert.ToDouble(textBox229.Text) * Convert.ToDouble(textBox237.Text);

            textBox224.Text = Math.Round(zatr2, 2).ToString();
            textBox226.Text = Math.Round(zatr1, 2).ToString();

            //себестоимость
            textBox221.Text = Math.Round(Convert.ToDouble(textBox201.Text), 2).ToString();
            textBox228.Text = Math.Round(Convert.ToDouble(textBox202.Text), 2).ToString();

            //суммарные затраты
            textBox222.Text = Math.Round(Convert.ToDouble(textBox237.Text), 2).ToString();
            textBox227.Text = Math.Round(Convert.ToDouble(textBox232.Text), 2).ToString();

            //эффект от использования разрабатываемой

            double Effect = 0;
            Effect = (zatr2 * Convert.ToDouble(textBox238.Text) - zatr1) * Convert.ToDouble(textBox239.Text);
            textBox223.Text = Math.Round(Effect, 2).ToString();

            //срок окупаемости затрат на разработку продукта по формуле
            textBox225.Text = Math.Round(Convert.ToDouble(textBox227.Text) / Convert.ToDouble(textBox223.Text), 2).ToString();

            //фактический коэффициент экономической эффективности разработки (Еф) 
            double Ef = 0;
            Ef = 1 / Convert.ToDouble(textBox225.Text);
            textBox240.Text = Math.Round(Ef, 2).ToString();

            if (Ef > Convert.ToDouble(textBox229.Text))
            {
                label175.Text = "Ef > Eh разработка и внедрение разрабатываемого продукта является эффективной.";
            }
            else if (Ef < Convert.ToDouble(textBox229.Text))
            {
                label175.Text = "Ef < Eh разработка и внедрение разрабатываемого продукта является не эффективной.";
            }
            else
            {
                label175.Text = "Ef = Eh";
            }

            //Результаты экономического обоснования проекта
            textBox243.Text = Math.Round(Convert.ToDouble(textBox227.Text), 2).ToString();
            textBox242.Text = Math.Round(Convert.ToDouble(textBox228.Text), 2).ToString();
            textBox241.Text = Math.Round(Convert.ToDouble(textBox223.Text), 2).ToString();
            textBox245.Text = Math.Round(Convert.ToDouble(textBox240.Text), 2).ToString();
            textBox244.Text = Math.Round(Convert.ToDouble(textBox225.Text), 2).ToString();


        }

        private void label184_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void label185_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(".\\Справка.pdf");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !(char.IsDigit(c) || c == ',' || c == '\b');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Cm = 0; //затраты на материалы.
            day1 = 0;
            day2 = 0;
            Cm = 0;
            button2_Click(sender, e);
            double K = 0, Kp = 0, Kp2 = 0, Wd = 0, Wc = 0, Wh = 0, rabDayMounth = 0;
            double okl1 = 0, okl2 = 0;//оклады
            double srDaySt1 = 0, srDaySt2 = 0;//средне дневная ставка
            double ozp1 = 0, ozp2 = 0, ozpSum = 0;//озп
            double Mv = 0;//машинное время
            double Ko;//затраты на основное и вспомогательное оборудование
            double Yj;//коэффициент загрузки 
            double Tj;//Время работы технического средства 

           

            if (textBox146.Text.Equals(""))
            {
                MessageBox.Show("Введите коэффициент отпуска!");
            }
            else if (textBox146.Text.Equals(""))
            {
                MessageBox.Show("Введите Районный коэффициент!");
            }
            else if (textBox139.Text.Equals(""))
            {
                MessageBox.Show("Введите коэф., на отчисления в социальные нужды");
            }
            else if (textBox140.Text.Equals(""))
            {
                MessageBox.Show("Введите коэф., накладных расходов в долях");
            }
            else if (textBox140.Text.Equals(""))
            {
                MessageBox.Show("Введите количество рабочих дней в мясяце");
            }
            else if (textBox130.Text.Equals("0") || textBox130.Text.Equals(""))
            {
                MessageBox.Show("Введите оклад руководителя");
            }
            else if (textBox131.Text.Equals("0") || textBox131.Text.Equals(""))
            {
                MessageBox.Show("Введите оклад программиста");
            }
            /*else if (textBox153.Text.Equals("0"))
            {
                MessageBox.Show("Введите количество компакт дисков");
            }
            else if (textBox152.Text.Equals("0"))
            {
                MessageBox.Show("Введите количество тонера для принтера");
            }
            else if (textBox151.Text.Equals("0"))
            {
                MessageBox.Show("Введите количество пачек бумаги");
            }

            else if (textBox156.Text.Equals("0"))
            {
                
                MessageBox.Show("Введите цену за единицу компакт дисков");
            }
            else if (textBox154.Text.Equals("0"))
            {
                MessageBox.Show("Введите цену за единицу тонера для лазерного принтера");
            }
            else if (textBox151.Text.Equals("0"))
            {
                MessageBox.Show("Введите цену за единицу пачки бумаги");
            }
            
            else if (textBox151.Text.Equals("0"))
            {
                MessageBox.Show("Введите машинное время");
            }
            */
            else if (textBox144.Text.Equals("0"))
            {
                MessageBox.Show("Введите стоимость часа машинного времени");
            }
            else if (textBox145.Text.Equals("0"))
            {
                MessageBox.Show("Введите коэффициент мультипликотивности");
            }
            else if (textBox142.Text.Equals("0"))
            {
                MessageBox.Show("Введите количество оборудования");
            }
            else if (textBox141.Text.Equals("0"))
            {
                MessageBox.Show("Введите балансовую стоимость оборудования");
            }
            else if (textBox169.Text.Equals("0"))
            {
                MessageBox.Show("Введите сколько затрачено машинного времени");
            }
            /*
            else if (textBox170.Text.Equals("0"))
            {
                MessageBox.Show("Введите Uк – частота (периодичность) решения дней /год ");
            }
            */

            else
            { 
                Wd = Convert.ToDouble(textBox146.Text) + Convert.ToDouble(textBox147.Text);
                Wc = Convert.ToDouble(textBox139.Text);
                Wh = Convert.ToDouble(textBox140.Text);

                rabDayMounth = Convert.ToDouble(textBox138.Text);

                okl1 = Convert.ToDouble(textBox130.Text);
                okl2 = Convert.ToDouble(textBox131.Text);

                srDaySt1 = okl1 / rabDayMounth;
                textBox133.Text = Math.Round(srDaySt1, 2).ToString();

                srDaySt2 = okl2 / rabDayMounth;
                textBox132.Text = Math.Round(srDaySt2, 2).ToString(); 

                textBox135.Text = day1.ToString();
                textBox134.Text = day2.ToString();

                ozp1 = day1 * srDaySt1;
                ozp2 = day2 * srDaySt2;

                textBox137.Text = Math.Round(ozp1, 2).ToString();
                textBox136.Text = Math.Round(ozp2, 2).ToString();

                ozpSum = ozp1 + ozp2;
                textBox167.Text = Math.Round(ozpSum, 2).ToString();

                Cm += Convert.ToDouble(textBox153.Text) * Convert.ToDouble(textBox156.Text);
                textBox159.Text = Math.Round((Convert.ToDouble(textBox153.Text) * Convert.ToDouble(textBox156.Text)), 2).ToString();

                Cm += Convert.ToDouble(textBox152.Text) * Convert.ToDouble(textBox155.Text);
                textBox158.Text = Math.Round((Convert.ToDouble(textBox152.Text) * Convert.ToDouble(textBox155.Text)), 2).ToString();

                Cm += Convert.ToDouble(textBox151.Text) * Convert.ToDouble(textBox154.Text);
                textBox157.Text = Math.Round((Convert.ToDouble(textBox151.Text) * Convert.ToDouble(textBox154.Text)), 2).ToString();

                textBox160.Text = Math.Round(Cm,2).ToString();

                Mv = Convert.ToDouble(textBox143.Text) * Convert.ToDouble(textBox144.Text) * day2 * Convert.ToDouble(textBox145.Text);

                Kp = ((1 + Wd)*(1 + Wc) + Wh) * ozpSum + Cm + Mv;
                //label104.Text = "Капитальные вложения(Kп) = " + Math.Round(Kp, 2).ToString();
                textBox230.Text = Math.Round(Kp, 2).ToString();

                textBox164.Text = Math.Round(ozpSum, 2).ToString();
                textBox166.Text = Math.Round(Wh, 2).ToString();
                textBox168.Text = Math.Round(Cm, 2).ToString();
                textBox165.Text = Math.Round(Mv, 2).ToString();
                textBox162.Text = Math.Round((ozpSum * Wd), 2).ToString();
                textBox163.Text = Math.Round(((ozpSum + (ozpSum * Wd)) * Wc), 2).ToString();
                textBox166.Text = Math.Round((ozpSum * Wh), 2).ToString();
                textBox161.Text = Math.Round((ozpSum + Wh + Cm + Mv + (ozpSum * Wd) + ((ozpSum + (ozpSum * Wd)) * Wc) + (ozpSum * Wh)), 2).ToString();

                
                textBox237.Text = Math.Round((Convert.ToDouble(textBox236.Text) + Convert.ToDouble(textBox233.Text) + Convert.ToDouble(textBox234.Text) + Convert.ToDouble(textBox235.Text)), 2).ToString();

                textBox231.Text = Math.Round((Convert.ToDouble(textBox141.Text) * Convert.ToDouble(textBox142.Text) * ((Convert.ToDouble(textBox169.Text) * Convert.ToDouble(textBox170.Text)) / (Convert.ToDouble(textBox248.Text) * Convert.ToDouble(textBox249.Text)))), 2).ToString();
                textBox232.Text = Math.Round((Kp + (Convert.ToDouble(textBox141.Text) * Convert.ToDouble(textBox142.Text) * ((Convert.ToDouble(textBox169.Text) * Convert.ToDouble(textBox170.Text)) / (Convert.ToDouble(textBox248.Text) * Convert.ToDouble(textBox249.Text))))), 2).ToString();

                //label105.Text ="Кр = " + Math.Round((Convert.ToDouble(textBox141.Text) * Convert.ToDouble(textBox142.Text) * ((Convert.ToDouble(textBox169.Text) * Convert.ToDouble(textBox170.Text)) / (Convert.ToDouble(textBox170.Text) * 8))), 2).ToString();
                //label110.Text = "К = " + Math.Round((Kp + (Convert.ToDouble(textBox141.Text) * Convert.ToDouble(textBox142.Text) * ((Convert.ToDouble(textBox169.Text) * Convert.ToDouble(textBox170.Text)) / (Convert.ToDouble(textBox170.Text) * 8)))), 2).ToString();


                //day1 = 0;
                //day2 = 0;

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
            if (Sum < 1 )
            {
                MessageBox.Show("Коэффициент весомости не может быть меньше 1! Сейчас Коэффициент весомости = " + Sum);
            }

           
            //textBox10.Text = Sum.ToString(); проверка
            label18.Text = "Сумма коэффициентов весомости = " + Sum;
            Ak = 0;
            Ak = J1 / J2;
            
            label19.Text = "J1 = " + J1 + " J2 = " + J2 + " Ak = " + Math.Round(Ak, 2); ;
            textBox238.Text = Math.Round(Ak, 2).ToString(); 
            J1 = J2 = Ak = 0;
        }
    }
}

