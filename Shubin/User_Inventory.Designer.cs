namespace Shubin
{
    partial class User_Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Inventory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.DGV_UserInventory = new System.Windows.Forms.DataGridView();
            this.St_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_Inv_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_UpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_RespWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return = new System.Windows.Forms.DataGridViewImageColumn();
            this.FixRequest = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UserInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.searchtextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 6;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(12, 13);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(205, 20);
            this.searchtextBox.TabIndex = 0;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // DGV_UserInventory
            // 
            this.DGV_UserInventory.AllowUserToAddRows = false;
            this.DGV_UserInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(115)))));
            this.DGV_UserInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_UserInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_UserInventory.ColumnHeadersHeight = 30;
            this.DGV_UserInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_UserInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.St_ID,
            this.St_Inv_ID,
            this.St_Name,
            this.St_UpdateDate,
            this.St_Quantity,
            this.St_Status,
            this.St_RespWorker,
            this.Return,
            this.FixRequest});
            this.DGV_UserInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_UserInventory.EnableHeadersVisualStyles = false;
            this.DGV_UserInventory.Location = new System.Drawing.Point(0, 0);
            this.DGV_UserInventory.Name = "DGV_UserInventory";
            this.DGV_UserInventory.Size = new System.Drawing.Size(800, 450);
            this.DGV_UserInventory.TabIndex = 5;
            this.DGV_UserInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Inventory_CellContentClick);
            // 
            // St_ID
            // 
            this.St_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.St_ID.HeaderText = "Код";
            this.St_ID.Name = "St_ID";
            this.St_ID.ReadOnly = true;
            this.St_ID.Width = 55;
            // 
            // St_Inv_ID
            // 
            this.St_Inv_ID.HeaderText = "Код инвентаря";
            this.St_Inv_ID.Name = "St_Inv_ID";
            this.St_Inv_ID.Visible = false;
            // 
            // St_Name
            // 
            this.St_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.St_Name.HeaderText = "Название";
            this.St_Name.Name = "St_Name";
            this.St_Name.ReadOnly = true;
            // 
            // St_UpdateDate
            // 
            this.St_UpdateDate.HeaderText = "Дата обновления";
            this.St_UpdateDate.Name = "St_UpdateDate";
            this.St_UpdateDate.Visible = false;
            // 
            // St_Quantity
            // 
            this.St_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.St_Quantity.HeaderText = "Количество";
            this.St_Quantity.Name = "St_Quantity";
            this.St_Quantity.ReadOnly = true;
            this.St_Quantity.Width = 106;
            // 
            // St_Status
            // 
            this.St_Status.HeaderText = "Статус";
            this.St_Status.Name = "St_Status";
            this.St_Status.Visible = false;
            // 
            // St_RespWorker
            // 
            this.St_RespWorker.HeaderText = "Ответственный работник";
            this.St_RespWorker.Name = "St_RespWorker";
            this.St_RespWorker.Visible = false;
            // 
            // Return
            // 
            this.Return.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Return.HeaderText = "";
            this.Return.Image = global::Shubin.Properties.Resources.ReturnSmall;
            this.Return.Name = "Return";
            this.Return.Width = 5;
            // 
            // FixRequest
            // 
            this.FixRequest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FixRequest.HeaderText = "";
            this.FixRequest.Image = global::Shubin.Properties.Resources.Fix;
            this.FixRequest.Name = "FixRequest";
            this.FixRequest.Width = 5;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Shubin.Properties.Resources.Edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Shubin.Properties.Resources.Delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // User_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_UserInventory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_Inventory";
            this.Text = "InventoryPro 2.0";
            this.Load += new System.EventHandler(this.User_Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UserInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.DataGridView DGV_UserInventory;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_Inv_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_UpdateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_RespWorker;
        private System.Windows.Forms.DataGridViewImageColumn Return;
        private System.Windows.Forms.DataGridViewImageColumn FixRequest;
    }
}