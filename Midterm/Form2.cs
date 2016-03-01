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
    public partial class Form2 : Form
    {
        private List<string> delayInput = new List<string>();
        private List<string> rawOutput = new List<string>();
        private List<string> convOutput = new List<string>();
        private string name;
        private string testType;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //When the form loads this table is populated with all the data collected earlier. 
            for (int i = 0; i < delayInput.Count; i++)  //delayInput.Count is used out of simplicity. All the list should be the same length.
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = delayInput[i];
                dataGridView1.Rows[i].Cells[1].Value = rawOutput[i];
                dataGridView1.Rows[i].Cells[2].Value = convOutput[i];
            }
        }

        /*
         These properties are used to move the lists holding all the data in the first form into this class.
         */
        public List<string> DelayInput
        {
            set { delayInput = value; }
        }

        public List<string> RawOutput
        {
            set { rawOutput = value; }
        }

        public List<string> ConvOutput
        {
            set { convOutput = value; }
        }

        public string PersonName
        {
            set { name = value; }
        }

        public string TestType
        {
            set { testType = value; }
        }

        //If the user likes the data, this uploads it to the SQL server.
        private void submitData_Click(object sender, EventArgs e)
        {
            submitData.Enabled = false;
            for (int i = 0; i < delayInput.Count; i++) //delayInput.Count is used out of simplicity. All the list should be the same length.
            {
                DataClasses1DataContext Midterm = new DataClasses1DataContext();
                EET321_2_Mon Data = new EET321_2_Mon();

                Data.DateTime = DateTime.Now;
                Data.Person = name;
                Data.A = delayInput[i];
                Data.B = rawOutput[i];
                Data.C = convOutput[i];
                Data.D = testType;
                Data.E = "N/A";
                Data.F = "N/A";

                Midterm.EET321_2_Mons.InsertOnSubmit(Data);
                Midterm.SubmitChanges();
                System.Threading.Thread.Sleep(100);
            }
            submitData.Enabled = true;
            MessageBox.Show("Data uploaded sucessfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        //If the user didn't like the data collected, this exits the form without writing anything to the server.
        private void cancelData_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
