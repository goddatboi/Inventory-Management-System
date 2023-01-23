namespace Shubin
{
    partial class Statistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.userMain_Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DGV_InventoryMovement = new System.Windows.Forms.DataGridView();
            this.Move_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Move_Inv_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Move_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Move_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.outdocButton = new Shubin.WorkerButton();
            this.userMain_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InventoryMovement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdocButton)).BeginInit();
            this.SuspendLayout();
            // 
            // userMain_Panel
            // 
            this.userMain_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(115)))));
            this.userMain_Panel.Controls.Add(this.label1);
            this.userMain_Panel.Controls.Add(this.DGV_InventoryMovement);
            this.userMain_Panel.Controls.Add(this.outdocButton);
            this.userMain_Panel.Controls.Add(this.chart1);
            this.userMain_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userMain_Panel.Location = new System.Drawing.Point(0, 59);
            this.userMain_Panel.Name = "userMain_Panel";
            this.userMain_Panel.Size = new System.Drawing.Size(865, 462);
            this.userMain_Panel.TabIndex = 74;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 59);
            this.panel1.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(376, 23);
            this.label9.TabIndex = 69;
            this.label9.Text = "Статистика движения инвентаря";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(115)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(533, 16);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // DGV_InventoryMovement
            // 
            this.DGV_InventoryMovement.AllowUserToAddRows = false;
            this.DGV_InventoryMovement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(115)))));
            this.DGV_InventoryMovement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_InventoryMovement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_InventoryMovement.ColumnHeadersHeight = 30;
            this.DGV_InventoryMovement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_InventoryMovement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Move_ID,
            this.Move_Inv_Name,
            this.Move_Quantity,
            this.Move_Status});
            this.DGV_InventoryMovement.Dock = System.Windows.Forms.DockStyle.Left;
            this.DGV_InventoryMovement.EnableHeadersVisualStyles = false;
            this.DGV_InventoryMovement.Location = new System.Drawing.Point(0, 0);
            this.DGV_InventoryMovement.Name = "DGV_InventoryMovement";
            this.DGV_InventoryMovement.Size = new System.Drawing.Size(372, 462);
            this.DGV_InventoryMovement.TabIndex = 6;
            // 
            // Move_ID
            // 
            this.Move_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Move_ID.HeaderText = "Код";
            this.Move_ID.Name = "Move_ID";
            this.Move_ID.ReadOnly = true;
            this.Move_ID.Width = 55;
            // 
            // Move_Inv_Name
            // 
            this.Move_Inv_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Move_Inv_Name.HeaderText = "Название";
            this.Move_Inv_Name.Name = "Move_Inv_Name";
            this.Move_Inv_Name.Width = 93;
            // 
            // Move_Quantity
            // 
            this.Move_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Move_Quantity.HeaderText = "Количество";
            this.Move_Quantity.Name = "Move_Quantity";
            this.Move_Quantity.ReadOnly = true;
            this.Move_Quantity.Width = 106;
            // 
            // Move_Status
            // 
            this.Move_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Move_Status.HeaderText = "Статус";
            this.Move_Status.Name = "Move_Status";
            this.Move_Status.Width = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(651, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 14);
            this.label1.TabIndex = 79;
            this.label1.Text = "Вывод во внешний документ";
            // 
            // outdocButton
            // 
            this.outdocButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outdocButton.Image = global::Shubin.Properties.Resources.DocWhite;
            this.outdocButton.ImageHover = global::Shubin.Properties.Resources.DocBlack;
            this.outdocButton.ImageNormal = global::Shubin.Properties.Resources.DocWhite;
            this.outdocButton.Location = new System.Drawing.Point(728, 378);
            this.outdocButton.Name = "outdocButton";
            this.outdocButton.Size = new System.Drawing.Size(50, 50);
            this.outdocButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.outdocButton.TabIndex = 78;
            this.outdocButton.TabStop = false;
            this.outdocButton.Click += new System.EventHandler(this.outdocButton_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 521);
            this.Controls.Add(this.userMain_Panel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistics";
            this.Text = "InventoryPro 2.0";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.userMain_Panel.ResumeLayout(false);
            this.userMain_Panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InventoryMovement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdocButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userMain_Panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView DGV_InventoryMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Move_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Move_Inv_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Move_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Move_Status;
        private System.Windows.Forms.Label label1;
        private WorkerButton outdocButton;
    }
}