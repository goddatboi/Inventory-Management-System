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
    public partial class Make_Request : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        SqlCommand command = new SqlCommand();
        public Make_Request()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Make_Request_Load(object sender, EventArgs e)
        {

        }

        private void sendreqbutton_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            command = new SqlCommand($"SELECT Work_ID FROM Workers WHERE Login_User = '{Convert.ToString(GlobalVariables.login)}'", dataBase.getConnection());

            var name = nameTextBox.Text;
            var qty = qtyUpDown.Text;
            var worker = Convert.ToInt32(command.ExecuteScalar());
            var invid = IDtextBox.Text;
            var date = dateTimePicker.Value;

            try
            {
                var checkqty = $"SELECT Inv_Quantity FROM InventoryItems WHERE Inv_ID = '{invid}'";
                var commandqty = new SqlCommand(checkqty, dataBase.getConnection());
                var invqty = Convert.ToInt32(commandqty.ExecuteScalar());
                if (Convert.ToInt32(qty) > invqty)
                {
                    MessageBox.Show("Количество в запросе не может быть больше, чем количество в инвентаре!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var addQuery = "INSERT INTO Requests (Req_Name, Req_Quantity, Req_Worker_ID, Req_Inv_ID, Req_Date, Req_Status) VALUES (@name, @qty, @worker, @inv_id, @date, 'Рассмотрение')";
                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@qty", qty);
                command.Parameters.AddWithValue("@worker", worker);
                command.Parameters.AddWithValue("@inv_id", invid);
                command.Parameters.AddWithValue("@date", date);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запрос успешно отправлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var updateQuery = $"UPDATE InventoryItems SET Inv_Quantity = Inv_Quantity - {qty} WHERE Inv_ID = '{invid}'";
                    var updateCommand = new SqlCommand(updateQuery, dataBase.getConnection());
                    updateCommand.ExecuteNonQuery();
                    this.Hide();
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

        private void cancelreqbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
