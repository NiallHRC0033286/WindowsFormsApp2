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
                if (numberofresistors.Text == "2") //Checking how many resistors there are
                {
                    textBox6.ResetText(); //Clearing the result textbox
                    double R1 = double.Parse(textBox1.Text); //Converting the textbox inputs to double variables
                    double R2 = double.Parse(textBox2.Text);
                    double Total = 1 / ((1 / R1) + (1 / R2)); //Calculating total resistance
                    textBox6.AppendText(Total.ToString()); //Displaying result in the textbox
                }
                if (numberofresistors.Text == "3") //Checking how many resistors there are
                {
                    textBox6.ResetText(); //Clearing the result textbox
                    double R1 = double.Parse(textBox1.Text); //Converting the textbox inputs to double variables
                    double R2 = double.Parse(textBox2.Text);
                    double R3 = double.Parse(textBox3.Text);
                    double Total = 1 / ((1 / R1) + (1 / R2) + (1 / R3)); //Calculating total resistance
                    textBox6.AppendText(Total.ToString()); //Displaying result in the textbox
                }
                if (numberofresistors.Text == "4") //Checking how many resistors there are
                {
                    textBox6.ResetText(); //Clearing the result textbox
                    double R1 = double.Parse(textBox1.Text); //Converting the textbox inputs to double variables
                    double R2 = double.Parse(textBox2.Text);
                    double R3 = double.Parse(textBox3.Text);
                    double R4 = double.Parse(textBox4.Text);
                    double Total = 1 / ((1 / R1) + (1 / R2) + (1 / R3) + (1 / R4)); //Calculating total resistance
                    textBox6.AppendText(Total.ToString()); //Displaying result in the textbox
                }
                if (numberofresistors.Text == "5") //Checking how many resistors there are
                {
                    textBox6.ResetText(); //Clearing the result textbox
                    double R1 = double.Parse(textBox1.Text); //Converting the textbox inputs to double variables
                    double R2 = double.Parse(textBox2.Text);
                    double R3 = double.Parse(textBox3.Text);
                    double R4 = double.Parse(textBox4.Text);
                    double R5 = double.Parse(textBox5.Text);
                    double Total = 1 / ((1 / R1) + (1 / R2) + (1 / R3) + (1 / R4) + (1 / R5)); //Calculating total resistance
                    textBox6.AppendText(Total.ToString()); //Displaying result in the textbox
                }
            }
            
            catch
            {
                textBox6.ResetText();
                textBox6.AppendText("Error"); //Error message is displayed if an invalid character is typed in.
            }
        }

        private void numberofresistors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numberofresistors.Text == "2") //Checking how many resistors there are
            {
                textBox3.ReadOnly = true; //Changing how many boxes can be typed in depending on how many resistors there are
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
            }
            if (numberofresistors.Text == "3") //Checking how many resistors there are
            {
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
            }
            if (numberofresistors.Text == "4") //Checking how many resistors there are
            {
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = true;
            }
            if (numberofresistors.Text == "5") //Checking how many resistors there are
            {
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
            }
        }

        private void numberofseriesresistors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numberofseriesresistors.Text == "2") //Checking how many resistors there are
            {
                S3box.ReadOnly = true; //Changing how many boxes can be typed in depending on how many resistors there are
                S4box.ReadOnly = true;
                S5box.ReadOnly = true;
            }
            if (numberofseriesresistors.Text == "3") //Checking how many resistors there are
            {
                S3box.ReadOnly = false;
                S4box.ReadOnly = true;
                S5box.ReadOnly = true;
            }
            if (numberofseriesresistors.Text == "4") //Checking how many resistors there are
            {
                S3box.ReadOnly = false;
                S4box.ReadOnly = false;
                S5box.ReadOnly = true;
            }
            if (numberofseriesresistors.Text == "5") //Checking how many resistors there are
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
                if (numberofseriesresistors.Text == "2") //Checking how many resistors there are
                {
                    SeriesTotal.ResetText(); //Clearing the result textbox
                    double R1 = double.Parse(S1box.Text); //Converting the textbox inputs to double variables
                    double R2 = double.Parse(S2box.Text);
                    double Total = R1 + R2; //Calculating total resistance
                    SeriesTotal.AppendText(Total.ToString()); //Displaying result in the textbox
                }
                if (numberofseriesresistors.Text == "3") //Checking how many resistors there are
                {
                    SeriesTotal.ResetText(); //Clearing the result textbox
                    double R1 = double.Parse(S1box.Text); //Converting the textbox inputs to double variables
                    double R2 = double.Parse(S2box.Text);
                    double R3 = double.Parse(S3box.Text);
                    double Total = R1 + R2 + R3; //Calculating total resistance
                    SeriesTotal.AppendText(Total.ToString()); //Displaying result in the textbox
                }
                if (numberofseriesresistors.Text == "4") //Checking how many resistors there are
                {
                    SeriesTotal.ResetText(); //Clearing the result textbox
                    double R1 = double.Parse(S1box.Text); //Converting the textbox inputs to double variables
                    double R2 = double.Parse(S2box.Text);
                    double R3 = double.Parse(S3box.Text);
                    double R4 = double.Parse(S4box.Text);
                    double Total = R1 + R2 + R3 + R4; //Calculating total resistance
                    SeriesTotal.AppendText(Total.ToString()); //Displaying result in the textbox
                }
                if (numberofseriesresistors.Text == "5") //Checking how many resistors there are
                {
                    SeriesTotal.ResetText(); //Clearing the result textbox
                    double R1 = double.Parse(S1box.Text); //Converting the textbox inputs to double variables
                    double R2 = double.Parse(S2box.Text);
                    double R3 = double.Parse(S3box.Text);
                    double R4 = double.Parse(S4box.Text);
                    double R5 = double.Parse(S5box.Text);
                    double Total = R1 + R2 + R3 + R4 + R5; //Calculating total resistance
                    SeriesTotal.AppendText(Total.ToString()); //Displaying result in the textbox
                }
            }

            catch
            {
                SeriesTotal.ResetText();
                SeriesTotal.AppendText("Error"); //Error message is displayed if an invalid character is typed in.
            }
        }
    }
}
