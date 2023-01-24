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
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms.DataVisualization.Charting;

namespace Shubin
{
    public partial class Statistics : Form
    {
        int approved = 0, rejected = 0, repair = 0;

        DataBaseConnection dataBase = new DataBaseConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader DR;

        private Word.Application application;
        Word.Document document;
        Word.Paragraph wordparagraph;
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
                DGV_InventoryMovement.Rows.Add(i, DR[2].ToString(), DR[3].ToString(), DR[6].ToString(), DR[1].ToString(), DR[4].ToString(), DR[5].ToString());

                if (DR[6].ToString() == "Одобрено")
                {
                    approved++;
                }
                else if (DR[6].ToString() == "Отклонено")
                {
                    rejected++;
                }
                else if (DR[6].ToString() == "Починка")
                {
                    repair++;
                }
            }
            DR.Close();
            dataBase.closeConnection();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            if (approved > 0)
            {
                chart1.Series[0].Points.AddXY("Одобрено", approved);
            }
            if (rejected > 0)
            {
                chart1.Series[0].Points.AddXY("Отклонено", rejected);
            }
            if (repair > 0)
            {
                chart1.Series[0].Points.AddXY("Починено", repair);
            }
        }

        private void outdocButton_Click(object sender, EventArgs e)
        {
            application = new Word.Application();
            //Создание нового документа Word
            document = application.Documents.Add();
            //Добавление нового параграфа документа Word
            wordparagraph = document.Paragraphs.Add();
            wordparagraph.Range.Text = "Статистика движения инвентаря";
            //Красный цвет шрифта
            wordparagraph.Range.Font.Color = Word.WdColor.wdColorDarkRed;
            //Размер 20, Тип шрифта Arial, курсив и полужирный
            wordparagraph.Range.Font.Size = 18;
            wordparagraph.Range.Font.Name = "Arial";
            wordparagraph.Range.Font.Italic = 1;
            wordparagraph.Range.Font.Bold = 1;
            wordparagraph = document.Paragraphs.Add();
            wordparagraph = document.Paragraphs[2];
            wordparagraph.Range.Font.Color = Word.WdColor.wdColorBlack;
            wordparagraph.Range.Font.Bold = 1;
            wordparagraph.Range.Font.Italic = 0;
            Word.Range wordrange = wordparagraph.Range;
            Word.Table wordtable1 = document.Tables.Add(wordrange, 4, 2);
            wordtable1.Range.Font.Size = 14;
            wordtable1.Range.Font.Name = "Arial";
            wordtable1.Range.Font.Bold = 1;
            wordtable1.Borders.Enable = 1;
            wordtable1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            wordtable1.Borders.OutsideLineWidth = Word.WdLineWidth.wdLineWidth050pt;
            wordtable1.Borders.OutsideColor = Word.WdColor.wdColorBlack;
            wordtable1.Cell(1, 1).Range.Text = "Одобрено";
            wordtable1.Cell(1, 2).Range.Text = approved.ToString();
            wordtable1.Cell(2, 1).Range.Text = "Отклонено";
            wordtable1.Cell(2, 2).Range.Text = rejected.ToString();
            wordtable1.Cell(3, 1).Range.Text = "Починки";
            wordtable1.Cell(3, 2).Range.Text = repair.ToString();
            wordtable1.Cell(4, 1).Range.Text = "Итого:";
            wordtable1.Cell(4, 2).Range.Text = (approved + rejected + repair).ToString();
            //Открыть созданный документ
            application.Visible = true;
        }
    }
}
