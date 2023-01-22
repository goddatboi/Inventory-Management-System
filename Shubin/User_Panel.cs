﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shubin
{
    public partial class User_Panel : Form
    {
        public User_Panel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void User_Panel_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            activeForm.TopLevel= false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            userMain_Panel.Controls.Add(childForm);
            userMain_Panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Request_Item());
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Return_Item());
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите сменить пользователя?", "Изменение пользователя", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Log_In loginForm = new Log_In();
                loginForm.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Выход из программы", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовой проект по МДК.04.01:\nИнформационная система учета инвентаря организации\nРазработчик: Шубин Михаил, студент группы ИП-41");
        }

        private void myinventoryButton_Click(object sender, EventArgs e)
        {

        }

        private void historyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
