namespace Shubin
{
    partial class Suppliers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.DGV_Suppliers = new System.Windows.Forms.DataGridView();
            this.Sup_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Fam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_INN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.addButton = new Shubin.WorkerButton();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Suppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.searchtextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 45);
            this.panel1.TabIndex = 6;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(12, 13);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(205, 20);
            this.searchtextBox.TabIndex = 0;
            // 
            // DGV_Suppliers
            // 
            this.DGV_Suppliers.AllowUserToAddRows = false;
            this.DGV_Suppliers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(115)))));
            this.DGV_Suppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Suppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Suppliers.ColumnHeadersHeight = 30;
            this.DGV_Suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Suppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sup_ID,
            this.Sup_Name,
            this.Sup_Fam,
            this.Sup_Phone,
            this.Sup_Email,
            this.Sup_Address,
            this.Sup_INN,
            this.Edit,
            this.Delete});
            this.DGV_Suppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Suppliers.EnableHeadersVisualStyles = false;
            this.DGV_Suppliers.Location = new System.Drawing.Point(0, 0);
            this.DGV_Suppliers.Name = "DGV_Suppliers";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Suppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Suppliers.Size = new System.Drawing.Size(627, 369);
            this.DGV_Suppliers.TabIndex = 5;
            this.DGV_Suppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Suppliers_CellContentClick);
            // 
            // Sup_ID
            // 
            this.Sup_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sup_ID.HeaderText = "Код";
            this.Sup_ID.Name = "Sup_ID";
            this.Sup_ID.ReadOnly = true;
            this.Sup_ID.Width = 55;
            // 
            // Sup_Name
            // 
            this.Sup_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sup_Name.HeaderText = "Имя";
            this.Sup_Name.Name = "Sup_Name";
            this.Sup_Name.ReadOnly = true;
            // 
            // Sup_Fam
            // 
            this.Sup_Fam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sup_Fam.HeaderText = "Фамилия";
            this.Sup_Fam.Name = "Sup_Fam";
            // 
            // Sup_Phone
            // 
            this.Sup_Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sup_Phone.HeaderText = "Телефон";
            this.Sup_Phone.Name = "Sup_Phone";
            this.Sup_Phone.Width = 88;
            // 
            // Sup_Email
            // 
            this.Sup_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sup_Email.HeaderText = "Почта";
            this.Sup_Email.Name = "Sup_Email";
            this.Sup_Email.Width = 69;
            // 
            // Sup_Address
            // 
            this.Sup_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sup_Address.HeaderText = "Адрес";
            this.Sup_Address.Name = "Sup_Address";
            this.Sup_Address.Width = 71;
            // 
            // Sup_INN
            // 
            this.Sup_INN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sup_INN.HeaderText = "ИНН";
            this.Sup_INN.Name = "Sup_INN";
            this.Sup_INN.Width = 57;
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
            this.addButton.TabIndex = 78;
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
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_Suppliers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Suppliers";
            this.Text = "InventoryPro";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Suppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.DataGridView DGV_Suppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Fam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_INN;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private WorkerButton addButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}