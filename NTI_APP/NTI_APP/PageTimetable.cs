using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NTI_APP
{
    public partial class PageTimetable : UserControl
    {
        public PageTimetable(MySqlConnection conn)
        {
            this.conn = conn;

            InitializeComponent();
        }
    }
}
