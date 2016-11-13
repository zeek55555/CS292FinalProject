using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnRemoveStore_Click(object sender, EventArgs e)
        {
            int selectedIndex = cboRemoveStore.SelectedIndex;
            stores.RemoveAt(selectedIndex);
            saveComboBoxItems();
            lblStatus.Text = "Store removed";
        }

        private void btnRemovePurchaseType_Click(object sender, EventArgs e)
        {
            int selectedIndex = cboRemovePurchaseType.SelectedIndex;
            storeTypes.RemoveAt(selectedIndex);
            saveComboBoxItems();
            lblStatus.Text = "Store type removed";
        }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            String store = txtAddStore.Text;
            stores.Add(store);
            saveComboBoxItems();
            lblStatus.Text = "Store added";
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            String type = txtAddPurchaseType.Text;
            storeTypes.Add(type);
            saveComboBoxItems();
            lblStatus.Text = "Store type added";
        }
    }
}
