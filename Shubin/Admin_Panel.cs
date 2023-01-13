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

namespace Shubin
{
    public partial class Admin_Panel : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public Admin_Panel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Login", "Логин");
            dataGridView1.Columns.Add("Password", "Пароль");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText= "IsAdmin";
            dataGridView1.Columns.Add(checkColumn);
        }

        private void ReadSingleRow(IDataRecord record)
        {
            dataGridView1.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetBoolean(3));
        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();

            string queryString = $"select * from RegUsers;";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(reader);
            }
            reader.Close();

            database.closeConnection();

        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGridView();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                var isAdmin = dataGridView1.Rows[index].Cells[3].Value.ToString();

                var changeQuery = $"UPDATE RegUsers SET Is_Admin = '{isAdmin}' WHERE ID = '{id}'";

                var command = new SqlCommand(changeQuery, database.getConnection());
                command.ExecuteNonQuery();
            }

            database.closeConnection();

            RefreshDataGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
            var deleteQuery = $"DELETE FROM RegUsers WHERE ID = '{id}'";

            var command = new SqlCommand(deleteQuery, database.getConnection());
            command.ExecuteNonQuery();

            database.closeConnection();

            RefreshDataGridView();
        }
    }
}
