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
            InitializeComponent();

            this.conn = conn;
           

            //string connection = "server=localhost;database=adil;user=root;password=";
            //MySqlConnection con = new MySqlConnection(connection);
            ////con.Open();
            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from ID_Factory";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, conn);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView.DataSource = bSource;
            
      
        }

        

        








}

}
