﻿namespace CS292FinalProject
{
    partial class MainScreen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblFirstRecord = new System.Windows.Forms.Label();
            this.lblTodaysDate = new System.Windows.Forms.Label();
            this.lblMostRecentRecord = new System.Windows.Forms.Label();
            this.lblDaysSinceFirstRecord = new System.Windows.Forms.Label();
            this.lblTotalNumberOfRecords = new System.Windows.Forms.Label();
            this.lblHighestRecord = new System.Windows.Forms.Label();
            this.lblAverageAmount = new System.Windows.Forms.Label();
            this.lblLargestTotalRetailer = new System.Windows.Forms.Label();
            this.lblLargestTotalType = new System.Windows.Forms.Label();
            this.lblStoreWithMostPurchases = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chtLineGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.spendingRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spendingRecordsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spendingRecordsDataSet = new CS292FinalProject.spendingRecordsDataSet();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnViewAllRecords = new System.Windows.Forms.Button();
            this.btnLineGraph = new System.Windows.Forms.Button();
            this.chtBarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBarChart = new System.Windows.Forms.Button();
            this.btnPieChart = new System.Windows.Forms.Button();
            this.chtPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEditRecord = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.spendingRecordsTableAdapter = new CS292FinalProject.spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter();
            this.btnExportData = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtLineGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtBarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtPieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstRecord
            // 
            this.lblFirstRecord.AutoSize = true;
            this.lblFirstRecord.Location = new System.Drawing.Point(34, 71);
            this.lblFirstRecord.Name = "lblFirstRecord";
            this.lblFirstRecord.Size = new System.Drawing.Size(130, 17);
            this.lblFirstRecord.TabIndex = 0;
            this.lblFirstRecord.Text = "Date of first record:";
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Location = new System.Drawing.Point(34, 43);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(94, 17);
            this.lblTodaysDate.TabIndex = 1;
            this.lblTodaysDate.Text = "Today\'s date:";
            // 
            // lblMostRecentRecord
            // 
            this.lblMostRecentRecord.AutoSize = true;
            this.lblMostRecentRecord.Location = new System.Drawing.Point(34, 106);
            this.lblMostRecentRecord.Name = "lblMostRecentRecord";
            this.lblMostRecentRecord.Size = new System.Drawing.Size(181, 17);
            this.lblMostRecentRecord.TabIndex = 2;
            this.lblMostRecentRecord.Text = "Date of most recent record:";
            // 
            // lblDaysSinceFirstRecord
            // 
            this.lblDaysSinceFirstRecord.AutoSize = true;
            this.lblDaysSinceFirstRecord.Location = new System.Drawing.Point(34, 139);
            this.lblDaysSinceFirstRecord.Name = "lblDaysSinceFirstRecord";
            this.lblDaysSinceFirstRecord.Size = new System.Drawing.Size(153, 17);
            this.lblDaysSinceFirstRecord.TabIndex = 3;
            this.lblDaysSinceFirstRecord.Text = "Days since first record:";
            // 
            // lblTotalNumberOfRecords
            // 
            this.lblTotalNumberOfRecords.AutoSize = true;
            this.lblTotalNumberOfRecords.Location = new System.Drawing.Point(34, 177);
            this.lblTotalNumberOfRecords.Name = "lblTotalNumberOfRecords";
            this.lblTotalNumberOfRecords.Size = new System.Drawing.Size(164, 17);
            this.lblTotalNumberOfRecords.TabIndex = 4;
            this.lblTotalNumberOfRecords.Text = "Total number of records:";
            // 
            // lblHighestRecord
            // 
            this.lblHighestRecord.AutoSize = true;
            this.lblHighestRecord.Location = new System.Drawing.Point(34, 212);
            this.lblHighestRecord.Name = "lblHighestRecord";
            this.lblHighestRecord.Size = new System.Drawing.Size(105, 17);
            this.lblHighestRecord.TabIndex = 5;
            this.lblHighestRecord.Text = "Highest record:";
            // 
            // lblAverageAmount
            // 
            this.lblAverageAmount.AutoSize = true;
            this.lblAverageAmount.Location = new System.Drawing.Point(34, 246);
            this.lblAverageAmount.Name = "lblAverageAmount";
            this.lblAverageAmount.Size = new System.Drawing.Size(116, 17);
            this.lblAverageAmount.TabIndex = 6;
            this.lblAverageAmount.Text = "Average amount:";
            // 
            // lblLargestTotalRetailer
            // 
            this.lblLargestTotalRetailer.AutoSize = true;
            this.lblLargestTotalRetailer.Location = new System.Drawing.Point(34, 281);
            this.lblLargestTotalRetailer.Name = "lblLargestTotalRetailer";
            this.lblLargestTotalRetailer.Size = new System.Drawing.Size(183, 17);
            this.lblLargestTotalRetailer.TabIndex = 7;
            this.lblLargestTotalRetailer.Text = "Largest total at one retailer:";
            // 
            // lblLargestTotalType
            // 
            this.lblLargestTotalType.AutoSize = true;
            this.lblLargestTotalType.Location = new System.Drawing.Point(34, 316);
            this.lblLargestTotalType.Name = "lblLargestTotalType";
            this.lblLargestTotalType.Size = new System.Drawing.Size(166, 17);
            this.lblLargestTotalType.TabIndex = 8;
            this.lblLargestTotalType.Text = "Largest total of one type:";
            // 
            // lblStoreWithMostPurchases
            // 
            this.lblStoreWithMostPurchases.AutoSize = true;
            this.lblStoreWithMostPurchases.Location = new System.Drawing.Point(34, 354);
            this.lblStoreWithMostPurchases.Name = "lblStoreWithMostPurchases";
            this.lblStoreWithMostPurchases.Size = new System.Drawing.Size(178, 17);
            this.lblStoreWithMostPurchases.TabIndex = 9;
            this.lblStoreWithMostPurchases.Text = "Store with most purchases:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.optionsToolStripMenuItem1.Text = "Options";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // chtLineGraph
            // 
            chartArea7.Name = "ChartArea1";
            this.chtLineGraph.ChartAreas.Add(chartArea7);
            this.chtLineGraph.DataSource = this.spendingRecordsBindingSource;
            legend7.Name = "Legend1";
            this.chtLineGraph.Legends.Add(legend7);
            this.chtLineGraph.Location = new System.Drawing.Point(389, 42);
            this.chtLineGraph.Name = "chtLineGraph";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series7.XValueMember = "Date";
            series7.YValueMembers = "Amount";
            series7.YValuesPerPoint = 2;
            this.chtLineGraph.Series.Add(series7);
            this.chtLineGraph.Size = new System.Drawing.Size(727, 508);
            this.chtLineGraph.TabIndex = 11;
            this.chtLineGraph.Text = "Line Graph";
            this.chtLineGraph.Visible = false;
            // 
            // spendingRecordsBindingSource
            // 
            this.spendingRecordsBindingSource.DataMember = "spendingRecords";
            this.spendingRecordsBindingSource.DataSource = this.spendingRecordsDataSetBindingSource;
            // 
            // spendingRecordsDataSetBindingSource
            // 
            this.spendingRecordsDataSetBindingSource.DataSource = this.spendingRecordsDataSet;
            this.spendingRecordsDataSetBindingSource.Position = 0;
            // 
            // spendingRecordsDataSet
            // 
            this.spendingRecordsDataSet.DataSetName = "spendingRecordsDataSet";
            this.spendingRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(42, 427);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(121, 44);
            this.btnAddRecord.TabIndex = 12;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnViewAllRecords
            // 
            this.btnViewAllRecords.Location = new System.Drawing.Point(200, 492);
            this.btnViewAllRecords.Name = "btnViewAllRecords";
            this.btnViewAllRecords.Size = new System.Drawing.Size(121, 44);
            this.btnViewAllRecords.TabIndex = 13;
            this.btnViewAllRecords.Text = "View All Records";
            this.btnViewAllRecords.UseVisualStyleBackColor = true;
            this.btnViewAllRecords.Click += new System.EventHandler(this.btnViewAllRecords_Click);
            // 
            // btnLineGraph
            // 
            this.btnLineGraph.Location = new System.Drawing.Point(439, 580);
            this.btnLineGraph.Name = "btnLineGraph";
            this.btnLineGraph.Size = new System.Drawing.Size(140, 38);
            this.btnLineGraph.TabIndex = 14;
            this.btnLineGraph.Text = "Line Graph";
            this.btnLineGraph.UseVisualStyleBackColor = true;
            this.btnLineGraph.Click += new System.EventHandler(this.btnLineGraph_Click);
            // 
            // chtBarChart
            // 
            chartArea8.Name = "ChartArea1";
            this.chtBarChart.ChartAreas.Add(chartArea8);
            this.chtBarChart.DataSource = this.spendingRecordsBindingSource;
            legend8.Name = "Legend1";
            this.chtBarChart.Legends.Add(legend8);
            this.chtBarChart.Location = new System.Drawing.Point(389, 42);
            this.chtBarChart.Name = "chtBarChart";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            series8.XValueMember = "Date";
            series8.YValueMembers = "Amount";
            series8.YValuesPerPoint = 10;
            this.chtBarChart.Series.Add(series8);
            this.chtBarChart.Size = new System.Drawing.Size(726, 507);
            this.chtBarChart.TabIndex = 15;
            this.chtBarChart.Text = "Bar Chart";
            // 
            // btnBarChart
            // 
            this.btnBarChart.Enabled = false;
            this.btnBarChart.Location = new System.Drawing.Point(628, 580);
            this.btnBarChart.Name = "btnBarChart";
            this.btnBarChart.Size = new System.Drawing.Size(140, 38);
            this.btnBarChart.TabIndex = 16;
            this.btnBarChart.Text = "Bar Chart";
            this.btnBarChart.UseVisualStyleBackColor = true;
            this.btnBarChart.Click += new System.EventHandler(this.btnBarChart_Click);
            // 
            // btnPieChart
            // 
            this.btnPieChart.Location = new System.Drawing.Point(815, 580);
            this.btnPieChart.Name = "btnPieChart";
            this.btnPieChart.Size = new System.Drawing.Size(140, 38);
            this.btnPieChart.TabIndex = 17;
            this.btnPieChart.Text = "Pie Chart";
            this.btnPieChart.UseVisualStyleBackColor = true;
            this.btnPieChart.Click += new System.EventHandler(this.btnPieChart_Click);
            // 
            // chtPieChart
            // 
            chartArea9.Name = "ChartArea1";
            this.chtPieChart.ChartAreas.Add(chartArea9);
            this.chtPieChart.DataSource = this.spendingRecordsBindingSource;
            legend9.Name = "Legend1";
            this.chtPieChart.Legends.Add(legend9);
            this.chtPieChart.Location = new System.Drawing.Point(389, 42);
            this.chtPieChart.Name = "chtPieChart";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            series9.XValueMember = "Type";
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series9.YValueMembers = "Amount";
            series9.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chtPieChart.Series.Add(series9);
            this.chtPieChart.Size = new System.Drawing.Size(727, 508);
            this.chtPieChart.TabIndex = 18;
            this.chtPieChart.Text = "Pie Chart";
            this.chtPieChart.Visible = false;
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Location = new System.Drawing.Point(42, 492);
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(121, 44);
            this.btnEditRecord.TabIndex = 19;
            this.btnEditRecord.Text = "Edit Record";
            this.btnEditRecord.UseVisualStyleBackColor = true;
            this.btnEditRecord.Click += new System.EventHandler(this.btnEditRecord_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(42, 559);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(121, 44);
            this.btnDeleteRecord.TabIndex = 20;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // spendingRecordsTableAdapter
            // 
            this.spendingRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // btnExportData
            // 
            this.btnExportData.Location = new System.Drawing.Point(200, 559);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(121, 44);
            this.btnExportData.TabIndex = 21;
            this.btnExportData.Text = "Export Data";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.storeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spendingRecordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(450, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 395);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.Visible = false;
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
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 641);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnEditRecord);
            this.Controls.Add(this.chtPieChart);
            this.Controls.Add(this.btnPieChart);
            this.Controls.Add(this.btnBarChart);
            this.Controls.Add(this.chtBarChart);
            this.Controls.Add(this.btnLineGraph);
            this.Controls.Add(this.btnViewAllRecords);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.chtLineGraph);
            this.Controls.Add(this.lblStoreWithMostPurchases);
            this.Controls.Add(this.lblLargestTotalType);
            this.Controls.Add(this.lblLargestTotalRetailer);
            this.Controls.Add(this.lblAverageAmount);
            this.Controls.Add(this.lblHighestRecord);
            this.Controls.Add(this.lblTotalNumberOfRecords);
            this.Controls.Add(this.lblDaysSinceFirstRecord);
            this.Controls.Add(this.lblMostRecentRecord);
            this.Controls.Add(this.lblTodaysDate);
            this.Controls.Add(this.lblFirstRecord);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.Text = "Spending Spotter";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtLineGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtBarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtPieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstRecord;
        private System.Windows.Forms.Label lblTodaysDate;
        private System.Windows.Forms.Label lblMostRecentRecord;
        private System.Windows.Forms.Label lblDaysSinceFirstRecord;
        private System.Windows.Forms.Label lblTotalNumberOfRecords;
        private System.Windows.Forms.Label lblHighestRecord;
        private System.Windows.Forms.Label lblAverageAmount;
        private System.Windows.Forms.Label lblLargestTotalRetailer;
        private System.Windows.Forms.Label lblLargestTotalType;
        private System.Windows.Forms.Label lblStoreWithMostPurchases;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnViewAllRecords;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnLineGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtBarChart;
        private System.Windows.Forms.Button btnBarChart;
        private System.Windows.Forms.Button btnPieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtPieChart;
        private System.Windows.Forms.Button btnEditRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
        private spendingRecordsDataSet spendingRecordsDataSet;
        private System.Windows.Forms.BindingSource spendingRecordsDataSetBindingSource;
        private spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter spendingRecordsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.BindingSource spendingRecordsBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtLineGraph;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeDataGridViewTextBoxColumn;
    }
}

