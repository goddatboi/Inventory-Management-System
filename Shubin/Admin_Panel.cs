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
    public partial class Admin_Panel : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public Admin_Panel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {

        }
    }
}
