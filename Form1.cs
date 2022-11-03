using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblInput_Click(object sender, EventArgs e)
        {

        }

        private void txtSeconds_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // This is the click event handler for the button and the code will be executed when the button is clicked at runtime.

            // Display an error message if the input textbox is blank
            if (txtSeconds.Text == "")
            {
                MessageBox.Show("Please enter the value.");
            }
            else
            {
                // Proceed only if the input textbox has some data.

                // Get the value from the textbox, convert it to integer and store it in the variable "seconds"
                int seconds = Convert.ToInt32(txtSeconds.Text);

                // If the seconds is greater than or equal to 86400, convert it into days as follows and display the result in days in the output textbox
                if (seconds >= 86400)
                {
                    int days = seconds / 86400;
                    txtResult.Text = days + " days";
                }

                // If the above condition fails, proceed with the below
                // If the seconds is greater than or equal to 3600, convert it into hours as follows and display the result in hours in the output textbox
                else if (seconds >= 3600)
                {
                    int hours = seconds / 3600;
                    txtResult.Text = hours + " hours";
                }

                // If the above condition fails, proceed with the below
                // If the seconds is greater than or equal to 60, convert it into minutes as follows and display the result in minutes in the output textbox
                else if (seconds >= 60)
                {
                    int minutes = seconds / 60;
                    txtResult.Text = minutes + " minutes";
                }

                // If all the above condition fails, then the seconds is less than 60, simply display the seconds.
                else
                {
                    txtResult.Text = seconds + " seconds";
                }
            }
        }
    }
    }
