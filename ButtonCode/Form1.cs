using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this program is done
namespace ButtonCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_load(object sender, EventArgs e)
        {
            //button1.Text = "Hockey";
            //button2.Text = "Area";
            //button3.Text = "Carpet";
            //button4.Text = "Bill";
            label1.Text = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number = 99;
            string name = "Wayne Gretzky";

            label1.Text = name + " is number " + number;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double rad = 15;
            double pi = 3.14;
            double area; //area of circle
            area = rad * rad * pi;

            label1.Text = "The area of a circle with a radius of " + rad + "cm is " + area + "cm^2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costM = 19.95; //Cost per meter
            double areac; //area of carpet
            double total; //total cost of carpet

            areac = length * width;
            total = costM * areac;

            label1.Text = "The area of a room with dimensions " + length + "m x " + width + "m is " + areac + "m^2";
            label1.Text += "\n\n\nThe cost to carpet this area at " + costM + " per square metre is $" + total;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double costS = 12.49; //Cost of Shirt
            double pay = 20;
            double tax = 0.13;
            double costTax; //cost of tax
            double costTotal; //total payment needed
            double change;

            costTax = tax * costS;
            costTotal = costTax + costS;
            change = pay - costTotal;

            label1.Text = "Bill of Sale";
            label1.Text += "\nShirt: " + costS;
            label1.Text += "\n\nTax: " + costTax;
            label1.Text += "\nTotal: " + costTotal;
            label1.Text += "\n\nTendered: " + pay;
            label1.Text += "\nChange: " + change;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
        }
    }
}
