namespace Shubin
{
    partial class Manage_Worker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Worker));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.deprtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.famtextBox = new System.Windows.Forms.TextBox();
            this.posttextBox = new System.Windows.Forms.TextBox();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.idtextBox);
            this.panel2.Controls.Add(this.posttextBox);
            this.panel2.Controls.Add(this.famtextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nametextBox);
            this.panel2.Controls.Add(this.deprtextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.clearbutton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.updatebutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 222);
            this.panel2.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 109;
            this.label1.Text = "Отдел:";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(137, 16);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(206, 20);
            this.nametextBox.TabIndex = 89;
            // 
            // deprtextBox
            // 
            this.deprtextBox.Location = new System.Drawing.Point(136, 89);
            this.deprtextBox.Name = "deprtextBox";
            this.deprtextBox.Size = new System.Drawing.Size(206, 20);
            this.deprtextBox.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 90;
            this.label2.Text = "Имя:";
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.clearbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton.Image = global::Shubin.Properties.Resources.icons8_broom_30;
            this.clearbutton.Location = new System.Drawing.Point(174, 168);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(42, 39);
            this.clearbutton.TabIndex = 107;
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 92;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 94;
            this.label4.Text = "Должность:";
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatebutton.Location = new System.Drawing.Point(222, 168);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(120, 39);
            this.updatebutton.TabIndex = 104;
            this.updatebutton.Text = "Обновить";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 45);
            this.panel1.TabIndex = 111;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(37, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 23);
            this.label9.TabIndex = 69;
            this.label9.Text = "Управление работником";
            // 
            // famtextBox
            // 
            this.famtextBox.Location = new System.Drawing.Point(137, 53);
            this.famtextBox.Name = "famtextBox";
            this.famtextBox.Size = new System.Drawing.Size(206, 20);
            this.famtextBox.TabIndex = 110;
            // 
            // posttextBox
            // 
            this.posttextBox.Location = new System.Drawing.Point(136, 126);
            this.posttextBox.Name = "posttextBox";
            this.posttextBox.Size = new System.Drawing.Size(206, 20);
            this.posttextBox.TabIndex = 111;
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(92, 16);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(39, 20);
            this.idtextBox.TabIndex = 112;
            this.idtextBox.Visible = false;
            // 
            // Manage_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 267);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manage_Worker";
            this.Text = "InventoryPro 2.0";
            this.Load += new System.EventHandler(this.Manage_Worker_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox nametextBox;
        public System.Windows.Forms.TextBox deprtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox famtextBox;
        public System.Windows.Forms.TextBox posttextBox;
        public System.Windows.Forms.TextBox idtextBox;
    }
}