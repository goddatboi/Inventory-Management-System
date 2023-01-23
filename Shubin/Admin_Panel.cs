using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shubin
{
    public partial class Admin_Panel : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public Admin_Panel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
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
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            adminMain_Panel.Controls.Add(childForm);
            adminMain_Panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Requests());
        }

        private void workersButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Workers());
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Inventory());
        }

        private void suppliersButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Suppliers());
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics statForm = new Statistics();
            this.Hide();
            statForm.ShowDialog();
            statForm.Dispose();
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
    }
}
