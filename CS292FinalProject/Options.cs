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
    public partial class Options : Form
    {
        BindingList<String> stores = new BindingList<String>();
        BindingList<String> storeTypes = new BindingList<String>();

        public Options()
        {
            InitializeComponent();

            populateComboBoxes("stores.dat", stores);
            populateComboBoxes("storeTypes.dat", storeTypes);

            BindingSource storeBindingSource = new BindingSource();
            storeBindingSource.DataSource = stores;
            cboRemoveStore.DataSource = storeBindingSource;

            BindingSource storeTypeBindingSource = new BindingSource();
            storeTypeBindingSource.DataSource = storeTypes;
            cboRemovePurchaseType.DataSource = storeTypeBindingSource;
        }

        /// <summary>
        /// Fill combo boxes with store and category options
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="list"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Remove store from combo box options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveStore_Click(object sender, EventArgs e)
        {
            int selectedIndex = cboRemoveStore.SelectedIndex;
            stores.RemoveAt(selectedIndex);
            saveComboBoxItems();
            lblStatus.Text = "Store removed";
        }

        /// <summary>
        /// Remove category from purchase type options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemovePurchaseType_Click(object sender, EventArgs e)
        {
            int selectedIndex = cboRemovePurchaseType.SelectedIndex;
            storeTypes.RemoveAt(selectedIndex);
            saveComboBoxItems();
            lblStatus.Text = "Store type removed";
        }

        /// <summary>
        /// Save current combo box options to files
        /// </summary>
        private void saveComboBoxItems()
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

        /// <summary>
        /// Exit this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Add a store to store combo box options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStore_Click(object sender, EventArgs e)
        {
            String store = txtAddStore.Text;
            stores.Add(store);
            saveComboBoxItems();
            lblStatus.Text = "Store added";
        }

        /// <summary>
        /// Add type to combo box options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddType_Click(object sender, EventArgs e)
        {
            String type = txtAddPurchaseType.Text;
            storeTypes.Add(type);
            saveComboBoxItems();
            lblStatus.Text = "Store type added";
        }
    }
}
