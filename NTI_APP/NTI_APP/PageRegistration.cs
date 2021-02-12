using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NTI_APP
{
    public partial class PageRegistration : UserControl
    {
        public PageRegistration(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }
        private void linkLabelRegistration_Click(object sender, EventArgs e)
        {

        }

     

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void linkWastePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginLinkClicked.Invoke(sender, e);
        }

        private void EnteryButton_Click(object sender, EventArgs e)
        {
            string email = "'" + textBoxEmail.Text + "'";
            string password = textBoxPassword.Text;


            string errorMessage = "";

            int points = 0;

            if (password.Length < 8)
            {
                errorMessage += "Меньше 8-ми символов/"; 
                points++;
            }
            if (!password.Any(c => char.IsUpper(c)))
            {
                errorMessage += "отсутствуют заглавные буквы/";
                points++;
            }
            if (!password.Any(c => char.IsDigit(c)))
            {
                errorMessage += "отстутствуют цифры/"; 
                points++;
            }
            if (!password.Any(c => char.IsPunctuation(c)))
            {
                errorMessage += "Отстутствуют знаки препинания";
                points++;
            }

            if (points == 0)
            {
                

                string sql0 = "SELECT MAX(id) FROM user";
                MySqlCommand command0 = new MySqlCommand(sql0, conn);
                string maxid = command0.ExecuteScalar().ToString();

                int ID = Convert.ToInt32(maxid);
                ID++;
                String newID = (ID).ToString();


                //Insert a user data
                string v1 = newID; //ID
                string v2 = "0"; //ADMIN FLAG
                string v3 = "'user" + newID + "'";//username
                string v4 = email;//usermail
                string v5 = "'"+password+"'"; //password
                string v6 = "000000"; //mailcode
                string sql = "Insert into user values (" + v1 + "," + v2 + "," + v3 + "," + v4 + "," + v5 + "," + v6 + ");";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();


                //int  = rnd.Next(1000, 9999);
                ////////updating a mailcode using email ///NEEDTO DEBAG
                ////string usermail = "'nik.trashko@gmail.com';";
                ////string newmailcode = "7777";
                ////string sql = "UPDATE user SET `mailcode` =" + newmailcode + " WHERE `email`=" + usermail;
                ////MySqlCommand command = new MySqlCommand(sql, conn);
                ////command.ExecutelionQuery();





            }

            else
            {
                labelError.Text = errorMessage;
            }
    


        }






        
    }
}
