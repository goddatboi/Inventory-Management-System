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
        private readonly checkUserAccess _user;

        DataBaseConnection dataBase = new DataBaseConnection();

        int selectedRow;

        public Main(checkUserAccess user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _user = user;
        }

        private void isAdmin()
        {
            управлениеToolStripMenuItem.Enabled = _user.IsAdmin;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Наименование");
            dataGridView1.Columns.Add("Model", "Модель");
            dataGridView1.Columns.Add("SerialNumber", "Серийный номер");
            dataGridView1.Columns.Add("Location", "Местоположение");
            dataGridView1.Columns.Add("PurchaseDate", "Дата покупки");
            dataGridView1.Columns.Add("Status", "Состояние");
            dataGridView1.Columns.Add("IsNew", string.Empty);
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
            DGW.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetDateTime(5), record.GetString(6), RowState.ModifiedNew);
        }

        private void RefreshDataGridView(DataGridView DGW)
        {
            DGW.Rows.Clear();
            string querystring = ($"select * from InventoryItems");

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

            string searchString = $"select * from InventoryItems where concat (ID, Name, Model, SerialNumber, Location, PurchaseDate, Status) like '%" + textBox_Search.Text + "%'";

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
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from InventoryItems where ID = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var model = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var serialnum = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var location = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var purchasedate = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var status = dataGridView1.Rows[index].Cells[6].Value.ToString();

                    var changeQuery = $"update InventoryItems set Name = '{name}', Model = '{model}', SerialNumber = '{serialnum}', Location = '{location}', PurchaseDate = '{purchasedate}', Status = '{status}' where id = '{id}'";

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
            toolStripUserStatus.Text = $"{_user.Login}: {_user.Status}";
            isAdmin();
            CreateColumns();
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
                var addQuery = $"insert into InventoryItems (Name, Model, SerialNumber, Location, PurchaseDate, Status) values ('{name}','{model}','{serialnum}','{location}','{purchasedate}','{status}')";
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
    }
}
