namespace Shubin
{
    partial class User_History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_History));
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.DGV_UserHistory = new System.Windows.Forms.DataGridView();
            this.Move_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Move_Inv_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Move_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Move_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UserHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.searchtextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 45);
            this.panel1.TabIndex = 8;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(12, 13);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(205, 20);
            this.searchtextBox.TabIndex = 0;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // DGV_UserHistory
            // 
            this.DGV_UserHistory.AllowUserToAddRows = false;
            this.DGV_UserHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(115)))));
            this.DGV_UserHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_UserHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_UserHistory.ColumnHeadersHeight = 30;
            this.DGV_UserHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_UserHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Move_ID,
            this.Move_Inv_Name,
            this.Move_Quantity,
            this.Move_Status});
            this.DGV_UserHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_UserHistory.EnableHeadersVisualStyles = false;
            this.DGV_UserHistory.Location = new System.Drawing.Point(0, 0);
            this.DGV_UserHistory.Name = "DGV_UserHistory";
            this.DGV_UserHistory.Size = new System.Drawing.Size(771, 450);
            this.DGV_UserHistory.TabIndex = 7;
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
            this.Move_Inv_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Move_Inv_Name.HeaderText = "Название";
            this.Move_Inv_Name.Name = "Move_Inv_Name";
            this.Move_Inv_Name.ReadOnly = true;
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
            // User_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_UserHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_History";
            this.Text = "InventoryPro 2.0";
            this.Load += new System.EventHandler(this.User_History_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UserHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.DataGridView DGV_UserHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Move_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Move_Inv_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Move_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Move_Status;
    }
}