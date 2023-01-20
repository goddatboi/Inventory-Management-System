using System;
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
    }
}
