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
    public partial class Requests : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader DR;
        public Requests()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadRequests();
        }

        private void Requests_Load(object sender, EventArgs e)
        {

        }

        public void LoadRequests()
        {
            DGV_Requests.Rows.Clear();
            command = new SqlCommand("SELECT * FROM Requests", dataBase.getConnection());
            dataBase.openConnection();
            DR = command.ExecuteReader();

            while (DR.Read())
            {
                DGV_Requests.Rows.Add(DR[0].ToString(), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), DR[6].ToString());
            }
            DR.Close();
            dataBase.closeConnection();
        }

        private void DGV_Requests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGV_Requests.Columns[e.ColumnIndex].Name;

            if (colName == "Confirm")
            {
                if (DGV_Requests.Rows[e.RowIndex].Cells[6].Value.ToString() == "Рассмотрение")
                {
                    dataBase.openConnection();

                    var moveQuery = "INSERT INTO InventoryMovement (Move_Inv_ID, Move_Inv_Name, Move_Quantity, Move_Date, Move_Worker_ID, Move_Status) VALUES (@Move_Inv_ID, @Move_Inv_Name, @Move_Quantity, @Move_Date, @Move_Worker_ID, @Move_Status)";
                    var moveCommand = new SqlCommand(moveQuery, dataBase.getConnection());
                    moveCommand.Parameters.AddWithValue("@Move_Inv_ID", DGV_Requests.Rows[e.RowIndex].Cells[4].Value.ToString());
                    moveCommand.Parameters.AddWithValue("@Move_Inv_Name", DGV_Requests.Rows[e.RowIndex].Cells[1].Value.ToString());
                    moveCommand.Parameters.AddWithValue("@Move_Quantity", DGV_Requests.Rows[e.RowIndex].Cells[2].Value.ToString());
                    moveCommand.Parameters.AddWithValue("@Move_Date", DGV_Requests.Rows[e.RowIndex].Cells[5].Value.ToString());
                    moveCommand.Parameters.AddWithValue("@Move_Worker_ID", DGV_Requests.Rows[e.RowIndex].Cells[3].Value.ToString());
                    moveCommand.Parameters.AddWithValue("@Move_Status", "Одобрено");
                    moveCommand.ExecuteNonQuery();

                    var statusQuery = "INSERT INTO InventoryStatus (St_Inv_ID, St_Inv_Name, St_UpdateDate, St_Quantity, St_Status, St_RespWorker) VALUES (@St_Inv_ID, @St_Inv_Name, @St_UpdateDate, @St_Quantity, @St_Status, @St_RespWorker)";
                    var statusCommand = new SqlCommand(statusQuery, dataBase.getConnection());
                    statusCommand.Parameters.AddWithValue("@St_Inv_ID", DGV_Requests.Rows[e.RowIndex].Cells[4].Value.ToString());
                    statusCommand.Parameters.AddWithValue("@St_Inv_Name", DGV_Requests.Rows[e.RowIndex].Cells[1].Value.ToString());
                    statusCommand.Parameters.AddWithValue("@St_UpdateDate", DGV_Requests.Rows[e.RowIndex].Cells[5].Value.ToString());
                    statusCommand.Parameters.AddWithValue("@St_Quantity", DGV_Requests.Rows[e.RowIndex].Cells[2].Value.ToString());
                    statusCommand.Parameters.AddWithValue("@St_Status", "Одобрено");
                    statusCommand.Parameters.AddWithValue("@St_RespWorker", DGV_Requests.Rows[e.RowIndex].Cells[3].Value.ToString());
                    statusCommand.ExecuteNonQuery();

                    var deleteQuery = "DELETE FROM Requests WHERE Req_ID = " + DGV_Requests.Rows[e.RowIndex].Cells["Req_ID"].Value;
                    var deleteCommand = new SqlCommand(deleteQuery, dataBase.getConnection());
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Запрос успешно одобрен");
                    dataBase.closeConnection();
                }
                else
                {
                    dataBase.openConnection();
                    var moveQuery = "INSERT INTO InventoryMovement (Move_Inv_ID, Move_Inv_Name, Move_Quantity, Move_Date, Move_Worker_ID, Move_Status) VALUES (@Move_Inv_ID, @Move_Inv_Name, @Move_Quantity, @Move_Date, @Move_Worker_ID, @Move_Status)";
                    var moveCommand = new SqlCommand(moveQuery, dataBase.getConnection());
                    moveCommand.Parameters.AddWithValue("@Move_Inv_ID", DGV_Requests.Rows[e.RowIndex].Cells[4].Value.ToString());
                    moveCommand.Parameters.AddWithValue("@Move_Inv_Name", DGV_Requests.Rows[e.RowIndex].Cells[1].Value.ToString());
                    moveCommand.Parameters.AddWithValue("@Move_Quantity", DGV_Requests.Rows[e.RowIndex].Cells[2].Value.ToString());
                    moveCommand.Parameters.AddWithValue("@Move_Date", DGV_Requests.Rows[e.RowIndex].Cells[5].Value.ToString());
                    moveCommand.Parameters.AddWithValue("@Move_Worker_ID", DGV_Requests.Rows[e.RowIndex].Cells[3].Value.ToString());
                    moveCommand.Parameters.AddWithValue("@Move_Status", "Починка");
                    moveCommand.ExecuteNonQuery();

                    var deleteQuery = "DELETE FROM Requests WHERE Req_ID = " + DGV_Requests.Rows[e.RowIndex].Cells["Req_ID"].Value;
                    var deleteCommand = new SqlCommand(deleteQuery, dataBase.getConnection());
                    deleteCommand.ExecuteNonQuery();
                    dataBase.closeConnection();
                    MessageBox.Show("Запрос на починку одобрен");
                }
            }
            else if (colName == "Deny")
            {
                if (MessageBox.Show("Вы уверены, что хотите отказать в запросе инвентаря", "Отказ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DGV_Requests.Rows[e.RowIndex].Cells[6].Value.ToString() == "Рассмотрение")
                    {
                        dataBase.openConnection();

                        string id = DGV_Requests.Rows[e.RowIndex].Cells["Req_Inv_ID"].Value.ToString();
                        var returnbackQuery = $"UPDATE InventoryItems SET Inv_Quantity = Inv_Quantity + @Req_Quantity WHERE Inv_ID = {id}";
                        var returnbackCommand = new SqlCommand(returnbackQuery, dataBase.getConnection());
                        returnbackCommand.Parameters.AddWithValue("@Req_Quantity", Convert.ToInt32(DGV_Requests.Rows[e.RowIndex].Cells["Req_Quantity"].Value));
                        returnbackCommand.ExecuteNonQuery();

                        var moveQuery = "INSERT INTO InventoryMovement (Move_Inv_ID, Move_Inv_Name, Move_Quantity, Move_Date, Move_Worker_ID, Move_Status) VALUES (@Move_Inv_ID, @Move_Inv_Name, @Move_Quantity, @Move_Date, @Move_Worker_ID, @Move_Status)";
                        var moveCommand = new SqlCommand(moveQuery, dataBase.getConnection());
                        moveCommand.Parameters.AddWithValue("@Move_Inv_ID", DGV_Requests.Rows[e.RowIndex].Cells[4].Value.ToString());
                        moveCommand.Parameters.AddWithValue("@Move_Inv_Name", DGV_Requests.Rows[e.RowIndex].Cells[1].Value.ToString());
                        moveCommand.Parameters.AddWithValue("@Move_Quantity", DGV_Requests.Rows[e.RowIndex].Cells[2].Value.ToString());
                        moveCommand.Parameters.AddWithValue("@Move_Date", DGV_Requests.Rows[e.RowIndex].Cells[5].Value.ToString());
                        moveCommand.Parameters.AddWithValue("@Move_Worker_ID", DGV_Requests.Rows[e.RowIndex].Cells[3].Value.ToString());
                        moveCommand.Parameters.AddWithValue("@Move_Status", "Отклонено");
                        moveCommand.ExecuteNonQuery();

                        var deleteQuery = "DELETE FROM Requests WHERE Req_ID = " + DGV_Requests.Rows[e.RowIndex].Cells["Req_ID"].Value;
                        var deleteCommand = new SqlCommand(deleteQuery, dataBase.getConnection());
                        deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Запрос успешно отклонён");
                        dataBase.closeConnection();
                    }
                    else
                    {
                        dataBase.openConnection();
                        var moveQuery = "INSERT INTO InventoryMovement (Move_Inv_ID, Move_Inv_Name, Move_Quantity, Move_Date, Move_Worker_ID, Move_Status) VALUES (@Move_Inv_ID, @Move_Inv_Name, @Move_Quantity, @Move_Date, @Move_Worker_ID, @Move_Status)";
                        var moveCommand = new SqlCommand(moveQuery, dataBase.getConnection());
                        moveCommand.Parameters.AddWithValue("@Move_Inv_ID", DGV_Requests.Rows[e.RowIndex].Cells[4].Value.ToString());
                        moveCommand.Parameters.AddWithValue("@Move_Inv_Name", DGV_Requests.Rows[e.RowIndex].Cells[1].Value.ToString());
                        moveCommand.Parameters.AddWithValue("@Move_Quantity", DGV_Requests.Rows[e.RowIndex].Cells[2].Value.ToString());
                        moveCommand.Parameters.AddWithValue("@Move_Date", DGV_Requests.Rows[e.RowIndex].Cells[5].Value.ToString());
                        moveCommand.Parameters.AddWithValue("@Move_Worker_ID", DGV_Requests.Rows[e.RowIndex].Cells[3].Value.ToString());
                        moveCommand.Parameters.AddWithValue("@Move_Status", "Отклонено");
                        moveCommand.ExecuteNonQuery();

                        var deleteQuery = "DELETE FROM Requests WHERE Req_ID = " + DGV_Requests.Rows[e.RowIndex].Cells["Req_ID"].Value;
                        var deleteCommand = new SqlCommand(deleteQuery, dataBase.getConnection());
                        deleteCommand.ExecuteNonQuery();
                        dataBase.closeConnection();
                        MessageBox.Show("Запрос на починку отклонён");
                    }
                }
            }
            LoadRequests();
        }
    }
}
