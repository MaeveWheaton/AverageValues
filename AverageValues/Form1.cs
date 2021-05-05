using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageValues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables
        double sum = 0;
        int totalNumbers = 0;
        double average;

        private void addButton_Click(object sender, EventArgs e)
        {
            //enter value
            //if value !=, add num to running sum, add one to # of #s tracker
            //if 0, calculate and display average sum/totalNumbers
            //input cleared, display message

            int num = Convert.ToInt32(numberInput.Text);            

            if (num != 0)
            {
                sum = sum + num;
                totalNumbers = totalNumbers + 1;

                numberInput.Clear();
                messageOutput.Text = $"{num} was added to the sum.";
            }
            else
            {
                average = sum / totalNumbers;
                messageOutput.Text = $"The average of all numbers entered is: {average.ToString("#.##")}";
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //input and output cleared
            numberInput.Clear();
            messageOutput.Text = "";

            //reset all variables to 0
            sum = 0;
            totalNumbers = 0;
        }
    }
}
