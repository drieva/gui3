using System;
using System.Windows.Forms;

namespace HurricaneApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Parse the input wind speed
            if (int.TryParse(windSpeedTextBox.Text, out int windSpeed))
            {
                // Determine the hurricane category based on the wind speed
                string category = GetCategory(windSpeed);

                // Display the hurricane category
                categoryLabel.Text = "Category: " + category;
            }
            else
            {
                // Display an error message if the input is invalid
                MessageBox.Show("Invalid input. Please enter a valid wind speed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetCategory(int windSpeed)
        {
            if (windSpeed >= 157)
            {
                return "Category 5";
            }
            else if (windSpeed >= 130)
            {
                return "Category 4";
            }
            else if (windSpeed >= 111)
            {
                return "Category 3";
            }
            else if (windSpeed >= 96)
            {
                return "Category 2";
            }
            else if (windSpeed >= 74)
            {
                return "Category 1";
            }
            else
            {
                return "Not a hurricane";
            }
        }
    }
}
