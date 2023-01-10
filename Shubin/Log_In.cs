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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

namespace Shubin
{
    public partial class Log_In : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        public Log_In()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Log_In_Load(object sender, EventArgs e)
        {
            Password_Log.PasswordChar = '*'; //Шифрование пароля
            Login_Log.MaxLength = 20; //Максимальная длина поля Login
            Password_Log.MaxLength= 20; //Максимальная длина поля Password
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Проверка на пустые поля
            if (string.IsNullOrEmpty(Login_Log.Text) || string.IsNullOrEmpty(Password_Log.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка на минимальную длину полей Login и Password
            if (Login_Log.Text.Length < 4 || Password_Log.Text.Length < 4)
            {
                MessageBox.Show("Логин и пароль должны состоять как минимум из 4 символов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var loginUser = Login_Log.Text;
            var passwordUser = Password_Log.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_User, login_User, password_User from Sign_Up where login_User = '{loginUser}' and password_User = '{passwordUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main mainForm = new Main();
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверный!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up registerForm = new Sign_Up();
            registerForm.Show();
            this.Hide();
        }
    }
}
