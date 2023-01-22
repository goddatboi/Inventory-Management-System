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
using System.Drawing.Imaging;
using System.IO;

namespace Shubin
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Main : Form
    {

        DataBaseConnection dataBase = new DataBaseConnection();

        int selectedRow;

        public Main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ClearFields()
        {
            textBox_ID.Text = "";
            textBox_Name.Text = "";
            textBox_Model.Text = "";
            textBox_SerialNumber.Text = "";
            textBox_Location.Text = "";
            textBox_Status.Text = "";
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

        private void Search(DataGridView DGW)
        {
            DGW.Rows.Clear();

            string searchString = $"select * from InventoryItems where concat (Inv_ID, Inv_Name, Inv_Quantity, Inv_Price, Inv_PurchaseDate, Inv_Supplier_ID, Inv_Location, Inv_Status) like '%" + textBox_Search.Text + "%'";

            SqlCommand command = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();  

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(DGW, reader);
            }

            reader.Close();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible= false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
        }

        private void dbUpdate()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[9].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM InventoryItems WHERE Inv_ID = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var qty = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var price = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var purchasedate = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var worker_id = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var supplier_id = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var location = dataGridView1.Rows[index].Cells[7].Value.ToString();
                    var status = dataGridView1.Rows[index].Cells[8].Value.ToString();

                    var changeQuery = $"UPDATE InventoryItems SET Inv_Name = '{name}', Inv_Quantity = '{qty}', Inv_Price = '{price}', Inv_PurchaseDate = '{purchasedate}', Inv_Worker_ID = '{worker_id}', Inv_Supplier_ID = '{supplier_id}', Inv_Location = '{location}', Inv_Status = '{location}' where Inv_ID = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            dataBase.closeConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_ID.Text;
            var name = textBox_Name.Text;
            var model = textBox_Model.Text;
            var serialnum = textBox_SerialNumber.Text;
            var location = textBox_Location.Text;
            var purchasedate = dateTimePicker_PurchaseDate.Value;
            var status = textBox_Status.Text;

            //Validation for ID
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID cannot be empty!");
                return;
            }

            int result;
            if (!int.TryParse(id, out result))
            {
                MessageBox.Show("ID must be a number!");
                return;
            }

            //Validation for Name
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name cannot be empty!");
                return;
            }

            //Validation for Model
            if (string.IsNullOrEmpty(model))
            {
                MessageBox.Show("Model cannot be empty!");
                return;
            }

            //Validation for Serial Number
            if (string.IsNullOrEmpty(serialnum))
            {
                MessageBox.Show("Serial Number cannot be empty!");
                return;
            }

            //Validation for Location
            if (string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Location cannot be empty!");
                return;
            }

            //Validation for Status
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Status cannot be empty!");
                return;
            }

            //Validation for Purchase Date
            if (purchasedate > DateTime.Now)
            {
                MessageBox.Show("Purchase date must be in the past!");
                return;
            }

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, name, model, serialnum, location, purchasedate, status);
                dataGridView1.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("IsNew", string.Empty);
            RefreshDataGridView(dataGridView1);
            dataGridView1.Columns["IsNew"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                
                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Model.Text = row.Cells[2].Value.ToString();
                textBox_SerialNumber.Text = row.Cells[3].Value.ToString();
                textBox_Location.Text = row.Cells[4].Value.ToString();
                dateTimePicker_PurchaseDate.Text = row.Cells[5].Value.ToString();
                textBox_Status.Text = row.Cells[6].Value.ToString();
            }

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //Add_Inventory Add_Inv = new Add_Inventory();
            //Add_Inv.Show();

            var name = textBox_Name.Text;
            var model = textBox_Model.Text;
            var serialnum = textBox_SerialNumber.Text;
            var location = textBox_Location.Text;
            var purchasedate = dateTimePicker_PurchaseDate.Value;
            var status = textBox_Status.Text;

            try
            {
                dataBase.openConnection();
                var addQuery = $"INSERT INTO InventoryItems (Inv_Name, Inv_Quantity, Inv_Price, Inv_PurchaseDate, Inv_Worker_ID, Inv_Supplier_ID, Inv_Location, Inv_Status) values ('{name}','{model}','{serialnum}','{location}','{purchasedate}','{status}')";
                var command = new SqlCommand(addQuery, dataBase.getConnection());
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запись успешно добавлена!");
                    RefreshDataGridView(dataGridView1);
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

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGridView(dataGridView1);
            ClearFields();
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            dbUpdate();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Panel adminForm = new Admin_Panel();
            this.Hide();
            adminForm.ShowDialog();
            this.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            dbUpdate();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите сменить пользователя?", "Изменение пользователя", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Log_In loginForm = new Log_In();
                loginForm.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Выход из программы", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовой проект по МДК.04.01:\nИнформационная система учета инвентаря организации\nРазработчик: Шубин Михаил, студент группы ИП-41");
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            Request_Item requestForm = new Request_Item();
            this.Hide();
            requestForm.ShowDialog();
            this.Show();
        }
    }
}
