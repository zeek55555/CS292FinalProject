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
    public partial class EditRecord : Form
    {
        public EditRecord()
        {
            InitializeComponent();
        }

        private void EditRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spendingRecordsDataSet.spendingRecords' table. You can move, or remove it, as needed.
            this.spendingRecordsTableAdapter.Fill(this.spendingRecordsDataSet.spendingRecords);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            DateTime dateTime = dateTimePicker.Value.Date;
            double amount = Double.Parse(txtAmount.Text);
            String type = txtType.Text;
            String store = txtStore.Text;

            spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter adapter = new spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter();
            adapter.UpdateRecord(dateTime, (decimal)amount, type, store, id);
            this.spendingRecordsTableAdapter.Fill(this.spendingRecordsDataSet.spendingRecords);

        }
    }
}
