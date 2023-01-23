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

namespace Shubin
{
    public partial class Statistics : Form
    {
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
                DGV_InventoryMovement.Rows.Add(i, DR[1].ToString(), DR[2].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), DR[6].ToString());
            }
            DR.Close();
            dataBase.closeConnection();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void outdocButton_Click(object sender, EventArgs e)
        {
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
            var row = DGV_InventoryMovement.Rows.Count;
            var col = DGV_InventoryMovement.Columns.Count;
            Word.Table wordtable1 = document.Tables.Add(wordrange, row + 1, col);
            Word.Range wordcellrange = document.Tables[1].Cell(1, 2).Range;
            wordtable1.Range.Font.Size = 12;
            wordtable1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
            wordtable1.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            wordtable1.Rows[1].Range.Font.Color = Word.WdColor.wdColorBlue;
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    //Занести заголовки полей в ячейку
                    wordcellrange = document.Tables[1].Cell(1, i + 1).Range;
                    wordcellrange.Text = DGV_InventoryMovement.Columns[i].ToString();
                    //Занести данные в ячейки
                    wordcellrange = document.Tables[1].Cell(j + 2, i + 1).Range;
                    //wordcellrange.Text = DGV_InventoryMovement.Rows[j][i].ToString();
                }
            }
        }
    }
}
