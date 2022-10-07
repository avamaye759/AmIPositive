using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmIPositive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt16(integerInput.Text);

                //positive or negative
                if (number > 0)
                {
                    signOutput.Text = $"{number} is a positive number";
                }
                else if (number < 0)
                {
                    signOutput.Text = $"{number} is a negative number";
                }
                else 
                {
                    signOutput.Text = $"{number} is neither positive or negative";
                    divisOutput.Text = $"I'm not telling you if it's divisible by 7";
                }

                //divisible by 7
                if (number == 0)
                {
                    divisOutput.Text = $"{number} divided by 7 is just {number}...";
                }
                else if (number % 7 == 0)
                {
                    divisOutput.Text = $"{number} is divisible by 7";
                }
                else
                {
                    divisOutput.Text = $"{number} is not divisible by 7";
                }
                
            }
            catch
            {
                signOutput.Text = $"Input Error";
                divisOutput.Text = $"Input Error";
            }
        }
    }
}
