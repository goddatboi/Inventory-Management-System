namespace Shubin
{
    partial class Workers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workers));
            this.DGV_Workers = new System.Windows.Forms.DataGridView();
            this.Work_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work_Fam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Is_Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Workers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Workers
            // 
            this.DGV_Workers.AllowUserToAddRows = false;
            this.DGV_Workers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(115)))));
            this.DGV_Workers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Workers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Workers.ColumnHeadersHeight = 30;
            this.DGV_Workers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Workers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Work_ID,
            this.Work_Name,
            this.Work_Fam,
            this.Work_Department,
            this.Work_Post,
            this.Login_User,
            this.Password_User,
            this.Is_Admin,
            this.Edit,
            this.Delete});
            this.DGV_Workers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Workers.EnableHeadersVisualStyles = false;
            this.DGV_Workers.Location = new System.Drawing.Point(0, 0);
            this.DGV_Workers.Name = "DGV_Workers";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Workers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Workers.Size = new System.Drawing.Size(773, 405);
            this.DGV_Workers.TabIndex = 3;
            this.DGV_Workers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Workers_CellContentClick);
            // 
            // Work_ID
            // 
            this.Work_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Work_ID.HeaderText = "Код";
            this.Work_ID.Name = "Work_ID";
            this.Work_ID.ReadOnly = true;
            this.Work_ID.Width = 55;
            // 
            // Work_Name
            // 
            this.Work_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Work_Name.HeaderText = "Имя";
            this.Work_Name.Name = "Work_Name";
            this.Work_Name.ReadOnly = true;
            // 
            // Work_Fam
            // 
            this.Work_Fam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Work_Fam.HeaderText = "Фамилия";
            this.Work_Fam.Name = "Work_Fam";
            // 
            // Work_Department
            // 
            this.Work_Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Work_Department.HeaderText = "Отдел";
            this.Work_Department.Name = "Work_Department";
            this.Work_Department.Width = 70;
            // 
            // Work_Post
            // 
            this.Work_Post.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Work_Post.HeaderText = "Должность";
            this.Work_Post.Name = "Work_Post";
            this.Work_Post.Width = 105;
            // 
            // Login_User
            // 
            this.Login_User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Login_User.HeaderText = "Логин";
            this.Login_User.Name = "Login_User";
            this.Login_User.Width = 68;
            // 
            // Password_User
            // 
            this.Password_User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Password_User.HeaderText = "Пароль";
            this.Password_User.Name = "Password_User";
            this.Password_User.Width = 79;
            // 
            // Is_Admin
            // 
            this.Is_Admin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Is_Admin.HeaderText = "Роль";
            this.Is_Admin.Name = "Is_Admin";
            this.Is_Admin.Width = 62;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.searchtextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 45);
            this.panel1.TabIndex = 4;
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(12, 13);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(205, 20);
            this.searchtextBox.TabIndex = 0;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
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
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_Workers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Workers";
            this.Text = "InventoryPro";
            this.Load += new System.EventHandler(this.Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Workers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Workers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_Fam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Is_Admin;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}