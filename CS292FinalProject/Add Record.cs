/*
 * Name: Warren Barnes
 * Date: 10/26/16
 * Project: Final Project
 * Purpose: Learn C#
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS292FinalProject
{
    public partial class Add_Record : Form
    {
        List<String> stores = new List<String>();
        List<string> purchaseCatergories = new List<String>();

        public Add_Record()
        {
            InitializeComponent();
            cboStoreName.Items.Add("Kroger");
            cboStoreName.Items.Add("Best Buy");
            cboStoreName.Items.Add("Amazon");
            cboPurchaseType.Items.Add("Grocieries");
            cboPurchaseType.Items.Add("Electronics");
            cboPurchaseType.Items.Add("Car parts");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}