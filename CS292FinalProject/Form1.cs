/*
 * Name: Warren Barnes
 * Date: 10/26/16
 * Project: Final Project
 * Purpose: Learn C#
 */

using System;
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
            Add_Record addRecord = new Add_Record();
            addRecord.Show();
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

        private void btnBarChart_Click(object sender, EventArgs e)
        {
            btnLineGraph.Enabled = true;
            btnBarChart.Enabled = false;
            btnPieChart.Enabled = true;
            chtLineGraph.Visible = false;
            chtBarChart.Visible = true;
            chtPieChart.Visible = false;
        }

        private void btnPieChart_Click(object sender, EventArgs e)
        {
            btnLineGraph.Enabled = true; ;
            btnBarChart.Enabled = true;
            btnPieChart.Enabled = false;
            chtLineGraph.Visible = false;
            chtBarChart.Visible = false;
            chtPieChart.Visible = true;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            displayMainScreenStats();
        }

        private void displayMainScreenStats()
        {
            // TODO: This line of code loads data into the 'spendingRecordsDataSet.spendingRecords' table. You can move, or remove it, as needed.
            this.spendingRecordsTableAdapter.Fill(this.spendingRecordsDataSet.spendingRecords);
            spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter adapter = new spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter();

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

            //TODO: Call this method every time we go to this view from a place the data could have been changed
        }


        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e) {
            Options options = new Options();
            options.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dialog
            //MessageBox box = new MessageBox("Spending Spotter\nCreated by Warren Barnes\nFall 2016\nCS292 C# Project at IPFW");
            MessageBox.Show("Spending Spotter\nCreated by Warren Barnes\nCS292 C# Project at IPFW\nFall 2016", "About");
        }

        private void btnViewStoreTotals_Click(object sender, EventArgs e)
        {
            View_Store_Totals viewStoreTotals = new View_Store_Totals();
            viewStoreTotals.Show();
        }
    }
}