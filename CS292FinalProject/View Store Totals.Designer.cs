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
            this.components = new System.ComponentModel.Container();
            this.spendingRecordsDataSet = new CS292FinalProject.spendingRecordsDataSet();
            this.dgvStoreTotals = new System.Windows.Forms.DataGridView();
            this.spendingRecordsDataSet1 = new CS292FinalProject.spendingRecordsDataSet();
            this.spendingRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spendingRecordsTableAdapter = new CS292FinalProject.spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreTotals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spendingRecordsDataSet
            // 
            this.spendingRecordsDataSet.DataSetName = "spendingRecordsDataSet";
            this.spendingRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvStoreTotals
            // 
            this.dgvStoreTotals.AutoGenerateColumns = false;
            this.dgvStoreTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoreTotals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.storeDataGridViewTextBoxColumn});
            this.dgvStoreTotals.DataSource = this.spendingRecordsBindingSource;
            this.dgvStoreTotals.Location = new System.Drawing.Point(32, 35);
            this.dgvStoreTotals.Name = "dgvStoreTotals";
            this.dgvStoreTotals.RowTemplate.Height = 24;
            this.dgvStoreTotals.Size = new System.Drawing.Size(661, 363);
            this.dgvStoreTotals.TabIndex = 0;
            // 
            // spendingRecordsDataSet1
            // 
            this.spendingRecordsDataSet1.DataSetName = "spendingRecordsDataSet";
            this.spendingRecordsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spendingRecordsBindingSource
            // 
            this.spendingRecordsBindingSource.DataMember = "spendingRecords";
            this.spendingRecordsBindingSource.DataSource = this.spendingRecordsDataSet1;
            // 
            // spendingRecordsTableAdapter
            // 
            this.spendingRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // storeDataGridViewTextBoxColumn
            // 
            this.storeDataGridViewTextBoxColumn.DataPropertyName = "Store";
            this.storeDataGridViewTextBoxColumn.HeaderText = "Store";
            this.storeDataGridViewTextBoxColumn.Name = "storeDataGridViewTextBoxColumn";
            // 
            // View_Store_Totals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 439);
            this.Controls.Add(this.dgvStoreTotals);
            this.Name = "View_Store_Totals";
            this.Text = "Spending Totals by Store";
            this.Load += new System.EventHandler(this.View_Store_Totals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreTotals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private spendingRecordsDataSet spendingRecordsDataSet;
        private System.Windows.Forms.DataGridView dgvStoreTotals;
        private spendingRecordsDataSet spendingRecordsDataSet1;
        private System.Windows.Forms.BindingSource spendingRecordsBindingSource;
        private spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter spendingRecordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDataGridViewTextBoxColumn;
    }
}