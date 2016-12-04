/*
 * Name: Warren Barnes
 * Date: 10/26/16
 * Project: Final Project
 * Purpose: Learn C#
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace CS292FinalProject
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button click handler to create and show "Add New Record" screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            //Add_Record addRecord = new Add_Record();
            //addRecord.Show();

            using (Add_Record addRecord = new Add_Record())
            {
                addRecord.ShowDialog();

                displayMainScreenStats();
            }
        }

        /// <summary>
        /// Show form to edit a record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            EditRecord ed = new EditRecord();
            ed.ShowDialog();
            displayMainScreenStats();
        }

        /// <summary>
        /// Show form to delete a record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            DeleteRecord ed = new DeleteRecord();
            ed.ShowDialog();
            displayMainScreenStats();
        }

        /// <summary>
        /// Button click hander to create and show "View All Records" screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewAllRecords_Click(object sender, EventArgs e)
        {
            View_All_Records viewAllRecords = new View_All_Records();
            viewAllRecords.Show();
        }

        /// <summary>
        /// Button click handler to switch to line graph view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLineGraph_Click(object sender, EventArgs e)
        {
            btnLineGraph.Enabled = false;
            btnBarChart.Enabled = true;
            btnPieChart.Enabled = true;
            chtLineGraph.Visible = true;
            chtBarChart.Visible = false;
            chtPieChart.Visible = false;
        }

        /// <summary>
        /// Change chart visibility
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBarChart_Click(object sender, EventArgs e)
        {
            btnLineGraph.Enabled = true;
            btnBarChart.Enabled = false;
            btnPieChart.Enabled = true;
            chtLineGraph.Visible = false;
            chtBarChart.Visible = true;
            chtPieChart.Visible = false;
        }

        /// <summary>
        /// Change chart visibility
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPieChart_Click(object sender, EventArgs e)
        {
            btnLineGraph.Enabled = true; ;
            btnBarChart.Enabled = true;
            btnPieChart.Enabled = false;
            chtLineGraph.Visible = false;
            chtBarChart.Visible = false;
            chtPieChart.Visible = true;
        }

        /// <summary>
        /// Show main screen text stats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainScreen_Load(object sender, EventArgs e)
        {
            displayMainScreenStats();
        }

        /// <summary>
        /// Fill labels will appropriate main screen stats text
        /// </summary>
        private void displayMainScreenStats()
        {
            // TODO: This line of code loads data into the 'spendingRecordsDataSet.spendingRecords' table. You can move, or remove it, as needed.
            this.spendingRecordsTableAdapter.Fill(this.spendingRecordsDataSet.spendingRecords);
            spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter adapter = new spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter();
            try
            {
                lblTodaysDate.Text = "Today's date:" + DateTime.Now.ToString("d");
                DateTime earliest = (DateTime)adapter.EarliestRecordDate();
                lblFirstRecord.Text = "Date of first record:" + earliest.ToString("d");
                DateTime latest = (DateTime)adapter.LatestRecordDate();
                lblMostRecentRecord.Text = "Date of most recent record:" + latest.ToString("d");
                lblDaysSinceFirstRecord.Text = "Days since first record:" + (latest - earliest).TotalDays;
                lblTotalNumberOfRecords.Text = "Total number of records:" + adapter.NumberOfRecords();
                decimal max = (decimal)adapter.MaxAmount();
                lblHighestRecord.Text = "Highest record:" + max.ToString("c");
                decimal average = (decimal)adapter.AverageAmount();
                lblAverageAmount.Text = "Average amount:" + average.ToString("c");
                decimal largestByStore = (decimal)adapter.LargestStoreAmount();
                lblLargestTotalRetailer.Text = "Largest total at one retailer:" + largestByStore.ToString("c") + " (" + adapter.LargestStoreAmountString() + ")";
                decimal largestByType = (decimal)adapter.LargestTypeAmount();
                lblLargestTotalType.Text = "Largest total of one type:" + largestByType.ToString("c") + " (" + adapter.LargestTypeAmountString() + ")";
                lblStoreWithMostPurchases.Text = "Store with most purchases:" + adapter.StoreWithMostPurchases() + " (" + adapter.MostPurchasesByStore() + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please add a record to view statistics");
            }

        }

        /// <summary>
        /// Show options view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e) {
            Options options = new Options();
            options.Show();
        }

        /// <summary>
        /// Display about page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dialog
            //MessageBox box = new MessageBox("Spending Spotter\nCreated by Warren Barnes\nFall 2016\nCS292 C# Project at IPFW");
            MessageBox.Show("Spending Spotter\nCreated by Warren Barnes\nCS292 C# Project at IPFW\nFall 2016", "About");
        }

        /// <summary>
        /// Export spending records to a text file at the location of the user's choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportData_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.FileName = "Spending Output.txt";
            String path;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;

                TextWriter writer = new StreamWriter(path);

                this.spendingRecordsTableAdapter.Fill(this.spendingRecordsDataSet.spendingRecords);
                spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter adapter = new spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter();

                writer.WriteLine("Today's date:" + DateTime.Now.ToString("d"));
                DateTime earliest = (DateTime)adapter.EarliestRecordDate();
                writer.WriteLine("Date of first record:" + earliest.ToString("d"));
                DateTime latest = (DateTime)adapter.LatestRecordDate();
                writer.WriteLine("Date of most recent record:" + latest.ToString("d"));
                writer.WriteLine("Days since first record:" + (latest - earliest).TotalDays);
                writer.WriteLine("Total number of records:" + adapter.NumberOfRecords());
                decimal max = (decimal)adapter.MaxAmount();
                writer.WriteLine("Highest record:" + max.ToString("c"));
                decimal average = (decimal)adapter.AverageAmount();
                writer.WriteLine("Average amount:" + average.ToString("c"));
                decimal largestByStore = (decimal)adapter.LargestStoreAmount();
                writer.WriteLine("Largest total at one retailer:" + largestByStore.ToString("c") + " (" + adapter.LargestStoreAmountString() + ")");
                decimal largestByType = (decimal)adapter.LargestTypeAmount();
                writer.WriteLine("Largest total of one type:" + largestByType.ToString("c") + " (" + adapter.LargestTypeAmountString() + ")");
                writer.WriteLine("Store with most purchases:" + adapter.StoreWithMostPurchases() + " (" + adapter.MostPurchasesByStore() + ")");
                writer.WriteLine();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine();
                }
                writer.Close();
            }
        }
    }
}