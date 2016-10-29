namespace CS292FinalProject
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chtLineGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnViewAllRecords = new System.Windows.Forms.Button();
            this.btnLineGraph = new System.Windows.Forms.Button();
            this.chtBarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBarChart = new System.Windows.Forms.Button();
            this.btnPieChart = new System.Windows.Forms.Button();
            this.chtPieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEditRecord = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.spendingRecordsDataSet = new CS292FinalProject.spendingRecordsDataSet();
            this.spendingRecordsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spendingRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spendingRecordsTableAdapter = new CS292FinalProject.spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter();
            this.spendingRecordsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spendingRecordsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtLineGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtBarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtPieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstRecord
            // 
            this.lblFirstRecord.AutoSize = true;
            this.lblFirstRecord.Location = new System.Drawing.Point(34, 42);
            this.lblFirstRecord.Name = "lblFirstRecord";
            this.lblFirstRecord.Size = new System.Drawing.Size(130, 17);
            this.lblFirstRecord.TabIndex = 0;
            this.lblFirstRecord.Text = "Date of first record:";
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Location = new System.Drawing.Point(34, 103);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(94, 17);
            this.lblTodaysDate.TabIndex = 1;
            this.lblTodaysDate.Text = "Today\'s date:";
            // 
            // lblMostRecentRecord
            // 
            this.lblMostRecentRecord.AutoSize = true;
            this.lblMostRecentRecord.Location = new System.Drawing.Point(34, 70);
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
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // chtLineGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.chtLineGraph.ChartAreas.Add(chartArea1);
            this.chtLineGraph.DataSource = this.spendingRecordsBindingSource;
            legend1.Name = "Legend1";
            this.chtLineGraph.Legends.Add(legend1);
            this.chtLineGraph.Location = new System.Drawing.Point(389, 42);
            this.chtLineGraph.Name = "chtLineGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Date";
            series1.YValueMembers = "Amount";
            this.chtLineGraph.Series.Add(series1);
            this.chtLineGraph.Size = new System.Drawing.Size(727, 508);
            this.chtLineGraph.TabIndex = 11;
            this.chtLineGraph.Text = "Line Graph";
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
            this.btnLineGraph.Enabled = false;
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
            chartArea2.Name = "ChartArea1";
            this.chtBarChart.ChartAreas.Add(chartArea2);
            this.chtBarChart.DataSource = this.spendingRecordsBindingSource1;
            legend2.Name = "Legend1";
            this.chtBarChart.Legends.Add(legend2);
            this.chtBarChart.Location = new System.Drawing.Point(389, 43);
            this.chtBarChart.Name = "chtBarChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "Date";
            series2.YValueMembers = "Amount";
            this.chtBarChart.Series.Add(series2);
            this.chtBarChart.Size = new System.Drawing.Size(726, 507);
            this.chtBarChart.TabIndex = 15;
            this.chtBarChart.Text = "Bar Chart";
            this.chtBarChart.Visible = false;
            // 
            // btnBarChart
            // 
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
            chartArea3.Name = "ChartArea1";
            this.chtPieChart.ChartAreas.Add(chartArea3);
            this.chtPieChart.DataSource = this.spendingRecordsBindingSource2;
            legend3.Name = "Legend1";
            this.chtPieChart.Legends.Add(legend3);
            this.chtPieChart.Location = new System.Drawing.Point(389, 42);
            this.chtPieChart.Name = "chtPieChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.XValueMember = "Type";
            series3.YValueMembers = "Amount";
            this.chtPieChart.Series.Add(series3);
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
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(42, 559);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(121, 44);
            this.btnDeleteRecord.TabIndex = 20;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            // 
            // spendingRecordsDataSet
            // 
            this.spendingRecordsDataSet.DataSetName = "spendingRecordsDataSet";
            this.spendingRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spendingRecordsDataSetBindingSource
            // 
            this.spendingRecordsDataSetBindingSource.DataSource = this.spendingRecordsDataSet;
            this.spendingRecordsDataSetBindingSource.Position = 0;
            // 
            // spendingRecordsBindingSource
            // 
            this.spendingRecordsBindingSource.DataMember = "spendingRecords";
            this.spendingRecordsBindingSource.DataSource = this.spendingRecordsDataSetBindingSource;
            // 
            // spendingRecordsTableAdapter
            // 
            this.spendingRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // spendingRecordsBindingSource1
            // 
            this.spendingRecordsBindingSource1.DataMember = "spendingRecords";
            this.spendingRecordsBindingSource1.DataSource = this.spendingRecordsDataSetBindingSource;
            // 
            // spendingRecordsBindingSource2
            // 
            this.spendingRecordsBindingSource2.DataMember = "spendingRecords";
            this.spendingRecordsBindingSource2.DataSource = this.spendingRecordsDataSetBindingSource;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 641);
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
            ((System.ComponentModel.ISupportInitialize)(this.chtBarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtPieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingRecordsBindingSource2)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chtLineGraph;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnViewAllRecords;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
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
        private System.Windows.Forms.BindingSource spendingRecordsBindingSource;
        private spendingRecordsDataSetTableAdapters.spendingRecordsTableAdapter spendingRecordsTableAdapter;
        private System.Windows.Forms.BindingSource spendingRecordsBindingSource1;
        private System.Windows.Forms.BindingSource spendingRecordsBindingSource2;
    }
}

