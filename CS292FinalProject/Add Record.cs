/*
 * Name: Warren Barnes
 * Date: 10/26/16
 * Project: Final Project
 * Purpose: Learn C#
 */

using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace CS292FinalProject
{
    public partial class Add_Record : Form
    {
        BindingList<String> stores = new BindingList<String>();
        BindingList<String> storeTypes = new BindingList<String>();

        public Add_Record()
        {
            InitializeComponent();

            populateComboBoxes("stores.dat", stores);
            populateComboBoxes("storeTypes.dat", storeTypes);

            BindingSource storeBindingSource = new BindingSource();
            storeBindingSource.DataSource = stores;
            cboStoreName.DataSource = storeBindingSource;

            BindingSource storeTypeBindingSource = new BindingSource();
            storeTypeBindingSource.DataSource = storeTypes;
            cboPurchaseType.DataSource = storeTypeBindingSource;
        }

        private bool populateComboBoxes(String filename, BindingList<String> list)
        {
            bool result;

            try
            {
                {
                    string line;

                    StreamReader file = File.OpenText(filename);
                    while ((line = file.ReadLine()) != null && line != "")
                    {
                        list.Add(line);
                    }

                    file.Close();
                }
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                StreamWriter file = File.CreateText(filename);
                file.Close();

                result = false;
            }

            return result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            String store = txtNewStore.Text;
            stores.Add(store);
            int place = 0;
            for(int i = 0; i < stores.Count; i++)
            {
                if(stores[i] == store)
                {
                    place = i;
                    break;
                }
            }
            cboStoreName.SelectedIndex = place;
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            String type = txtNewType.Text;
            storeTypes.Add(type);
            int place = 0;
            for (int i = 0; i < storeTypes.Count; i++)
            {
                if (storeTypes[i] == type)
                {
                    place = i;
                    break;
                }
            }
            cboPurchaseType.SelectedIndex = place;
        }

        private void saveComboBoxItems(object sender, FormClosingEventArgs e)
        {
            String output = "";

            for (int i = 0; i < stores.Count; i++)
            {
                output += stores[i] + "\n";
            }

            StreamWriter file1 = File.CreateText("stores.dat");
            file1.Write(output);
            file1.Close();

            output = "";

            for (int i = 0; i < storeTypes.Count; i++)
            {
                output += storeTypes[i] + "\n";
            }

            StreamWriter file2 = File.CreateText("storeTypes.dat");
            file2.Write(output);
            file2.Close();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker.Value.Date;
            double amount = 0;
            bool result = double.TryParse(txtAmount.Text, out amount);
            if (!result)
            {
                MessageBox.Show("Record could not be added due to invalid amount");
                return;
            }
            String store = cboStoreName.SelectedItem.ToString();
            String type = cboPurchaseType.SelectedItem.ToString();

            spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter adapter = new spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter();
            adapter.AddSpendingRecord(dateTime, (decimal) amount, type, store);

            lblStatus.Text = "record added with type " + type + " for " + amount.ToString("c");
        }
    }
}