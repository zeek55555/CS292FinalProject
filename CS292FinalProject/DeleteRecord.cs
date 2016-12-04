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
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fill dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spendingRecordsDataSet.spendingRecords' table. You can move, or remove it, as needed.
            this.spendingRecordsTableAdapter.Fill(this.spendingRecordsDataSet.spendingRecords);

        }

        /// <summary>
        /// Get record ID and delete it from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter adapter = new spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter();
            adapter.DeleteRecord(id);

            this.spendingRecordsTableAdapter.Fill(this.spendingRecordsDataSet.spendingRecords);
        }
    }
}
