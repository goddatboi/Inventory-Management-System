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
    public partial class Suppliers : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader DR;
        public Suppliers()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadSuppliers();
        }

        public void LoadSuppliers()
        {
            DGV_Suppliers.Rows.Clear();
            command = new SqlCommand("SELECT * FROM Suppliers WHERE CONCAT(Sup_ID, Sup_Name, Sup_Fam, Sup_Phone, Sup_Email, Sup_Address, Sup_INN) LIKE '%" + searchtextBox.Text + "%'", dataBase.getConnection());
            dataBase.openConnection();
            DR = command.ExecuteReader();

            while (DR.Read())
            {
                DGV_Suppliers.Rows.Add(DR[0].ToString(), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), DR[6].ToString());
            }
            DR.Close();
            dataBase.closeConnection();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Manage_Supplier manageSupForm = new Manage_Supplier();
            manageSupForm.savebutton.Enabled = true;
            manageSupForm.updatebutton.Enabled = false;
            manageSupForm.ShowDialog();
            LoadSuppliers();
        }

        private void DGV_Suppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGV_Suppliers.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                Manage_Supplier manageSupForm = new Manage_Supplier();
                manageSupForm.idtextBox.Text = DGV_Suppliers.Rows[e.RowIndex].Cells[0].Value.ToString();
                manageSupForm.nametextBox.Text = DGV_Suppliers.Rows[e.RowIndex].Cells[1].Value.ToString();
                manageSupForm.famtextBox.Text = DGV_Suppliers.Rows[e.RowIndex].Cells[2].Value.ToString();
                manageSupForm.phonemaskedTextBox.Text = DGV_Suppliers.Rows[e.RowIndex].Cells[3].Value.ToString();
                manageSupForm.emailtextBox.Text = DGV_Suppliers.Rows[e.RowIndex].Cells[4].Value.ToString();
                manageSupForm.addresstextBox.Text = DGV_Suppliers.Rows[e.RowIndex].Cells[5].Value.ToString();
                manageSupForm.innmaskedTextBox.Text = DGV_Suppliers.Rows[e.RowIndex].Cells[6].Value.ToString();

                manageSupForm.idtextBox.Enabled = false;
                manageSupForm.savebutton.Enabled = false;
                manageSupForm.updatebutton.Enabled = true;
                manageSupForm.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить поставщика?", "Удаление поставщика", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var selectedRow = DGV_Suppliers.Rows[e.RowIndex];
                    int id = (int)selectedRow.Cells["Sup_ID"].Value;
                    dataBase.openConnection();
                    command = new SqlCommand($"DELETE FROM Suppliers WHERE Sup_ID = '{id}'", dataBase.getConnection());
                    command.ExecuteNonQuery();
                    dataBase.closeConnection();
                    MessageBox.Show("Запись успешно удалена");
                }
            }
            LoadSuppliers();
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            LoadSuppliers();
        }
    }
}
