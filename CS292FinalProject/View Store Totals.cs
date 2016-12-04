/*
 * Name: Warren Barnes
 * Date: 10/26/16
 * Project: Final Project
 * Purpose: Learn C#
 * 
 * This feature was not implemented because I could not figure out a
 * way to extract this information from the database and display it to the user
 */

using System;
using System.Windows.Forms;

namespace CS292FinalProject
{
    public partial class View_Store_Totals : Form
    {
        public View_Store_Totals()
        {


            InitializeComponent();
        }

        private void View_Store_Totals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spendingRecordsDataSet1.spendingRecords' table. You can move, or remove it, as needed.
            spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter adapter = new spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter();
            this.spendingRecordsTableAdapter.Fill(this.spendingRecordsDataSet1.spendingRecords);
        }
    }
}
