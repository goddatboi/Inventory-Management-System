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
                var updateQuery = "UPDATE Requests SET Req_Status = 'Одобрено' WHERE Req_ID = " + DGV_Requests.Rows[e.RowIndex].Cells["Req_ID"].Value;
                var updateCommand = new SqlCommand(updateQuery, dataBase.getConnection());
                updateCommand.ExecuteNonQuery();
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
