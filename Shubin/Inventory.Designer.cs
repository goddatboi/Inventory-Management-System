namespace Shubin
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.DGV_Inventory = new System.Windows.Forms.DataGridView();
            this.Inv_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Supplier_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.addButton = new Shubin.WorkerButton();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventory)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Inventory
            // 
            this.DGV_Inventory.AllowUserToAddRows = false;
            this.DGV_Inventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(115)))));
            this.DGV_Inventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
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
            this.Inv_Supplier_ID,
            this.Inv_Location,
            this.Inv_Status,
            this.Edit,
            this.Delete});
            this.DGV_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Inventory.EnableHeadersVisualStyles = false;
            this.DGV_Inventory.Location = new System.Drawing.Point(0, 0);
            this.DGV_Inventory.Name = "DGV_Inventory";
            this.DGV_Inventory.Size = new System.Drawing.Size(972, 450);
            this.DGV_Inventory.TabIndex = 2;
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
            // Inv_Supplier_ID
            // 
            this.Inv_Supplier_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_Supplier_ID.HeaderText = "Поставщик";
            this.Inv_Supplier_ID.Name = "Inv_Supplier_ID";
            this.Inv_Supplier_ID.Width = 102;
            // 
            // Inv_Location
            // 
            this.Inv_Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_Location.HeaderText = "Расположение";
            this.Inv_Location.Name = "Inv_Location";
            this.Inv_Location.Width = 128;
            // 
            // Inv_Status
            // 
            this.Inv_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_Status.HeaderText = "Статус";
            this.Inv_Status.Name = "Inv_Status";
            this.Inv_Status.Width = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.searchtextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 45);
            this.panel1.TabIndex = 4;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(12, 13);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(205, 20);
            this.searchtextBox.TabIndex = 0;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Shubin.Properties.Resources.Edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Shubin.Properties.Resources.Delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 5;
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Image = global::Shubin.Properties.Resources.AddButton;
            this.addButton.ImageHover = global::Shubin.Properties.Resources.AddButtonBlack;
            this.addButton.ImageNormal = global::Shubin.Properties.Resources.AddButton;
            this.addButton.Location = new System.Drawing.Point(223, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(30, 30);
            this.addButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.addButton.TabIndex = 77;
            this.addButton.TabStop = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::Shubin.Properties.Resources.Edit;
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::Shubin.Properties.Resources.Delete;
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_Inventory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.Text = "InventoryPro";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Inventory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtextBox;
        private WorkerButton addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Supplier_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Status;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}