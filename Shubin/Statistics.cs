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
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace Shubin
{
    public partial class Statistics : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader DR;
        public Statistics()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadInventoryMovement();
        }

        private void LoadInventoryMovement()
        {
            dataBase.openConnection();
            int i = 0;
            DGV_InventoryMovement.Rows.Clear();
            command = new SqlCommand($"SELECT * FROM InventoryMovement", dataBase.getConnection());
            DR = command.ExecuteReader();

            while (DR.Read())
            {
                i++;
                DGV_InventoryMovement.Rows.Add(i, DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), DR[6].ToString());
            }
            DR.Close();
            dataBase.closeConnection();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            var chart = new Chart();
            chart.ChartAreas.Add("ChartArea1");
            chart.Legends.Add("Legend1");
            chart.Series.Add("Series1");

            chart.Series["Series1"].ChartType = SeriesChartType.Pie;

            foreach (DataGridViewRow row in DGV_InventoryMovement.Rows)
            {
                string moveStatus = row.Cells["Move_Status"].Value.ToString();
                chart.Series["Series1"].Points.AddXY(moveStatus, 1);
            }

            chart.Series["Series1"].IsValueShownAsLabel = true;
            chart.Series["Series1"].LabelFormat = "{#.#}%";
            chart.Series["Series1"].LegendText = "#VALX #PERCENT{P1}";

            chart.Dock = DockStyle.Fill;
            this.Controls.Add(chart);
        }
    }
}
