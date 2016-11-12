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
            stores.Add(txtNewStore.Text);
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            storeTypes.Add(txtNewType.Text);
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
    }
}