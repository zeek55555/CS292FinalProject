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
    public partial class View_All_Records : Form
    {
        public View_All_Records()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_All_Records_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spendingRecordsDataSet.spendingRecords' table. You can move, or remove it, as needed.
            this.spendingRecordsTableAdapter.Fill(this.spendingRecordsDataSet.spendingRecords);

        }
    }
}