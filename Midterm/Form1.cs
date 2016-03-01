using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form1 : Form
    {

        private List<string> delayInput = new List<string>();
        private List<string> rawOutput  = new List<string>();
        private List<string> convOutput = new List<string>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void longTestButton_Click(object sender, EventArgs e)
        {
            LongTestButton.Enabled = false;

            //Prevents user from inputting the incorrect name format into the program.
            if (personBox.Text.Length != 3) 
            {
                MessageBox.Show("What part of \"Three Letter Inintial\" wasn't clear here?", "Midterm", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                LongTestButton.Enabled = true;
                return;
            }

            //Makes sure the lists the data is going to go into are empty. This is important in the button is hit twice before a reset.
            delayInput.Clear();
            rawOutput.Clear();
            convOutput.Clear();

            string rawVal;
            double Conversion = 0;

            //Sets the data bar for the current test.
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            //Collects all the data.
            for (uint i = 0; i < 100; i++)
            {
                try
                {
                    serialPort.Open();
                    delayInput.Add(Convert.ToString(i * 40000000));
                    serialPort.WriteLine(Convert.ToString(i * 40000000)); //Sends delay value to zybo.
                    rawVal = serialPort.ReadLine();                       //waits for zybo to send back a value.
                    rawOutput.Add(rawVal);
                    Conversion = Convert.ToDouble(rawVal) / 325000000;
                    convOutput.Add(Convert.ToString(Conversion));
                    serialPort.Close();

                    progressBar1.PerformStep();                           //Increments the progress bar.
                }

                //displays a textbox if the computer has an issue talking to the zybo.
                catch
                {
                    MessageBox.Show("Could not connect to the serial port.", "Midterm", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    LongTestButton.Enabled = true;
                    return;
                }
            }

            //Opens a second form for the user to review before submitting the data.
            Form2 fr = new Form2();

            //Moves the variables in this form to the second one.
            fr.DelayInput = delayInput;
            fr.RawOutput  = rawOutput;
            fr.ConvOutput = convOutput;
            fr.PersonName = personBox.Text;
            fr.TestType   = "int";
            fr.Show();                         //Shows the second form.

            LongTestButton.Enabled = true;
        }

        private void shortTestButton_Click(object sender, EventArgs e)
        {
            shortTestButton.Enabled = false;

            //Prevents user from inputting the incorrect name format into the program.
            if (personBox.Text.Length != 3)
            {
                MessageBox.Show("What part of \"Three Letter Inintial\" wasn't clear here?", "Midterm", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                shortTestButton.Enabled = true;
                return;
            }

            //Makes sure the lists the data is going to go into are empty. This is important in the button is hit twice before a reset.
            delayInput.Clear();
            rawOutput.Clear();
            convOutput.Clear();

            string rawVal;
            double Conversion = 0;

            //Sets the data bar for the current test.
            progressBar1.Value = 0;
            progressBar1.Maximum = 65;

            //Collects all the data.
            for (uint i = 0; i < 65; i++)
            {
                try
                {
                    serialPort.Open();
                    delayInput.Add(Convert.ToString(i * 1000));
                    serialPort.WriteLine(Convert.ToString(i * 1000));  //Sends delay value to zybo.
                    rawVal = serialPort.ReadLine();                    //waits for zybo to send back a value.
                    rawOutput.Add(rawVal);
                    Conversion = Convert.ToDouble(rawVal) / 325000000;
                    convOutput.Add(Convert.ToString(Conversion));
                    serialPort.Close();

                    progressBar1.PerformStep();                        //Increments the progress bar.
                }

                //displays a textbox if the computer has an issue talking to the zybo.
                catch
                {
                    MessageBox.Show("Could not connect to the serial port.", "Midterm", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            //Opens a second form for the user to review before submitting the data.
            Form2 fr = new Form2();

            //Moves the variables in this form to the second one.
            fr.DelayInput = delayInput;
            fr.RawOutput  = rawOutput;
            fr.ConvOutput = convOutput;
            fr.PersonName = personBox.Text;
            fr.TestType   = "short int";
            fr.Show();                          //Shows the second form.

            shortTestButton.Enabled = true;
        }
    }
}
