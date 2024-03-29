﻿using System;
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
    public partial class Sign_Up : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        public Sign_Up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {
            Password_Reg.PasswordChar = '*'; //Шифрование пароля
            Login_Reg.MaxLength = 20; //Максимальная длина поля Login
            Password_Reg.MaxLength = 20; //Максимальная длина поля Password
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Login_Reg.Text) || string.IsNullOrEmpty(Password_Reg.Text) || string.IsNullOrEmpty(nametextBox.Text) || string.IsNullOrEmpty(famtextBox.Text) || string.IsNullOrEmpty(deprtextBox.Text) || string.IsNullOrEmpty(posttextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка на минимальную длину полей Login и Password
            if (Login_Reg.Text.Length < 4 || Password_Reg.Text.Length < 4)
            {
                MessageBox.Show("Логин и пароль должны состоять как минимум из 4 символов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var name = nametextBox.Text;
            var fam = famtextBox.Text;
            var depr = deprtextBox.Text;
            var post = posttextBox.Text;
            var loginUser = Login_Reg.Text;
            var passwordUser = Password_Reg.Text;

            string querystring = $"INSERT INTO Workers(Work_Name, Work_Fam, Work_Department, Work_Post, Login_User, Password_User, Is_Admin) VALUES ('{name}','{fam}','{depr}','{post}','{loginUser}', '{passwordUser}', 0)";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            if (!checkUser())
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Аккаунт успешно создан!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Log_In loginForm = new Log_In();
                    this.Hide();
                    loginForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Аккаунт не создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataBase.closeConnection();
            }
            dataBase.closeConnection();
        }
        private Boolean checkUser()
        {
            var loginUser = Login_Reg.Text;
            var passwordUser = Password_Reg.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"SELECT Work_ID, Login_User, Password_User, Is_Admin FROM Workers WHERE Login_User = '{loginUser}' and Password_User = '{passwordUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
