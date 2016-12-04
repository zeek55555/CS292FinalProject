namespace CS292FinalProject
{
    partial class Options
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
            this.grpRemoveStoreOrPurchaseType = new System.Windows.Forms.GroupBox();
            this.btnRemovePurchaseType = new System.Windows.Forms.Button();
            this.cboRemovePurchaseType = new System.Windows.Forms.ComboBox();
            this.btnRemoveStore = new System.Windows.Forms.Button();
            this.cboRemoveStore = new System.Windows.Forms.ComboBox();
            this.grpAddStoreOrPurchaseType = new System.Windows.Forms.GroupBox();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnAddStore = new System.Windows.Forms.Button();
            this.txtAddPurchaseType = new System.Windows.Forms.TextBox();
            this.txtAddStore = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpRemoveStoreOrPurchaseType.SuspendLayout();
            this.grpAddStoreOrPurchaseType.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRemoveStoreOrPurchaseType
            // 
            this.grpRemoveStoreOrPurchaseType.Controls.Add(this.btnRemovePurchaseType);
            this.grpRemoveStoreOrPurchaseType.Controls.Add(this.cboRemovePurchaseType);
            this.grpRemoveStoreOrPurchaseType.Controls.Add(this.btnRemoveStore);
            this.grpRemoveStoreOrPurchaseType.Controls.Add(this.cboRemoveStore);
            this.grpRemoveStoreOrPurchaseType.Location = new System.Drawing.Point(43, 28);
            this.grpRemoveStoreOrPurchaseType.Name = "grpRemoveStoreOrPurchaseType";
            this.grpRemoveStoreOrPurchaseType.Size = new System.Drawing.Size(490, 122);
            this.grpRemoveStoreOrPurchaseType.TabIndex = 0;
            this.grpRemoveStoreOrPurchaseType.TabStop = false;
            this.grpRemoveStoreOrPurchaseType.Text = "Remove a Store or Purchase Type";
            // 
            // btnRemovePurchaseType
            // 
            this.btnRemovePurchaseType.Location = new System.Drawing.Point(301, 78);
            this.btnRemovePurchaseType.Name = "btnRemovePurchaseType";
            this.btnRemovePurchaseType.Size = new System.Drawing.Size(140, 23);
            this.btnRemovePurchaseType.TabIndex = 1;
            this.btnRemovePurchaseType.Text = "Remove Type";
            this.btnRemovePurchaseType.UseVisualStyleBackColor = true;
            this.btnRemovePurchaseType.Click += new System.EventHandler(this.btnRemovePurchaseType_Click);
            // 
            // cboRemovePurchaseType
            // 
            this.cboRemovePurchaseType.FormattingEnabled = true;
            this.cboRemovePurchaseType.Location = new System.Drawing.Point(39, 78);
            this.cboRemovePurchaseType.Name = "cboRemovePurchaseType";
            this.cboRemovePurchaseType.Size = new System.Drawing.Size(185, 24);
            this.cboRemovePurchaseType.TabIndex = 0;
            // 
            // btnRemoveStore
            // 
            this.btnRemoveStore.Location = new System.Drawing.Point(301, 37);
            this.btnRemoveStore.Name = "btnRemoveStore";
            this.btnRemoveStore.Size = new System.Drawing.Size(140, 23);
            this.btnRemoveStore.TabIndex = 1;
            this.btnRemoveStore.Text = "Remove Store";
            this.btnRemoveStore.UseVisualStyleBackColor = true;
            this.btnRemoveStore.Click += new System.EventHandler(this.btnRemoveStore_Click);
            // 
            // cboRemoveStore
            // 
            this.cboRemoveStore.FormattingEnabled = true;
            this.cboRemoveStore.Location = new System.Drawing.Point(39, 37);
            this.cboRemoveStore.Name = "cboRemoveStore";
            this.cboRemoveStore.Size = new System.Drawing.Size(185, 24);
            this.cboRemoveStore.TabIndex = 0;
            // 
            // grpAddStoreOrPurchaseType
            // 
            this.grpAddStoreOrPurchaseType.Controls.Add(this.btnAddType);
            this.grpAddStoreOrPurchaseType.Controls.Add(this.btnAddStore);
            this.grpAddStoreOrPurchaseType.Controls.Add(this.txtAddPurchaseType);
            this.grpAddStoreOrPurchaseType.Controls.Add(this.txtAddStore);
            this.grpAddStoreOrPurchaseType.Location = new System.Drawing.Point(43, 185);
            this.grpAddStoreOrPurchaseType.Name = "grpAddStoreOrPurchaseType";
            this.grpAddStoreOrPurchaseType.Size = new System.Drawing.Size(489, 109);
            this.grpAddStoreOrPurchaseType.TabIndex = 1;
            this.grpAddStoreOrPurchaseType.TabStop = false;
            this.grpAddStoreOrPurchaseType.Text = "Add a Store or Purchase Type";
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(301, 72);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(140, 23);
            this.btnAddType.TabIndex = 3;
            this.btnAddType.Text = "Add Type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // btnAddStore
            // 
            this.btnAddStore.Location = new System.Drawing.Point(301, 36);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(140, 23);
            this.btnAddStore.TabIndex = 2;
            this.btnAddStore.Text = "Add Store";
            this.btnAddStore.UseVisualStyleBackColor = true;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // txtAddPurchaseType
            // 
            this.txtAddPurchaseType.Location = new System.Drawing.Point(39, 73);
            this.txtAddPurchaseType.Name = "txtAddPurchaseType";
            this.txtAddPurchaseType.Size = new System.Drawing.Size(185, 22);
            this.txtAddPurchaseType.TabIndex = 1;
            // 
            // txtAddStore
            // 
            this.txtAddStore.Location = new System.Drawing.Point(39, 37);
            this.txtAddStore.Name = "txtAddStore";
            this.txtAddStore.Size = new System.Drawing.Size(185, 22);
            this.txtAddStore.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(590, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 474);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpAddStoreOrPurchaseType);
            this.Controls.Add(this.grpRemoveStoreOrPurchaseType);
            this.Name = "Options";
            this.Text = "Options";
            this.grpRemoveStoreOrPurchaseType.ResumeLayout(false);
            this.grpAddStoreOrPurchaseType.ResumeLayout(false);
            this.grpAddStoreOrPurchaseType.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRemoveStoreOrPurchaseType;
        private System.Windows.Forms.Button btnRemoveStore;
        private System.Windows.Forms.ComboBox cboRemoveStore;
        private System.Windows.Forms.GroupBox grpAddStoreOrPurchaseType;
        private System.Windows.Forms.Button btnRemovePurchaseType;
        private System.Windows.Forms.ComboBox cboRemovePurchaseType;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Button btnAddStore;
        private System.Windows.Forms.TextBox txtAddPurchaseType;
        private System.Windows.Forms.TextBox txtAddStore;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}