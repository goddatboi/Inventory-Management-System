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
        DataBaseConnection dataBase = new DataBaseConnection();
        public Main()
        {
            InitializeComponent();
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

            SqlDataReader reader= command.ExecuteReader();

            while (reader.Read()) 
            {
                ReadSingleRow(DGW, reader);
            }
            reader.Close();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGridView(dataGridView1);
        }
    }
}
