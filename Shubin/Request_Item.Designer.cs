namespace Shubin
{
    partial class Request_Item
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request_Item));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV_Inventory = new System.Windows.Forms.DataGridView();
            this.Inv_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Worker_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakeRequest = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.searchtextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 45);
            this.panel1.TabIndex = 0;
            // 
            // DGV_Inventory
            // 
            this.DGV_Inventory.AllowUserToAddRows = false;
            this.DGV_Inventory.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Inventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Inventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Inventory.ColumnHeadersHeight = 30;
            this.DGV_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inv_ID,
            this.Inv_Name,
            this.Inv_Quantity,
            this.Inv_Price,
            this.Inv_PurchaseDate,
            this.Inv_Worker_ID,
            this.MakeRequest});
            this.DGV_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Inventory.EnableHeadersVisualStyles = false;
            this.DGV_Inventory.Location = new System.Drawing.Point(0, 0);
            this.DGV_Inventory.Name = "DGV_Inventory";
            this.DGV_Inventory.Size = new System.Drawing.Size(526, 534);
            this.DGV_Inventory.TabIndex = 1;
            this.DGV_Inventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Inventory_CellContentClick);
            // 
            // Inv_ID
            // 
            this.Inv_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_ID.HeaderText = "Код";
            this.Inv_ID.Name = "Inv_ID";
            this.Inv_ID.ReadOnly = true;
            this.Inv_ID.Width = 55;
            // 
            // Inv_Name
            // 
            this.Inv_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Inv_Name.HeaderText = "Название";
            this.Inv_Name.Name = "Inv_Name";
            this.Inv_Name.ReadOnly = true;
            // 
            // Inv_Quantity
            // 
            this.Inv_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_Quantity.HeaderText = "Количество";
            this.Inv_Quantity.Name = "Inv_Quantity";
            this.Inv_Quantity.ReadOnly = true;
            this.Inv_Quantity.Width = 106;
            // 
            // Inv_Price
            // 
            this.Inv_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_Price.HeaderText = "Цена";
            this.Inv_Price.Name = "Inv_Price";
            this.Inv_Price.ReadOnly = true;
            this.Inv_Price.Width = 64;
            // 
            // Inv_PurchaseDate
            // 
            this.Inv_PurchaseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_PurchaseDate.HeaderText = "Дата покупки";
            this.Inv_PurchaseDate.Name = "Inv_PurchaseDate";
            this.Inv_PurchaseDate.ReadOnly = true;
            this.Inv_PurchaseDate.Width = 111;
            // 
            // Inv_Worker_ID
            // 
            this.Inv_Worker_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_Worker_ID.HeaderText = "ID_Работника";
            this.Inv_Worker_ID.Name = "Inv_Worker_ID";
            this.Inv_Worker_ID.Visible = false;
            this.Inv_Worker_ID.Width = 124;
            // 
            // MakeRequest
            // 
            this.MakeRequest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MakeRequest.HeaderText = "";
            this.MakeRequest.Image = global::Shubin.Properties.Resources.AddCircle;
            this.MakeRequest.Name = "MakeRequest";
            this.MakeRequest.Width = 5;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Shubin.Properties.Resources.RequestWhite;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(309, 13);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(205, 20);
            this.searchtextBox.TabIndex = 0;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // Request_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 579);
            this.Controls.Add(this.DGV_Inventory);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Request_Item";
            this.Text = "InventoryPro";
            this.Load += new System.EventHandler(this.Request_Item_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_Inventory;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Worker_ID;
        private System.Windows.Forms.DataGridViewImageColumn MakeRequest;
        private System.Windows.Forms.TextBox searchtextBox;
    }
}