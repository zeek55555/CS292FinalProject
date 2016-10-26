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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chtMainYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMainYear)).BeginInit();
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
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // chtMainYear
            // 
            chartArea1.Name = "ChartArea1";
            this.chtMainYear.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtMainYear.Legends.Add(legend1);
            this.chtMainYear.Location = new System.Drawing.Point(406, 42);
            this.chtMainYear.Name = "chtMainYear";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtMainYear.Series.Add(series1);
            this.chtMainYear.Size = new System.Drawing.Size(727, 545);
            this.chtMainYear.TabIndex = 11;
            this.chtMainYear.Text = "chart1";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(42, 427);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(121, 44);
            this.btnAddRecord.TabIndex = 12;
            this.btnAddRecord.Text = "Add record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 641);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.chtMainYear);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMainYear)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMainYear;
        private System.Windows.Forms.Button btnAddRecord;
    }
}

