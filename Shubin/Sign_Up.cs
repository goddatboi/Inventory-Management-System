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
            // Проверка на пустые поля
            if (string.IsNullOrEmpty(Login_Reg.Text) || string.IsNullOrEmpty(Password_Reg.Text))
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

            var loginUser = Login_Reg.Text;
            var passwordUser = Password_Reg.Text;

            string querystring = $"insert into Workers(login_User, password_User) values ('{loginUser}', '{passwordUser}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
        private Boolean checkUser()
        {
            var loginUser = Login_Reg.Text;
            var passwordUser = Password_Reg.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_User, login_User, password_User from Workers where login_User = '{loginUser}' and password_User = '{passwordUser}'";

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
