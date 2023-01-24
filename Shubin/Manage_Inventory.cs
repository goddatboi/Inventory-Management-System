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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shubin
{
    public partial class Manage_Inventory : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader DR;
        public Manage_Inventory()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadSupplier();
        }

        private void Clear()
        {
            nametextBox.Text = "";
            qtynumericUpDown.Value = 0;
            pricetextBox.Text = "";
            locationtextBox.Text = "";
            statustextBox.Text = "";
        }

        public void LoadSupplier()
        {
            supcomboBox.Items.Clear();
            command = new SqlCommand("SELECT Sup_ID FROM Suppliers", dataBase.getConnection());
            dataBase.openConnection();
            DR = command.ExecuteReader();

            while (DR.Read())
            {
                supcomboBox.Items.Add(DR[0].ToString());
            }

            DR.Close();
            dataBase.closeConnection();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите сохранить этот инвентарный объект", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new SqlCommand("INSERT INTO InventoryItems (Inv_Name, Inv_Quantity, Inv_Price, Inv_PurchaseDate, Inv_Supplier_ID, Inv_Location, Inv_Status) VALUES (@Inv_Name, @Inv_Quantity, @Inv_Price, @Inv_PurchaseDate, @Inv_Supplier_ID, @Inv_Location, @Inv_Status)", dataBase.getConnection());
                    command.Parameters.AddWithValue("@Inv_Name", nametextBox.Text);
                    command.Parameters.AddWithValue("@Inv_Quantity", qtynumericUpDown.Value);
                    command.Parameters.AddWithValue("@Inv_Price", Convert.ToInt32(pricetextBox.Text));
                    command.Parameters.AddWithValue("@Inv_PurchaseDate", Convert.ToDateTime(purchdateTimePicker.Value));
                    command.Parameters.AddWithValue("@Inv_Supplier_ID", Convert.ToInt32(supcomboBox.Text));
                    command.Parameters.AddWithValue("@Inv_Location", locationtextBox.Text);
                    command.Parameters.AddWithValue("@Inv_Status", statustextBox.Text);
                    dataBase.openConnection();
                    command.ExecuteNonQuery();
                    dataBase.closeConnection();
                    MessageBox.Show("Объект успешно добавлен");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите обновить этот инвентарный объект", "Обновление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new SqlCommand($"UPDATE InventoryItems SET Inv_Name = @Inv_Name, Inv_Quantity = @Inv_Quantity, Inv_Price = @Inv_Price, Inv_PurchaseDate = @Inv_PurchaseDate, Inv_Supplier_ID = @Inv_Supplier_ID, Inv_Location = @Inv_Location, Inv_Status = @Inv_Status WHERE Inv_ID = '{idtextBox.Text}'", dataBase.getConnection());
                    command.Parameters.AddWithValue("@Inv_Name", nametextBox.Text);
                    command.Parameters.AddWithValue("@Inv_Quantity", qtynumericUpDown.Value);
                    command.Parameters.AddWithValue("@Inv_Price", Convert.ToInt32(pricetextBox.Text));
                    command.Parameters.AddWithValue("@Inv_PurchaseDate", Convert.ToDateTime(purchdateTimePicker.Value));
                    command.Parameters.AddWithValue("@Inv_Supplier_ID", Convert.ToInt32(supcomboBox.Text));
                    command.Parameters.AddWithValue("@Inv_Location", locationtextBox.Text);
                    command.Parameters.AddWithValue("@Inv_Status", statustextBox.Text);
                    dataBase.openConnection();
                    command.ExecuteNonQuery();
                    dataBase.closeConnection();
                    MessageBox.Show("Объект успешно обновлён");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Manage_Inventory_Load(object sender, EventArgs e)
        {

        }
    }
}
