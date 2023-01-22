namespace Shubin
{
    partial class Make_Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Make_Request));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.qtyUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sendreqbutton = new System.Windows.Forms.Button();
            this.cancelreqbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.workertextBox = new System.Windows.Forms.TextBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 45);
            this.panel1.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(59, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 23);
            this.label9.TabIndex = 69;
            this.label9.Text = "Создание запроса";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(103, 98);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(206, 20);
            this.nameTextBox.TabIndex = 72;
            // 
            // qtyUpDown
            // 
            this.qtyUpDown.Location = new System.Drawing.Point(103, 133);
            this.qtyUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.qtyUpDown.Name = "qtyUpDown";
            this.qtyUpDown.Size = new System.Drawing.Size(206, 20);
            this.qtyUpDown.TabIndex = 73;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(103, 168);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 76;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Количество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Дата:";
            // 
            // sendreqbutton
            // 
            this.sendreqbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.sendreqbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendreqbutton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendreqbutton.Location = new System.Drawing.Point(63, 242);
            this.sendreqbutton.Name = "sendreqbutton";
            this.sendreqbutton.Size = new System.Drawing.Size(120, 39);
            this.sendreqbutton.TabIndex = 80;
            this.sendreqbutton.Text = "Отправить запрос";
            this.sendreqbutton.UseVisualStyleBackColor = false;
            this.sendreqbutton.Click += new System.EventHandler(this.sendreqbutton_Click);
            // 
            // cancelreqbutton
            // 
            this.cancelreqbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.cancelreqbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelreqbutton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelreqbutton.Location = new System.Drawing.Point(189, 242);
            this.cancelreqbutton.Name = "cancelreqbutton";
            this.cancelreqbutton.Size = new System.Drawing.Size(120, 39);
            this.cancelreqbutton.TabIndex = 81;
            this.cancelreqbutton.Text = "Отмена";
            this.cancelreqbutton.UseVisualStyleBackColor = false;
            this.cancelreqbutton.Click += new System.EventHandler(this.cancelreqbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 83;
            this.label4.Text = "Работник:";
            // 
            // workertextBox
            // 
            this.workertextBox.Location = new System.Drawing.Point(103, 203);
            this.workertextBox.Name = "workertextBox";
            this.workertextBox.Size = new System.Drawing.Size(206, 20);
            this.workertextBox.TabIndex = 82;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(103, 64);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(206, 20);
            this.IDtextBox.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 85;
            this.label5.Text = "Код:";
            // 
            // Make_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(326, 295);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.workertextBox);
            this.Controls.Add(this.cancelreqbutton);
            this.Controls.Add(this.sendreqbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.qtyUpDown);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Make_Request";
            this.Text = "InventoryPro";
            this.Load += new System.EventHandler(this.Make_Request_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendreqbutton;
        private System.Windows.Forms.Button cancelreqbutton;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.NumericUpDown qtyUpDown;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox workertextBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox IDtextBox;
    }
}