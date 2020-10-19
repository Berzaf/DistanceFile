/* Author: Berzaf Teklu
 * Date: 10/16/2020
 * 
 * Modify the Distance Calculator program it writes its output to a 
 * file instade of displaying the ListBox control.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DistanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declare variables 
            int speed;
            int hours;
            int distance;
            if (int.TryParse(speedTextBox.Text, out speed) && int.TryParse(hoursTextBox.Text, out hours) && speed >= 1 && hours >= 1)
            {
                try
                {
                    StreamWriter outputFile;
                    outputFile = File.CreateText("Distance.txt");      // Create output file.

                    for (int i = 1; i <= hours; i++)
                    {
                        distance = speed * i;                          // Calculate the distance.
                        outputFile.WriteLine("After hour " + i + " the vehicle traveled " + distance.ToString("n") + " miles.");

                    }
                    outputFile.Close();              // Close the output file
                    MessageBox.Show("The Distance.txt file was created.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }

            else
            {
                MessageBox.Show("Please enter valid numbers", "Invalid Input");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
