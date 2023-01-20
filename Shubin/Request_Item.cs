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


namespace Shubin
{
    public partial class Request_Item : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        int selectedRow;
        public Request_Item()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ReadSingleRow(DataGridView DGW, IDataRecord record)
        {
            DGW.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), record.GetDateTime(4), record.GetInt32(5), record.GetInt32(6), record.GetString(7), record.GetString(8), RowState.ModifiedNew);
        }

        private void RefreshDataGridView(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string querystring = ($"SELECT * FROM InventoryItems");

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(DGW, reader);
            }
            reader.Close();

        }

        private void Request_Item_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shubinDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.shubinDataSet.Workers);
            RefreshDataGridView(DGV_Inventory);
        }

        private void DGV_Inventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_Inventory.Rows[selectedRow];


                nametextBox.Text = row.Cells[1].Value.ToString();
                qtynumericUpDown.Text = row.Cells[2].Value.ToString();
            }
        }

        private void new_requestButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DGV_Inventory.Rows[selectedRow];

            var id = row.Cells[0].Value.ToString();
            var name = nametextBox.Text;
            var qty = qtynumericUpDown.Text;
            var date = requestdateTimePicker.Text;
            var worker = workercomboBox.Text;
            

            try
            {
                dataBase.openConnection();
                var addQuery = $"INSERT INTO Requests (Req_ID, Req_Name, Req_Quantity, Req_Worker_ID, Req_Inv_ID, Req_Date, Req_Status) VALUES (2,'{name}','{qty}','{worker}','{id}','{date}', 'Рассмотрение')";
                var command = new SqlCommand(addQuery, dataBase.getConnection());
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запрос успешно отправлен!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataBase.closeConnection();
            }
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DGV_Inventory.Rows[selectedRow];

            var id = row.Cells[0].Value.ToString();
            var name = nametextBox.Text;
            var qty = qtynumericUpDown.Text;
            var date = requestdateTimePicker.Value;
            var worker = workercomboBox.SelectedValue;

            try
            {
                dataBase.openConnection();
                var addQuery = "INSERT INTO Requests (Req_ID, Req_Name, Req_Quantity, Req_Worker_ID, Req_Inv_ID, Req_Date, Req_Status) VALUES (@id, @name, @qty, @worker, @inv_id, @date, 'Рассмотрение')";
                var command = new SqlCommand(addQuery, dataBase.getConnection());
                // временно пока нет триггера 
                command.Parameters.AddWithValue("@id", 2);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@qty", qty);
                command.Parameters.AddWithValue("@worker", worker);
                command.Parameters.AddWithValue("@inv_id", id);
                command.Parameters.AddWithValue("@date", date);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запрос успешно отправлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataBase.closeConnection();
            }
        }
    }
}
