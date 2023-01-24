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
using System.Xml.Linq;

namespace Shubin
{
    public partial class User_Inventory : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader DR;
        public User_Inventory()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadInventoryStatus();
        }

        private void DGV_Inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGV_UserInventory.Columns[e.ColumnIndex].Name;

            if (colName == "Return")
            {
                dataBase.openConnection();
                var returnInv = "UPDATE InventoryItems SET Inv_Quantity = Inv_Quantity + " + Convert.ToInt32(DGV_UserInventory.Rows[e.RowIndex].Cells["St_Quantity"].Value.ToString()) + " WHERE Inv_ID = " + Convert.ToInt32(DGV_UserInventory.Rows[e.RowIndex].Cells["St_Inv_ID"].Value.ToString());
                var returnCommand = new SqlCommand(returnInv, dataBase.getConnection());
                returnCommand.ExecuteNonQuery();

                var moveQuery = "INSERT INTO InventoryMovement (Move_Inv_ID, Move_Inv_Name, Move_Quantity, Move_Date, Move_Worker_ID, Move_Status) VALUES (@Move_Inv_ID, @Move_Inv_Name, @Move_Quantity, @Move_Date, @Move_Worker_ID, @Move_Status)";
                var moveCommand = new SqlCommand(moveQuery, dataBase.getConnection());
                moveCommand.Parameters.AddWithValue("@Move_Inv_ID", DGV_UserInventory.Rows[e.RowIndex].Cells[1].Value.ToString());
                moveCommand.Parameters.AddWithValue("@Move_Inv_Name", DGV_UserInventory.Rows[e.RowIndex].Cells[2].Value.ToString());
                moveCommand.Parameters.AddWithValue("@Move_Quantity", DGV_UserInventory.Rows[e.RowIndex].Cells[4].Value.ToString());
                moveCommand.Parameters.AddWithValue("@Move_Date", DGV_UserInventory.Rows[e.RowIndex].Cells[3].Value.ToString());
                moveCommand.Parameters.AddWithValue("@Move_Worker_ID", DGV_UserInventory.Rows[e.RowIndex].Cells[6].Value.ToString());
                moveCommand.Parameters.AddWithValue("@Move_Status", "Возвращен");
                moveCommand.ExecuteNonQuery();

                var delInv = "DELETE FROM InventoryStatus WHERE St_Inv_ID = " + DGV_UserInventory.Rows[e.RowIndex].Cells["St_Inv_ID"].Value;
                var delCommand = new SqlCommand(delInv, dataBase.getConnection());
                delCommand.ExecuteNonQuery();

                MessageBox.Show("Инвентарь успешно возвращён");
                dataBase.closeConnection();
            }
            else if (colName == "FixRequest")
            {
                dataBase.openConnection();
                var addQuery = "INSERT INTO Requests (Req_Name, Req_Quantity, Req_Worker_ID, Req_Inv_ID, Req_Date, Req_Status) VALUES (@Req_Name, @Req_Quantity, @Req_Worker_ID, @Req_Inv_ID, @Req_Date, 'Починка')";
                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.Parameters.AddWithValue("@Req_Name", DGV_UserInventory.Rows[e.RowIndex].Cells["St_Name"].Value.ToString());
                command.Parameters.AddWithValue("@Req_Quantity", DGV_UserInventory.Rows[e.RowIndex].Cells["St_Quantity"].Value);
                command.Parameters.AddWithValue("@Req_Worker_ID", DGV_UserInventory.Rows[e.RowIndex].Cells["St_RespWorker"].Value);
                command.Parameters.AddWithValue("@Req_Inv_ID", DGV_UserInventory.Rows[e.RowIndex].Cells["St_Inv_ID"].Value);
                command.Parameters.AddWithValue("@Req_Date", DGV_UserInventory.Rows[e.RowIndex].Cells["St_UpdateDate"].Value);
                command.ExecuteNonQuery();

                var delInv = "DELETE FROM InventoryStatus WHERE St_Inv_ID = " + DGV_UserInventory.Rows[e.RowIndex].Cells["St_Inv_ID"].Value;
                var delCommand = new SqlCommand(delInv, dataBase.getConnection());
                delCommand.ExecuteNonQuery();

                MessageBox.Show("Запрос на починку успешно отправлен");
                dataBase.closeConnection();
            }
            LoadInventoryStatus(); 
        }

        public void LoadInventoryStatus()
        {
            dataBase.openConnection();
            command = new SqlCommand($"SELECT Work_ID FROM Workers WHERE Login_User = '{Convert.ToString(GlobalVariables.login)}'", dataBase.getConnection());
            var worker = Convert.ToInt32(command.ExecuteScalar());
            DGV_UserInventory.Rows.Clear();
            command = new SqlCommand($"SELECT * FROM InventoryStatus WHERE St_RespWorker = '{worker}' and CONCAT(St_ID, St_Inv_ID, St_Inv_Name, St_UpdateDate, St_Quantity, St_Status, St_RespWorker) LIKE '%" + searchtextBox.Text + "%'", dataBase.getConnection());
            DR = command.ExecuteReader();

            while (DR.Read())
            {
                DGV_UserInventory.Rows.Add(DR[0].ToString(), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), DR[6].ToString());
            }
            DR.Close();
            dataBase.closeConnection();
        }

        private void User_Inventory_Load(object sender, EventArgs e)
        {

        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            LoadInventoryStatus();
        }
    }
}
