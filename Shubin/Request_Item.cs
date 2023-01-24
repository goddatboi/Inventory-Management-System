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
            DGV_Inventory.Rows.Clear();
            command = new SqlCommand("SELECT * FROM InventoryItems WHERE CONCAT(Inv_ID, Inv_Name, Inv_Quantity, Inv_Price, Inv_PurchaseDate, Inv_Supplier_ID, Inv_Location, Inv_Status) LIKE '%" + searchtextBox.Text + "%'", dataBase.getConnection());
            dataBase.openConnection();
            DR = command.ExecuteReader();

            while (DR.Read())
            {
                DGV_Inventory.Rows.Add(DR[0].ToString(), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString());
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
                makeReqForm.IDtextBox.Enabled = false;
                makeReqForm.workertextBox.Enabled = false;
                makeReqForm.nameTextBox.Enabled = false;
                makeReqForm.dateTimePicker.Enabled = false;
                dataBase.closeConnection();
                makeReqForm.ShowDialog();
            }
            LoadInventory();
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            LoadInventory();
        }
    }
}
