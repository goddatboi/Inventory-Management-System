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

    public partial class Inventory : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader DR;
        public Inventory()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadInventory();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        public void LoadInventory()
        {
            DGV_Inventory.Rows.Clear();
            command = new SqlCommand("SELECT * FROM InventoryItems WHERE CONCAT(Inv_ID, Inv_Name, Inv_Quantity, Inv_Price, Inv_PurchaseDate, Inv_Supplier_ID, Inv_Location,Inv_Status) LIKE '%" + searchtextBox.Text + "%'", dataBase.getConnection());
            dataBase.openConnection();
            DR = command.ExecuteReader();

            while (DR.Read())
            {
                DGV_Inventory.Rows.Add(DR[0].ToString(), DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), DR[6].ToString(), DR[7].ToString());
            }
            DR.Close();
            dataBase.closeConnection();
        }

        private void DGV_Inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGV_Inventory.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                Manage_Inventory manageInvForm = new Manage_Inventory();
                //manageInvForm.idtextBox.Text = DGV_Inventory.Rows[e.RowIndex].Cells[0].Value.ToString();
                manageInvForm.nametextBox.Text = DGV_Inventory.Rows[e.RowIndex].Cells[1].Value.ToString();
                manageInvForm.qtynumericUpDown.Text = DGV_Inventory.Rows[e.RowIndex].Cells[2].Value.ToString();
                manageInvForm.pricetextBox.Text = DGV_Inventory.Rows[e.RowIndex].Cells[3].Value.ToString();
                manageInvForm.purchdateTimePicker.Text = DGV_Inventory.Rows[e.RowIndex].Cells[4].Value.ToString();
                manageInvForm.supcomboBox.Text = DGV_Inventory.Rows[e.RowIndex].Cells[5].Value.ToString();
                manageInvForm.locationtextBox.Text = DGV_Inventory.Rows[e.RowIndex].Cells[6].Value.ToString();
                manageInvForm.statustextBox.Text = DGV_Inventory.Rows[e.RowIndex].Cells[7].Value.ToString();

                //manageInvForm.idtextBox.Enabled = false;
                manageInvForm.savebutton.Enabled = false;
                manageInvForm.updatebutton.Enabled = true;
                manageInvForm.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить инвентарный объект?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var selectedRow = DGV_Inventory.Rows[e.RowIndex];
                    int id = (int)selectedRow.Cells["Inv_ID"].Value;
                    dataBase.openConnection();
                    command = new SqlCommand($"DELETE FROM InventoryItems WHERE Inv_ID = '{id}'", dataBase.getConnection());
                    command.ExecuteNonQuery();
                    dataBase.closeConnection();
                    MessageBox.Show("Запись успешно удалена");
                }
            }
            LoadInventory();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Manage_Inventory manageInvForm = new Manage_Inventory();
            manageInvForm.savebutton.Enabled = true;
            manageInvForm.updatebutton.Enabled = false;
            manageInvForm.ShowDialog();
            LoadInventory();
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            LoadInventory();
        }
    }
}
