namespace CS292FinalProject
{
    partial class View_All_Records
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
            this.spendingRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spendingRecordsDataSet = new CS292FinalProject.spendingRecordsDataSet();
            this.btnClose = new System.Windows.Forms.Button();
            this.spendingRecordsTableAdapter = new CS292FinalProject.spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter();
            this.tableAdapterManager = new CS292FinalProject.spendingRecordsDataSetTableAdapters.TableAdapterManager();
            this.spendingRecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // spendingRecordsBindingSource
            // 
            this.spendingRecordsBindingSource.DataMember = "spendingRecords";
            this.spendingRecordsBindingSource.DataSource = this.spendingRecordsDataSet;
            // 
            // spendingRecordsDataSet
            // 
            this.spendingRecordsDataSet.DataSetName = "spendingRecordsDataSet";
            this.spendingRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(563, 563);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // spendingRecordsTableAdapter
            // 
            this.spendingRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.spendingRecordsTableAdapter = this.spendingRecordsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CS292FinalProject.spendingRecordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // spendingRecordsDataGridView
            // 
            this.spendingRecordsDataGridView.AutoGenerateColumns = false;
            this.spendingRecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spendingRecordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.spendingRecordsDataGridView.DataSource = this.spendingRecordsBindingSource;
            this.spendingRecordsDataGridView.Location = new System.Drawing.Point(181, 113);
            this.spendingRecordsDataGridView.Name = "spendingRecordsDataGridView";
            this.spendingRecordsDataGridView.RowTemplate.Height = 24;
            this.spendingRecordsDataGridView.Size = new System.Drawing.Size(672, 342);
            this.spendingRecordsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // View_All_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 613);
            this.Controls.Add(this.spendingRecordsDataGridView);
            this.Controls.Add(this.btnClose);
            this.Name = "View_All_Records";
            this.Text = "View_All_Records";
            this.Load += new System.EventHandler(this.View_All_Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private spendingRecordsDataSet spendingRecordsDataSet;
        private System.Windows.Forms.BindingSource spendingRecordsBindingSource;
        private spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter spendingRecordsTableAdapter;
        private spendingRecordsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView spendingRecordsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}