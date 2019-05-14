using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
                if (numberofresistors.Text == "2") 
                {
                    textBox6.ResetText();
                    double R1 = double.Parse(textBox1.Text);
                    double R2 = double.Parse(textBox2.Text);
                    double Total = 1 / ((1 / R1) + (1 / R2));
                    textBox6.AppendText(Total.ToString());
                }
                if (numberofresistors.Text == "3")
                {
                    textBox6.ResetText();
                    double R1 = double.Parse(textBox1.Text);
                    double R2 = double.Parse(textBox2.Text);
                    double R3 = double.Parse(textBox3.Text);
                    double Total = 1 / ((1 / R1) + (1 / R2) + (1 / R3));
                    textBox6.AppendText(Total.ToString());
                }
                if (numberofresistors.Text == "4")
                {
                    textBox6.ResetText();
                    double R1 = double.Parse(textBox1.Text);
                    double R2 = double.Parse(textBox2.Text);
                    double R3 = double.Parse(textBox3.Text);
                    double R4 = double.Parse(textBox4.Text);
                    double Total = 1 / ((1 / R1) + (1 / R2) + (1 / R3) + (1 / R4));
                    textBox6.AppendText(Total.ToString());
                }
                if (numberofresistors.Text == "5")
                {
                    textBox6.ResetText();
                    double R1 = double.Parse(textBox1.Text);
                    double R2 = double.Parse(textBox2.Text);
                    double R3 = double.Parse(textBox3.Text);
                    double R4 = double.Parse(textBox4.Text);
                    double R5 = double.Parse(textBox5.Text);
                    double Total = 1 / ((1 / R1) + (1 / R2) + (1 / R3) + (1 / R4) + (1 / R5));
                    textBox6.AppendText(Total.ToString());
                }
            }
            
            catch
            {
                textBox6.ResetText();
                textBox6.AppendText("Error");
            }
        }

        private void numberofresistors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numberofresistors.Text == "2")
            {
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
            }
            if (numberofresistors.Text == "3")
            {
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
            }
            if (numberofresistors.Text == "4")
            {
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = true;
            }
            if (numberofresistors.Text == "5")
            {
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
            }
        }

        private void numberofseriesresistors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numberofseriesresistors.Text == "2")
            {
                S3box.ReadOnly = true;
                S4box.ReadOnly = true;
                S5box.ReadOnly = true;
            }
            if (numberofseriesresistors.Text == "3")
            {
                S3box.ReadOnly = false;
                S4box.ReadOnly = true;
                S5box.ReadOnly = true;
            }
            if (numberofseriesresistors.Text == "4")
            {
                S3box.ReadOnly = false;
                S4box.ReadOnly = false;
                S5box.ReadOnly = true;
            }
            if (numberofseriesresistors.Text == "5")
            {
                S3box.ReadOnly = false;
                S4box.ReadOnly = false;
                S5box.ReadOnly = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (numberofseriesresistors.Text == "2")
                {
                    SeriesTotal.ResetText();
                    double R1 = double.Parse(S1box.Text);
                    double R2 = double.Parse(S2box.Text);
                    double Total = R1 + R2;
                    SeriesTotal.AppendText(Total.ToString());
                }
                if (numberofseriesresistors.Text == "3")
                {
                    SeriesTotal.ResetText();
                    double R1 = double.Parse(S1box.Text);
                    double R2 = double.Parse(S2box.Text);
                    double R3 = double.Parse(S3box.Text);
                    double Total = R1 + R2 + R3;
                    SeriesTotal.AppendText(Total.ToString());
                }
                if (numberofseriesresistors.Text == "4")
                {
                    SeriesTotal.ResetText();
                    double R1 = double.Parse(S1box.Text);
                    double R2 = double.Parse(S2box.Text);
                    double R3 = double.Parse(S3box.Text);
                    double R4 = double.Parse(S4box.Text);
                    double Total = R1 + R2 + R3 + R4;
                    SeriesTotal.AppendText(Total.ToString());
                }
                if (numberofseriesresistors.Text == "5")
                {
                    SeriesTotal.ResetText();
                    double R1 = double.Parse(S1box.Text);
                    double R2 = double.Parse(S2box.Text);
                    double R3 = double.Parse(S3box.Text);
                    double R4 = double.Parse(S4box.Text);
                    double R5 = double.Parse(S5box.Text);
                    double Total = R1 + R2 + R3 + R4 + R5;
                    SeriesTotal.AppendText(Total.ToString());
                }
            }

            catch
            {
                SeriesTotal.ResetText();
                SeriesTotal.AppendText("Error");
            }
        }
    }
}
