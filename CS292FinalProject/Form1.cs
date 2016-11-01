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
            // TODO: This line of code loads data into the 'spendingRecordsDataSet.spendingRecords' table. You can move, or remove it, as needed.
            this.spendingRecordsTableAdapter.Fill(this.spendingRecordsDataSet.spendingRecords);

        }
    }
}