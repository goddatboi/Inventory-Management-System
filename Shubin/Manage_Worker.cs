using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shubin
{
    public partial class Manage_Worker : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        SqlCommand command = new SqlCommand();
        public Manage_Worker()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Clear()
        {
            nametextBox.Text = "";
            famtextBox.Text = "";
            deprtextBox.Text = "";
            posttextBox.Text = "";
        }

        private void Manage_Worker_Load(object sender, EventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите обновить данные работника", "Обновление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new SqlCommand($"UPDATE Workers SET Work_Name = @Work_Name, Work_Fam = @Work_Fam, Work_Department = @Work_Department, Work_Post = @Work_Post WHERE Work_ID = '{idtextBox.Text}'", dataBase.getConnection());
                    command.Parameters.AddWithValue("@Work_Name", nametextBox.Text);
                    command.Parameters.AddWithValue("@Work_Fam", famtextBox.Text);
                    command.Parameters.AddWithValue("@Work_Department", deprtextBox.Text);
                    command.Parameters.AddWithValue("@Work_Post", posttextBox.Text);
                    dataBase.openConnection();
                    command.ExecuteNonQuery();
                    dataBase.closeConnection();
                    MessageBox.Show("Данные работника успешно обновлёны");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
