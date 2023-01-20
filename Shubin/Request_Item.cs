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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;
using Shubin;

namespace Shubin
{
    public partial class Request_Item : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader DR;

        public Request_Item()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadInventory();
        }

        private void Request_Item_Load(object sender, EventArgs e)
        {

        }
        public void LoadInventory()
        {
            int i = 0;
            DGV_Inventory.Rows.Clear();
            command = new SqlCommand("SELECT * FROM InventoryItems", dataBase.getConnection());
            dataBase.openConnection();
            DR = command.ExecuteReader();

            while (DR.Read())
            {
                i++;
                DGV_Inventory.Rows.Add(i, DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString());
            }
            DR.Close();
            dataBase.closeConnection();
        }

        private void DGV_Inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGV_Inventory.Columns[e.ColumnIndex].Name;

            dataBase.openConnection();

            command = new SqlCommand($"SELECT Work_Fam FROM Workers WHERE Login_User = '{Convert.ToString(GlobalVariables.login)}'", dataBase.getConnection());

            if (colName == "MakeRequest")
            {
                Make_Request makeReqForm = new Make_Request();
                makeReqForm.IDtextBox.Text = DGV_Inventory.Rows[e.RowIndex].Cells[0].Value.ToString();
                makeReqForm.nameTextBox.Text = DGV_Inventory.Rows[e.RowIndex].Cells[1].Value.ToString();
                makeReqForm.qtyUpDown.Text = DGV_Inventory.Rows[e.RowIndex].Cells[2].Value.ToString();
                makeReqForm.workertextBox.Text = Convert.ToString(command.ExecuteScalar());
                dataBase.closeConnection();
                makeReqForm.IDtextBox.Enabled = false;
                makeReqForm.workertextBox.Enabled = false;
                makeReqForm.nameTextBox.Enabled = false;
                makeReqForm.dateTimePicker.Enabled = false;
                makeReqForm.ShowDialog();
            }
            LoadInventory();
        }
    }
}
