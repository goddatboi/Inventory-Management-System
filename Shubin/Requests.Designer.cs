namespace Shubin
{
    partial class Requests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            this.DGV_Requests = new System.Windows.Forms.DataGridView();
            this.Req_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Req_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Req_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Req_Worker_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Req_Inv_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Req_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Req_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirm = new System.Windows.Forms.DataGridViewImageColumn();
            this.Deny = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Requests)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Requests
            // 
            this.DGV_Requests.AllowUserToAddRows = false;
            this.DGV_Requests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(115)))));
            this.DGV_Requests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Requests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Requests.ColumnHeadersHeight = 30;
            this.DGV_Requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Requests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Req_ID,
            this.Req_Name,
            this.Req_Quantity,
            this.Req_Worker_ID,
            this.Req_Inv_ID,
            this.Req_Date,
            this.Req_Status,
            this.Confirm,
            this.Deny});
            this.DGV_Requests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Requests.EnableHeadersVisualStyles = false;
            this.DGV_Requests.Location = new System.Drawing.Point(0, 0);
            this.DGV_Requests.Name = "DGV_Requests";
            this.DGV_Requests.Size = new System.Drawing.Size(777, 450);
            this.DGV_Requests.TabIndex = 2;
            this.DGV_Requests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Requests_CellContentClick);
            // 
            // Req_ID
            // 
            this.Req_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Req_ID.HeaderText = "Код";
            this.Req_ID.Name = "Req_ID";
            this.Req_ID.ReadOnly = true;
            this.Req_ID.Width = 55;
            // 
            // Req_Name
            // 
            this.Req_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Req_Name.HeaderText = "Название";
            this.Req_Name.Name = "Req_Name";
            this.Req_Name.ReadOnly = true;
            // 
            // Req_Quantity
            // 
            this.Req_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Req_Quantity.HeaderText = "Количество";
            this.Req_Quantity.Name = "Req_Quantity";
            this.Req_Quantity.ReadOnly = true;
            this.Req_Quantity.Width = 106;
            // 
            // Req_Worker_ID
            // 
            this.Req_Worker_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Req_Worker_ID.HeaderText = "Работник";
            this.Req_Worker_ID.Name = "Req_Worker_ID";
            this.Req_Worker_ID.Width = 91;
            // 
            // Req_Inv_ID
            // 
            this.Req_Inv_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Req_Inv_ID.HeaderText = "Инвентарь";
            this.Req_Inv_ID.Name = "Req_Inv_ID";
            this.Req_Inv_ID.Width = 101;
            // 
            // Req_Date
            // 
            this.Req_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Req_Date.HeaderText = "Дата запроса";
            this.Req_Date.Name = "Req_Date";
            this.Req_Date.Width = 110;
            // 
            // Req_Status
            // 
            this.Req_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Req_Status.HeaderText = "Статус";
            this.Req_Status.Name = "Req_Status";
            this.Req_Status.Width = 73;
            // 
            // Confirm
            // 
            this.Confirm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Confirm.HeaderText = "";
            this.Confirm.Image = global::Shubin.Properties.Resources.Confirm;
            this.Confirm.Name = "Confirm";
            this.Confirm.Width = 5;
            // 
            // Deny
            // 
            this.Deny.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Deny.HeaderText = "";
            this.Deny.Image = global::Shubin.Properties.Resources.Delete;
            this.Deny.Name = "Deny";
            this.Deny.Width = 5;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Shubin.Properties.Resources.Confirm;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Shubin.Properties.Resources.Delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.searchtextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 45);
            this.panel1.TabIndex = 3;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(12, 13);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(205, 20);
            this.searchtextBox.TabIndex = 0;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_Requests);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Requests";
            this.Text = "InventoryPro 2.0";
            this.Load += new System.EventHandler(this.Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Requests)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Requests;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Req_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Req_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Req_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Req_Worker_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Req_Inv_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Req_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Req_Status;
        private System.Windows.Forms.DataGridViewImageColumn Confirm;
        private System.Windows.Forms.DataGridViewImageColumn Deny;
    }
}