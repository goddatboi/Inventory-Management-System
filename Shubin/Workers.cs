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
    public partial class Workers : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader DR;
        public Workers()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadWorkers();
        }

        private void Workers_Load(object sender, EventArgs e)
        {

        }

        public void LoadWorkers()
        {
            DGV_Workers.Rows.Clear();
            command = new SqlCommand("SELECT * FROM Workers", dataBase.getConnection());
            dataBase.openConnection();
            DR = command.ExecuteReader();

            while (DR.Read())
            {
                DGV_Workers.Rows.Add(DR[0].ToString(), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), DR[6].ToString(), DR[7].ToString());
            }
            DR.Close();
            dataBase.closeConnection();
        }

        private void DGV_Workers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGV_Workers.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                Manage_Worker manageWorkForm = new Manage_Worker();
                manageWorkForm.idtextBox.Text = DGV_Workers.Rows[e.RowIndex].Cells[0].Value.ToString();
                manageWorkForm.nametextBox.Text = DGV_Workers.Rows[e.RowIndex].Cells[1].Value.ToString();
                manageWorkForm.famtextBox.Text = DGV_Workers.Rows[e.RowIndex].Cells[2].Value.ToString();
                manageWorkForm.deprtextBox.Text = DGV_Workers.Rows[e.RowIndex].Cells[3].Value.ToString();
                manageWorkForm.posttextBox.Text = DGV_Workers.Rows[e.RowIndex].Cells[4].Value.ToString();

                manageWorkForm.updatebutton.Enabled = true;
                manageWorkForm.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить работника?", "Удаление работника", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var selectedRow = DGV_Workers.Rows[e.RowIndex];
                    int id = (int)selectedRow.Cells["Work_ID"].Value;
                    dataBase.openConnection();
                    command = new SqlCommand($"DELETE FROM Workers WHERE Work_ID = '{id}'", dataBase.getConnection());
                    command.ExecuteNonQuery();
                    dataBase.closeConnection();
                    MessageBox.Show("Работник успешно удален");
                }
            }
            LoadWorkers();
        }
    }
}
