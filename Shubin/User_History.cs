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

namespace Shubin
{
    public partial class User_History : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader DR;
        public User_History()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadUserHistory();
        }

        private void User_History_Load(object sender, EventArgs e)
        {

        }

        public void LoadUserHistory()
        {
            dataBase.openConnection();
            command = new SqlCommand($"SELECT Work_ID FROM Workers WHERE Login_User = '{Convert.ToString(GlobalVariables.login)}'", dataBase.getConnection());
            var worker = Convert.ToInt32(command.ExecuteScalar());
            int i = 0;
            DGV_UserHistory.Rows.Clear();
            command = new SqlCommand($"SELECT * FROM InventoryMovement WHERE Move_Worker_ID = '{worker}'", dataBase.getConnection());
            DR = command.ExecuteReader();

            while (DR.Read())
            {
                i++;
                DGV_UserHistory.Rows.Add(i, DR[2].ToString(), DR[3].ToString(), DR[6].ToString());
            }
            DR.Close();
            dataBase.closeConnection();
        }
    }
}
