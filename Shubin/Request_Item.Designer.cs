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
            this.button2 = new System.Windows.Forms.Button();
            this.requestButton = new System.Windows.Forms.Button();
            this.requestdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.qtynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.workercomboBox = new System.Windows.Forms.ComboBox();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shubinDataSet = new Shubin.ShubinDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Inventory = new System.Windows.Forms.DataGridView();
            this.Inv_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Worker_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_Supplier_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.workersTableAdapter = new Shubin.ShubinDataSetTableAdapters.WorkersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtynumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shubinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.requestButton);
            this.panel1.Controls.Add(this.requestdateTimePicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.qtynumericUpDown);
            this.panel1.Controls.Add(this.workercomboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nametextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 228);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(258, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 42);
            this.button2.TabIndex = 93;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // requestButton
            // 
            this.requestButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requestButton.Location = new System.Drawing.Point(99, 165);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(133, 42);
            this.requestButton.TabIndex = 92;
            this.requestButton.Text = "Отправить запрос";
            this.requestButton.UseVisualStyleBackColor = true;
            this.requestButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // requestdateTimePicker
            // 
            this.requestdateTimePicker.Enabled = false;
            this.requestdateTimePicker.Location = new System.Drawing.Point(179, 98);
            this.requestdateTimePicker.Name = "requestdateTimePicker";
            this.requestdateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.requestdateTimePicker.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(96, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 90;
            this.label4.Text = "Работник:";
            // 
            // qtynumericUpDown
            // 
            this.qtynumericUpDown.Location = new System.Drawing.Point(179, 72);
            this.qtynumericUpDown.Name = "qtynumericUpDown";
            this.qtynumericUpDown.Size = new System.Drawing.Size(212, 20);
            this.qtynumericUpDown.TabIndex = 89;
            // 
            // workercomboBox
            // 
            this.workercomboBox.DataSource = this.workersBindingSource;
            this.workercomboBox.DisplayMember = "Work_Fam";
            this.workercomboBox.FormattingEnabled = true;
            this.workercomboBox.Location = new System.Drawing.Point(179, 124);
            this.workercomboBox.Name = "workercomboBox";
            this.workercomboBox.Size = new System.Drawing.Size(212, 21);
            this.workercomboBox.TabIndex = 88;
            this.workercomboBox.ValueMember = "Work_ID";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.shubinDataSet;
            // 
            // shubinDataSet
            // 
            this.shubinDataSet.DataSetName = "ShubinDataSet";
            this.shubinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(96, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 87;
            this.label5.Text = "Дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(96, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 86;
            this.label3.Text = "Кол-во:";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(179, 46);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(212, 20);
            this.nametextBox.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "Название:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(145, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оформление запроса";
            // 
            // DGV_Inventory
            // 
            this.DGV_Inventory.BackgroundColor = System.Drawing.Color.White;
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
            this.Inv_Location,
            this.Inv_Status,
            this.Inv_Supplier_ID});
            this.DGV_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Inventory.EnableHeadersVisualStyles = false;
            this.DGV_Inventory.Location = new System.Drawing.Point(0, 0);
            this.DGV_Inventory.Name = "DGV_Inventory";
            this.DGV_Inventory.Size = new System.Drawing.Size(482, 351);
            this.DGV_Inventory.TabIndex = 1;
            this.DGV_Inventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Inventory_CellClick);
            // 
            // Inv_ID
            // 
            this.Inv_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_ID.HeaderText = "ID";
            this.Inv_ID.Name = "Inv_ID";
            this.Inv_ID.ReadOnly = true;
            this.Inv_ID.Width = 47;
            // 
            // Inv_Name
            // 
            this.Inv_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_Name.HeaderText = "Название";
            this.Inv_Name.Name = "Inv_Name";
            this.Inv_Name.ReadOnly = true;
            this.Inv_Name.Width = 95;
            // 
            // Inv_Quantity
            // 
            this.Inv_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_Quantity.HeaderText = "Количество";
            this.Inv_Quantity.Name = "Inv_Quantity";
            this.Inv_Quantity.ReadOnly = true;
            this.Inv_Quantity.Width = 108;
            // 
            // Inv_Price
            // 
            this.Inv_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_Price.HeaderText = "Цена";
            this.Inv_Price.Name = "Inv_Price";
            this.Inv_Price.ReadOnly = true;
            this.Inv_Price.Width = 66;
            // 
            // Inv_PurchaseDate
            // 
            this.Inv_PurchaseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_PurchaseDate.HeaderText = "Дата покупки";
            this.Inv_PurchaseDate.Name = "Inv_PurchaseDate";
            this.Inv_PurchaseDate.ReadOnly = true;
            this.Inv_PurchaseDate.Width = 123;
            // 
            // Inv_Worker_ID
            // 
            this.Inv_Worker_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_Worker_ID.HeaderText = "ID_Работника";
            this.Inv_Worker_ID.Name = "Inv_Worker_ID";
            this.Inv_Worker_ID.ReadOnly = true;
            this.Inv_Worker_ID.Visible = false;
            this.Inv_Worker_ID.Width = 124;
            // 
            // Inv_Location
            // 
            this.Inv_Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_Location.HeaderText = "Местоположение";
            this.Inv_Location.Name = "Inv_Location";
            this.Inv_Location.ReadOnly = true;
            this.Inv_Location.Visible = false;
            this.Inv_Location.Width = 146;
            // 
            // Inv_Status
            // 
            this.Inv_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_Status.HeaderText = "Статус";
            this.Inv_Status.Name = "Inv_Status";
            this.Inv_Status.ReadOnly = true;
            this.Inv_Status.Visible = false;
            this.Inv_Status.Width = 75;
            // 
            // Inv_Supplier_ID
            // 
            this.Inv_Supplier_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Inv_Supplier_ID.HeaderText = "ID_Поставщика";
            this.Inv_Supplier_ID.Name = "Inv_Supplier_ID";
            this.Inv_Supplier_ID.ReadOnly = true;
            this.Inv_Supplier_ID.Visible = false;
            this.Inv_Supplier_ID.Width = 135;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Shubin.Properties.Resources.RequestWhite;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 21;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // Request_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 579);
            this.Controls.Add(this.DGV_Inventory);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Request_Item";
            this.Text = "InventoryPro";
            this.Load += new System.EventHandler(this.Request_Item_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtynumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shubinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Inventory;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Worker_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_Supplier_ID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.DateTimePicker requestdateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown qtynumericUpDown;
        private System.Windows.Forms.ComboBox workercomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label2;
        private ShubinDataSet shubinDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private ShubinDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
    }
}