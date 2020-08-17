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

namespace _102_PracticeTest1_Temperatures
{
    public partial class Form1 : Form
    {
        //Name:
        //ID:

        List<Reading> temperaturesList = new List<Reading>();

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateListBox()
        {
            listBoxData.Items.Clear();
            // loop through all the values in the List and display data on the listBox
            //for (int i = 0; i < temperaturesList.Count; i++)
            //{
            //    // add tot he listBox - don't need to ToString() this because the Reading class has a override method in it.
            //    listBoxData.Items.Add(temperaturesList[i]);
            // The foreach loop makes the list read only so you can't add elements or remove elements from the list
            foreach (Reading r in temperaturesList)
            {
                // (Note)you set a value to whats in the listbox already
                // (e.g) r.High = 100; 
                listBoxData.Items.Add(r);
            }
        }

        private void loadFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // get the file reader
            StreamReader reader;
            // variable to read a line
            string line = "";
            // array to handle the splitting of values from the csv
            string[] csvArray;

            string date = "";
            double high = 0;
            double low = 0;

            // opens the file
            openFileDialog1.Filter = "CSV Files|*.csv|ALL Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                reader = File.OpenText(openFileDialog1.FileName);
                while (!reader.EndOfStream)
                {
                    try
                    {
                        // read a line from the file
                        line = reader.ReadLine();
                        // split the line using an array
                        csvArray = line.Split(',');
                        // check if the array has the correct number of elements in that line
                        if (csvArray.Length == 3)
                        {
                            // extract the values out
                            date = csvArray[0];
                            high = double.Parse(csvArray[1]);
                            low = double.Parse(csvArray[2]);

                            // create an object and add to the temperatureList
                            Reading r = new Reading(date, high, low);
                            temperaturesList.Add(r);
                            // another way of creating an object an adding it to the List
                            //temperaturesList.Add(new Reading(date, high, low));

                        }
                        else
                        {
                            Console.WriteLine("Error: " + line);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error: " + line);
                    }
                }
                reader.Close();
                MessageBox.Show(temperaturesList.Count.ToString());

                UpdateListBox();
            }
        }
    }
}
