﻿using System;
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
            int i = 0;
            DGV_Requests.Rows.Clear();
            command = new SqlCommand("SELECT * FROM Requests", dataBase.getConnection());
            dataBase.openConnection();
            DR = command.ExecuteReader();

            while (DR.Read())
            {
                i++;
                DGV_Requests.Rows.Add(i, DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), DR[6].ToString());
            }
            DR.Close();
            dataBase.closeConnection();
        }

        private void DGV_Requests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGV_Requests.Columns[e.ColumnIndex].Name;

            if (colName == "Confirm")
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

                var statusQuery = "INSERT INTO InventoryStatus (St_Inv_ID, St_UpdateDate, St_Quantity, St_Status, St_RespWorker) VALUES (@St_Inv_ID, @St_UpdateDate, @St_Quantity, @St_Status, @St_RespWorker)";
                var statusCommand = new SqlCommand(statusQuery, dataBase.getConnection());
                statusCommand.Parameters.AddWithValue("@St_Inv_ID", DGV_Requests.Rows[e.RowIndex].Cells[4].Value.ToString());
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
            else if (colName == "Deny")
            {
                if (Convert.ToString(DGV_Requests.Rows[e.RowIndex].Cells["Req_Status"].Value) == "Одобрено")
                {
                    MessageBox.Show("Невозможно отказать в запросе инвентаря, так как он уже одобрен", "Отказ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("Вы уверены, что хотите отказать в запросе инвентаря", "Отказ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataBase.openConnection();
                    var deleteQuery = "DELETE FROM Requests WHERE Req_ID = " + DGV_Requests.Rows[e.RowIndex].Cells["Req_ID"].Value;
                    var deleteCommand = new SqlCommand(deleteQuery, dataBase.getConnection());
                    deleteCommand.ExecuteNonQuery();
                    dataBase.closeConnection();
                }
            }
            LoadRequests();
        }
    }
}
