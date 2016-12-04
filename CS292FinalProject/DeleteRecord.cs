using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS292FinalProject
{
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }

        private void DeleteRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spendingRecordsDataSet.spendingRecords' table. You can move, or remove it, as needed.
            this.spendingRecordsTableAdapter.Fill(this.spendingRecordsDataSet.spendingRecords);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter adapter = new spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter();
            adapter.DeleteRecord(id);

            this.spendingRecordsTableAdapter.Fill(this.spendingRecordsDataSet.spendingRecords);
        }
    }
}
