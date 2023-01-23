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
    public partial class Manage_Supplier : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        SqlCommand command = new SqlCommand();
        public Manage_Supplier()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите сохранить этого поставщика", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new SqlCommand("INSERT INTO Suppliers (Sup_ID, Sup_Name, Sup_Fam, Sup_Phone, Sup_Email, Sup_Address, Sup_INN) VALUES (@Sup_ID, @Sup_Name, @Sup_Fam, @Sup_Phone, @Sup_Email, @Sup_Address, @Sup_INN)", dataBase.getConnection());
                    command.Parameters.AddWithValue("@Sup_ID", idtextBox.Text);
                    command.Parameters.AddWithValue("@Sup_Name", nametextBox.Text);
                    command.Parameters.AddWithValue("@Sup_Fam", famtextBox.Text);
                    command.Parameters.AddWithValue("@Sup_Phone", phonemaskedTextBox.Text);
                    command.Parameters.AddWithValue("@Sup_Email", emailtextBox.Text);
                    command.Parameters.AddWithValue("@Sup_Address", addresstextBox.Text);
                    command.Parameters.AddWithValue("@Sup_INN", innmaskedTextBox.Text);
                    dataBase.openConnection();
                    command.ExecuteNonQuery();
                    dataBase.closeConnection();
                    MessageBox.Show("Поставщик успешно добавлен");
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
                if (MessageBox.Show("Вы уверены, что хотите обновить данные поставщика", "Обновление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new SqlCommand($"UPDATE Suppliers SET Sup_Name = @Sup_Name, Sup_Fam = @Sup_Fam, Sup_Phone = @Sup_Phone, Sup_Email = @Sup_Email, Sup_Address = @Sup_Address, Sup_INN = @Sup_INN WHERE Inv_ID = '{idtextBox.Text}'", dataBase.getConnection());
                    command.Parameters.AddWithValue("@Sup_Name", nametextBox.Text);
                    command.Parameters.AddWithValue("@Sup_Fam", famtextBox.Text);
                    command.Parameters.AddWithValue("@Sup_Phone", phonemaskedTextBox.Text);
                    command.Parameters.AddWithValue("@Sup_Email", emailtextBox.Text);
                    command.Parameters.AddWithValue("@Sup_Address", addresstextBox.Text);
                    command.Parameters.AddWithValue("@Sup_INN", innmaskedTextBox.Text);
                    dataBase.openConnection();
                    command.ExecuteNonQuery();
                    dataBase.closeConnection();
                    MessageBox.Show("Данные поставщика успешно обновлёны");
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
            nametextBox.Text = "";
            famtextBox.Text = "";
            phonemaskedTextBox.Text = "";
            emailtextBox.Text = "";
            addresstextBox.Text = "";
            innmaskedTextBox.Text = "";
        }

        private void Manage_Supplier_Load(object sender, EventArgs e)
        {

        }
    }
}
