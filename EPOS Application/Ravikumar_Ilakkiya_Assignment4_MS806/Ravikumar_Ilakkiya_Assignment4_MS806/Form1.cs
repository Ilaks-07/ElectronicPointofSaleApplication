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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declaring global variables
        List<string> toynames = new List<string>()
            {"Thor","Hulk","Spidey","Captain","Groot","Storm","Thanos","Hela","Ironman","Cable","MystiQ","Scarlet","Luna"};
        List<string> toytype = new List<string>()
            {"Mini Figures","Collectibles","Bobble Head","Plush","Electronic"};
        decimal[,] prices = { { 140, 340, 165, 125, 180 },
                                  { 125, 325, 150, 110, 195 },
                                  { 105, 305, 130, 90, 145 },
                                  { 100, 300, 125, 85, 140 },
                                  { 95, 295, 120, 80, 135 },
                                  { 110, 310, 135, 95, 150 },
                                  { 135, 335, 160, 120, 175 },
                                  { 140, 340, 165, 125, 180 },
                                  {  100, 300, 125, 85, 140 },
                                  { 148, 348, 173, 133, 188 },
                                  { 200, 400, 225, 185, 240 },
                                  { 95, 295, 120, 80, 135 },
                                  { 130, 330, 155, 115, 170 } };
        decimal[] giftcard = { 3, 2, 1, 0 };
        decimal numberoftoys;
        int[,] OriginalStock = { {35, 10, 40, 45, 20 },
                                  { 25, 5, 15, 10, 19 },
                                  { 15, 35, 13, 9, 15 },
                                  { 10, 30, 25, 35, 10 },
                                  { 95, 25, 20, 80, 15 },
                                  { 41, 31, 50, 43, 32 },
                                  { 41, 21, 51, 33, 4 },
                                  { 19, 34, 43, 32, 37 },
                                  {  27, 12, 29, 37, 46 },
                                  { 29, 22, 15, 18, 16 },
                                  { 49, 41, 37, 47, 16 },
                                  { 21, 12, 48, 26, 26 },
                                  { 25, 16, 17, 18, 15 } };

        int[,] soldstock = new int[13, 5]; int[] stockvalues = new int[65];
        //calling function to get stock values on loading of the main form
        private void Form1_Load(object sender, EventArgs e)
        {
            checkNumber();
        }
        // global variable for stock value
        int[,] livecountofstock = new int[13, 5];
        // fetching stock values
        private void checkNumber()
        {
            if (File.Exists("Closing_Stock.txt"))
            {
                try
                {
                    StreamReader Outputfile = File.OpenText("Closing_Stock.txt");
                    for (int i = 0; i <= 64; i++)
                    { stockvalues[i] = int.Parse(Outputfile.ReadLine()); Console.WriteLine(stockvalues[i]); }
                    int s = 0;
                    for (int x = 0; x <= 12; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            livecountofstock[x, y] = stockvalues[s]; s++;
                            soldstock[x, y] = 0;
                            Console.WriteLine(livecountofstock[x, y]);
                        }
                    }
                    dummystockvalue = (int[,])this.livecountofstock.Clone(); Outputfile.Close();
                }
                catch (Exception ex) { MessageBox.Show("Cannot Read File of last transcation day\n" + ex.Message); }
            }
            else
            { livecountofstock = (int[,])this.OriginalStock.Clone(); }
            dummystockvalue = (int[,])this.livecountofstock.Clone();
        }
        // Enabling price panel when both item and type are selected
        private void TypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal giftwrapvalue;
            if (ToyListBox.SelectedIndex != -1)
            {
                if (TypeListBox.SelectedIndex != -1)
                {
                    giftwrapvalue = GiftWrapOption();
                    PricePanel.Enabled = true;
                    numberoftoys = QtyNumericUpDown.Value;
                    //displaying price according to the selected values
                    PriceLabel.Text = "€ " + ((numberoftoys * prices[ToyListBox.SelectedIndex, TypeListBox.SelectedIndex]) + (giftwrapvalue * numberoftoys)).ToString();
                    AddtoCartButton.Focus();
                }
            }
        }
        private void ToyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeListBox_SelectedIndexChanged(sender, e);
        }
        private void QtyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TypeListBox_SelectedIndexChanged(sender, e);
        }
        string giftwrap;
        // optional giftwrap value if selected
        public decimal GiftWrapOption()
        {
            decimal giftwraprate;
            if (GiftWrapRadioButton3.Checked) { giftwraprate = giftcard[0]; NoThanksRadioButton.Visible = true; giftwrap = "fabric"; }
            else if (GiftWrapRadioButton2.Checked) { giftwraprate = giftcard[1]; NoThanksRadioButton.Visible = true; giftwrap = "photo"; }
            else if (GiftWrapRadioButton1.Checked) { giftwraprate = giftcard[2]; NoThanksRadioButton.Visible = true; giftwrap = "chalkboard"; }
            else { giftwraprate = giftcard[3]; giftwrap = "none"; }
            return giftwraprate;
        }
        private void GiftWrapRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            TypeListBox_SelectedIndexChanged(sender, e);
            NoThanksRadioButton.Visible = true;
        }
        private void GiftWrapRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TypeListBox_SelectedIndexChanged(sender, e);
            NoThanksRadioButton.Visible = true;
        }
        private void GiftWrapRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TypeListBox_SelectedIndexChanged(sender, e);
            NoThanksRadioButton.Visible = true;
        }
        //global dummy stock value for Toy Panel
        int[,] dummystockvalue = new int[12, 4];
        // Adding to Cart List view 
        private void AddtoCartButton_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numberoftoys);
            if (dummystockvalue[ToyListBox.SelectedIndex, TypeListBox.SelectedIndex] >= quantity)
            {
                dummystockvalue[ToyListBox.SelectedIndex, TypeListBox.SelectedIndex] = dummystockvalue[ToyListBox.SelectedIndex, TypeListBox.SelectedIndex] - quantity;
                CartDetailLabel.Visible = true; CartPanel.Visible = true;
               int value = UniqueTranscationID();
                if (TransactionLabel.Text == "") { TransactionLabel.Text = value.ToString("D6"); }
                else { Console.WriteLine("TransactionID Already Generated"); }
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(toynames[ToyListBox.SelectedIndex]);
                item.SubItems.Add(toytype[TypeListBox.SelectedIndex]);
                item.SubItems.Add(giftwrap);
                item.SubItems.Add(QtyNumericUpDown.Value.ToString());
                item.SubItems.Add(PriceLabel.Text);
                CartListView.Items.Add(item);
                CheckOutButton.Focus();
            }
            else
            {
                string toy = ToyListBox.SelectedItem.ToString(); toy = toy.Substring(0, toy.IndexOf("\t"));
                string make = TypeListBox.SelectedItem.ToString(); make = make.Substring(0, make.IndexOf("\t"));
                string errormessage = "For " + toy + " Toy, only " + dummystockvalue[ToyListBox.SelectedIndex, TypeListBox.SelectedIndex].ToString() + " stock(s) are available right now for the make " + make;
                MessageBox.Show(errormessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Generating unique six digit transaction ID
        private int UniqueTranscationID() {
            Random rand = new Random();
            int value = rand.Next(0, 999999);
            string checkUniqueness = "TranscationID:" + value.ToString(); ;
            try
            {
                StreamReader Outputfile = new StreamReader("individualsaletranscationdetails.txt");
                while (!Outputfile.EndOfStream)
                {
                    string temp = Outputfile.ReadLine();
                    temp = "TranscationID:" + temp;
                    if (temp != checkUniqueness) { Console.WriteLine("Searching for repeated TranscationID"); }
                    else { value = UniqueTranscationID(); };
                }
                Outputfile.Close();
            }
            catch (Exception ex) { Console.WriteLine("TranscationFile Does Not Exist at the moment\t"+ex); };
            return value;
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
                foreach (ListViewItem item in CartListView.SelectedItems)
                {
                    string temptoy = item.SubItems[1].Text;
                    string tempmake = item.SubItems[2].Text;
                    int positionoftemptoy = toynames.IndexOf(temptoy);
                    int positionoftempmake = toytype.IndexOf(tempmake);
                    int quantity = int.Parse(item.SubItems[4].Text);
                    dummystockvalue[positionoftemptoy, positionoftempmake] = dummystockvalue[positionoftemptoy, positionoftempmake] + quantity;
                    CartListView.Items.Remove(item);
                    RemoveButton.Focus();
                if (CartListView.Items.Count == 0) { MessageBox.Show("Cart is empty"); CartPanel.Visible = false;CartDetailLabel.Visible = false; }
                else { Console.WriteLine("Items Still Available"); }
            }
        }
        // exit button and calling daily sales method for displaying eod sales
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DailySalesReportButton_Click(sender, e);
            this.Close();
        }
        // clear method for clearing and resetting values excluding the sold stock values
        private void ClearButton_Click(object sender, EventArgs e)
        {
            CartPanel.Visible = false;
            CartDetailLabel.Visible = false;
            CartListView.Items.Clear();
            ToyListBox.SelectedIndex = -1;
            TypeListBox.SelectedIndex = -1;
            GiftWrapRadioButton3.Checked = false;
            GiftWrapRadioButton2.Checked = false;
            GiftWrapRadioButton1.Checked = false;
            NoThanksRadioButton.Visible = false;
            QtyNumericUpDown.Value = 1;
            PriceLabel.Text = "";
            TransactionLabel.Text = "";
            PricePanel.Enabled = false;
            if (CartListView != null)
            {
                for (int x = 0; x <= 12; x++)
                { for (int y = 0; y <= 4; y++) { 
                        dummystockvalue[x, y] = livecountofstock[x, y];
                } }
            }
            else { Console.WriteLine("No values in listview"); }
        }
        // check out method and updating the live stock count accordingly
        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            int[,] dummysoldstock = new int[13, 5];
            decimal TotalQuantity = 0m, TotalPrice = 0m;
            if (CartListView.Items != null)
            {
                StringBuilder MessageText = new StringBuilder();
                MessageText.AppendLine(string.Format("Check the Items below:"));
                for (int i = 0; i < CartListView.Items.Count; i++)
                {
                    MessageText.AppendLine(string.Format("\nItem:\t\t {0}", CartListView.Items[i].SubItems[1].Text));
                    MessageText.AppendLine(string.Format("Type:\t\t {0}", CartListView.Items[i].SubItems[2].Text));
                    MessageText.AppendLine(string.Format("Quantity:\t\t {0}", CartListView.Items[i].SubItems[4].Text));
                    MessageText.AppendLine(string.Format("Price:\t\t {0}", CartListView.Items[i].SubItems[5].Text));
                    string pricestr = CartListView.Items[i].SubItems[5].Text;
                    TotalQuantity += decimal.Parse(CartListView.Items[i].SubItems[4].Text);
                    TotalPrice += decimal.Parse(pricestr.Substring(2));
                }
                MessageText.AppendLine(string.Format("\nTotal Cost:\t {0}", "€ " + TotalPrice));
                MessageText.AppendLine(string.Format("Total Quantity:\t {0}", TotalQuantity));
                if (MessageBox.Show(MessageText.ToString(), "Are you sure you want to proceed?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //saving transaction to file
                    try
                    {
                        DateTime getdate = DateTime.Now;
                        StreamWriter OutputFile = File.AppendText("individualsaletranscationdetails.txt");
                        OutputFile.WriteLine("\nTime Stamp --- " + getdate);
                        OutputFile.WriteLine("TranscationID:" + TransactionLabel.Text);
                        for (int x = 0; x <= 12; x++)
                        {
                            for (int y = 0; y <= 4; y++)
                            {
                                soldstock[x, y] += (livecountofstock[x, y] - dummystockvalue[x, y]);
                                dummysoldstock[x, y] = (livecountofstock[x, y] - dummystockvalue[x, y]);
                                if (dummysoldstock[x, y] != 0) { OutputFile.WriteLine(toynames[x] + "--" + toytype[y] + "--" + dummysoldstock[x, y]); }
                                else { Console.WriteLine(toynames[x] + "of type " + toytype[y] + "was not sold in this transcation"); }
                            }
                        }
                        OutputFile.WriteLine("Sale Value:" + TotalPrice); OutputFile.WriteLine();
                        OutputFile.Close(); //System.Diagnostics.Process.Start("notepad.exe", "individualsaletranscationdetails.txt").WaitForExit();
                    }
                    catch (Exception ex) { MessageBox.Show("Error unable to save file contact manager\t" + ex); }
                    int s = 0;
                    for (int x = 0; x <= 12; x++)
                    {
                        for (int y = 0; y <= 4; y++)
                        {
                            livecountofstock[x, y] = dummystockvalue[x, y];
                            stockvalues[s] = livecountofstock[x, y]; s++;
                        }
                    }
                    //updating closing stock
                    try
                    {
                        StreamWriter StockFile = File.CreateText("Closing_Stock.txt"); for (int x = 0; x <= 64; x++)
                        { StockFile.WriteLine(stockvalues[x]); }
                        StockFile.Close();
                    }
                    catch (Exception ex) { MessageBox.Show("Closing Stock Report Unavailable contact Manager\t" + ex); }
                    ClearButton_Click(sender, e);
                    MessageBox.Show("Thank you for Shopping!!", "Successful");
                }
                else
                {
                    ClearButton.Focus();
                }
            }
        }
        // generating existing stock report file which is displayed in second form
        private void ReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter OutputFile = File.CreateText("StockReport.txt");
                DateTime getdate = DateTime.Now;
                OutputFile.WriteLine("Management Report -- Available Stocks\nTime Stamp --- " + getdate);
                for (int z = 0; z <= 4; z++) { OutputFile.Write("\t" + toytype[z]); }
                for (int x = 0; x <= 12; x++)
                {
                    OutputFile.WriteLine();
                    OutputFile.Write(toynames[x]);
                    for (int y = 0; y <= 4; y++)
                    {
                        OutputFile.Write("\t" + livecountofstock[x, y].ToString() + "\t");
                    }
                }
                OutputFile.Close();
                // calling second form
                Form2 newform = new Form2();
                newform.ShowDialog();
                //  System.Diagnostics.Process.Start("notepad.exe", "StockReport.txt").WaitForExit();
            }
            catch (Exception ex) { MessageBox.Show("Error Contact your manager" + ex); }
        }
        // generating daily sales report
        private void DailySalesReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalprice = 0;
                DateTime getdate = DateTime.Now;
                string today = getdate.ToString("dd-MM-yy");
                StreamWriter OutputFile = File.CreateText(today + "DailyTranscationReport.txt");
                OutputFile.WriteLine("Management Report -- Sold Stocks\nTime Stamp --- " + getdate);
                for (int z = 0; z <= 4; z++) { OutputFile.Write("\t" + toytype[z]); }
                OutputFile.Write("\tSale Value");
                for (int x = 0; x <= 12; x++)
                {
                    decimal saleperitem = 0;
                    OutputFile.WriteLine();
                    OutputFile.Write(toynames[x]);

                    for (int y = 0; y <= 4; y++)
                    {
                        OutputFile.Write("\t" + soldstock[x, y].ToString() + "\t");
                        if (soldstock[x, y] != 0) { totalprice += soldstock[x, y] * prices[x, y]; }
                        else { totalprice += 0; }
                        saleperitem += soldstock[x, y] * prices[x, y];
                    }
                    OutputFile.Write("\t" + saleperitem);
                }
                OutputFile.WriteLine("\n Total Sold Price :" + totalprice);
                OutputFile.Close();
                System.Diagnostics.Process.Start("notepad.exe", today + "DailyTranscationReport.txt").WaitForExit();
            }
            catch (Exception ex) { MessageBox.Show("Error Contact your manager\t" + ex); }
        }
        // public method for searching specific transaction 
        public void searchbyTranscation()
        {
            // values of all transactions are stored in list of form2
            try
            {
                StreamReader InputFile = File.OpenText("individualsaletranscationdetails.txt");
                while (!InputFile.EndOfStream)
                {
                            Form2.listtranscation.Add(InputFile.ReadLine());
                    }
                InputFile.Close();
            }
            catch (Exception ex) { MessageBox.Show("Transcation details file not available contact manager\t" + ex); }
        }
    }
}