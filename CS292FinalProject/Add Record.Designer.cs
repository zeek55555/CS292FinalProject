﻿namespace CS292FinalProject
{
    partial class Add_Record
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cboStoreName = new System.Windows.Forms.ComboBox();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblPurchaseType = new System.Windows.Forms.Label();
            this.cboPurchaseType = new System.Windows.Forms.ComboBox();
            this.lblNewStore = new System.Windows.Forms.Label();
            this.txtNewStore = new System.Windows.Forms.TextBox();
            this.btnAddStore = new System.Windows.Forms.Button();
            this.lblNewType = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.txtNewType = new System.Windows.Forms.TextBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(28, 24);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(294, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(33, 71);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(60, 17);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(157, 68);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // cboStoreName
            // 
            this.cboStoreName.FormattingEnabled = true;
            this.cboStoreName.Location = new System.Drawing.Point(157, 125);
            this.cboStoreName.Name = "cboStoreName";
            this.cboStoreName.Size = new System.Drawing.Size(150, 24);
            this.cboStoreName.TabIndex = 3;
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Location = new System.Drawing.Point(33, 128);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(85, 17);
            this.lblStoreName.TabIndex = 4;
            this.lblStoreName.Text = "Store name:";
            // 
            // lblPurchaseType
            // 
            this.lblPurchaseType.AutoSize = true;
            this.lblPurchaseType.Location = new System.Drawing.Point(33, 234);
            this.lblPurchaseType.Name = "lblPurchaseType";
            this.lblPurchaseType.Size = new System.Drawing.Size(103, 17);
            this.lblPurchaseType.TabIndex = 5;
            this.lblPurchaseType.Text = "Purchase type:";
            // 
            // cboPurchaseType
            // 
            this.cboPurchaseType.FormattingEnabled = true;
            this.cboPurchaseType.Location = new System.Drawing.Point(157, 231);
            this.cboPurchaseType.Name = "cboPurchaseType";
            this.cboPurchaseType.Size = new System.Drawing.Size(150, 24);
            this.cboPurchaseType.TabIndex = 6;
            // 
            // lblNewStore
            // 
            this.lblNewStore.AutoSize = true;
            this.lblNewStore.Location = new System.Drawing.Point(391, 128);
            this.lblNewStore.Name = "lblNewStore";
            this.lblNewStore.Size = new System.Drawing.Size(75, 17);
            this.lblNewStore.TabIndex = 7;
            this.lblNewStore.Text = "New store:";
            // 
            // txtNewStore
            // 
            this.txtNewStore.Location = new System.Drawing.Point(480, 125);
            this.txtNewStore.Name = "txtNewStore";
            this.txtNewStore.Size = new System.Drawing.Size(182, 22);
            this.txtNewStore.TabIndex = 8;
            // 
            // btnAddStore
            // 
            this.btnAddStore.Location = new System.Drawing.Point(498, 166);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(138, 29);
            this.btnAddStore.TabIndex = 9;
            this.btnAddStore.Text = "Add store";
            this.btnAddStore.UseVisualStyleBackColor = true;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // lblNewType
            // 
            this.lblNewType.AutoSize = true;
            this.lblNewType.Location = new System.Drawing.Point(391, 234);
            this.lblNewType.Name = "lblNewType";
            this.lblNewType.Size = new System.Drawing.Size(70, 17);
            this.lblNewType.TabIndex = 10;
            this.lblNewType.Text = "New type:";
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(498, 278);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(138, 29);
            this.btnAddType.TabIndex = 12;
            this.btnAddType.Text = "Add type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // txtNewType
            // 
            this.txtNewType.Location = new System.Drawing.Point(480, 231);
            this.txtNewType.Name = "txtNewType";
            this.txtNewType.Size = new System.Drawing.Size(182, 22);
            this.txtNewType.TabIndex = 13;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(149, 340);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(158, 42);
            this.btnAddRecord.TabIndex = 14;
            this.btnAddRecord.Text = "Add record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(409, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 42);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(722, 24);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 19);
            // 
            // Add_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 428);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.txtNewType);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.lblNewType);
            this.Controls.Add(this.btnAddStore);
            this.Controls.Add(this.txtNewStore);
            this.Controls.Add(this.lblNewStore);
            this.Controls.Add(this.cboPurchaseType);
            this.Controls.Add(this.lblPurchaseType);
            this.Controls.Add(this.lblStoreName);
            this.Controls.Add(this.cboStoreName);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "Add_Record";
            this.Text = "Add Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.saveComboBoxItems);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cboStoreName;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblPurchaseType;
        private System.Windows.Forms.ComboBox cboPurchaseType;
        private System.Windows.Forms.Label lblNewStore;
        private System.Windows.Forms.TextBox txtNewStore;
        private System.Windows.Forms.Button btnAddStore;
        private System.Windows.Forms.Label lblNewType;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.TextBox txtNewType;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}