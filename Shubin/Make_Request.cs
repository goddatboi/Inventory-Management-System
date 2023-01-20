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

            //command = new SqlCommand($"SELECT Work_ID FROM Workers WHERE Login_User = '{Convert.ToString(GlobalVariables.login)}'", dataBase.getConnection());

            var name = nameTextBox.Text;
            var qty = qtyUpDown.Text;
            var worker = workertextBox.Text;
            var invid = IDtextBox.Text;
            var date = dateTimePicker.Value;

            try
            {
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
            dataBase.openConnection();

            command = new SqlCommand($"SELECT Work_ID FROM Workers WHERE Login_User = '{Convert.ToString(GlobalVariables.login)}'", dataBase.getConnection());

            MessageBox.Show(Convert.ToString(command.ExecuteScalar()));
        }
    }
}
