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

namespace Ravikumar_Ilakkiya_Assignment4_MS806
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        // global public variable for getting all lines of transaction file
        public static List<string> listtranscation = new List<String>();
        // displaying existing stock in list through created file from form1
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader InputFile = File.OpenText("StockReport.txt");
                while (!InputFile.EndOfStream)
                {
                    TranscationDisplayListBox.Items.Add(InputFile.ReadLine());
                }
                InputFile.Close();
            }
            catch (Exception ex) { MessageBox.Show("File not available contact your manager\t" + ex); }
        }
        //search for specific transaction ID details
        private void SearchButton_Click(object sender, EventArgs e)
        {
            listtranscation.Clear(); DetailsListBox.Items.Clear();
            Form1 oldform = new Form1(); oldform.searchbyTranscation();
            try
            { 
                string searchID= SearchbyIDBox.Text;
                string TransID = "TranscationID:" + searchID;
                int val = int.Parse(SearchbyIDBox.Text);
                if (val != 0 && searchID.Length == 6)
                {
                    for (int index = 0; index < listtranscation.Count; index++)
                    {
                        if (listtranscation[index] == TransID)
                        {
                            for (int transcationvalues = index; transcationvalues <= listtranscation.Count; transcationvalues++)
                            {
                                index++;
                                if (listtranscation[transcationvalues] == "") { break; }
                                else { DetailsListBox.Items.Add(listtranscation[transcationvalues]); }
                            }
                        }
                    }
                    if (DetailsListBox.Items.Count == 0) { MessageBox.Show("Transaction does not exist"); }
                }
                else { MessageBox.Show("Enter Valid TranscationID"); }
                 }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Valid Numeric TransactionID in the textBox\t");
                Console.WriteLine(ex); SearchbyIDBox.Focus();
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

