namespace CS292FinalProject
{
    partial class View_Store_Totals
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
            this.spendingRecordsDataSet = new CS292FinalProject.spendingRecordsDataSet();
            this.lstSpendingTotalsByStore = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // spendingRecordsDataSet
            // 
            this.spendingRecordsDataSet.DataSetName = "spendingRecordsDataSet";
            this.spendingRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstSpendingTotalsByStore
            // 
            this.lstSpendingTotalsByStore.FormattingEnabled = true;
            this.lstSpendingTotalsByStore.ItemHeight = 16;
            this.lstSpendingTotalsByStore.Location = new System.Drawing.Point(32, 34);
            this.lstSpendingTotalsByStore.Name = "lstSpendingTotalsByStore";
            this.lstSpendingTotalsByStore.Size = new System.Drawing.Size(650, 356);
            this.lstSpendingTotalsByStore.TabIndex = 0;
            // 
            // View_Store_Totals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 439);
            this.Controls.Add(this.lstSpendingTotalsByStore);
            this.Name = "View_Store_Totals";
            this.Text = "Spending Totals by Store";
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private spendingRecordsDataSet spendingRecordsDataSet;
        private System.Windows.Forms.ListBox lstSpendingTotalsByStore;
    }
}