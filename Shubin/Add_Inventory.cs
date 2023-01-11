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
using System.Reflection;
using System.Xml.Linq;

namespace Shubin
{
    public partial class Add_Inventory : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        public Add_Inventory()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Add_Inventory_Load(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var name = textBox_Name.Text;
            var model = textBox_Model.Text;
            var serialnum = textBox_SerialNumber.Text;
            var location = textBox_Location.Text;
            var purchasedate = dateTimePicker_PurchaseDate.Value;
            var status = textBox_Status.Text;

            try
            {
                dataBase.openConnection();
                var addQuery = $"insert into InventoryItems (Name, Model, SerialNumber, Location, PurchaseDate, Status) values ('{name}','{model}','{serialnum}','{location}','{purchasedate}','{status}')";
                var command = new SqlCommand(addQuery, dataBase.getConnection());
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запись успешно добавлена!");
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
