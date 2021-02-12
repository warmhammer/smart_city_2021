using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=localhost;user=root;database=baumancitydb;password=123;";

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            //RE-Comment action you need, bitch

            //USER LOG/REG*************************************************************************************************************-----------------------------------------------*



            ////getting a password using email
            //string useremail = "'nik.trashko@gmail.com';";
            //string sql = "SELECT `password` from user where email =" + useremail;
            //MySqlCommand command = new MySqlCommand(sql, conn);
            //string pass = command.ExecuteScalar().ToString();

            ////gettin a mailcode using email
            //string useremail = "'nik.trashko@gmail.com';";
            //string sql = "SELECT `mailcode` from user where email =" + useremail;
            //MySqlCommand command = new MySqlCommand(sql, conn);
            //string mailcode = command.ExecuteScalar().ToString();

            //////updating a mailcode using email ///NEEDTO DEBAG
            //string usermail = "'nik.trashko@gmail.com';";
            //string newmailcode = "7777";
            //string sql = "UPDATE user SET `mailcode` =" + newmailcode + " WHERE `email`=" + usermail;
            //MySqlCommand command = new MySqlCommand(sql, conn);
            //command.ExecuteNonQuery();


            ////Insert a user data
            //string useremail = "'nik.trashko@gmail.com';";
            //string v1 = "10"; //ID
            //string v2 = "0"; //ADMIN FLAG
            //string v3 = "'tester'";//username
            //string v4 = "'tester@gmail.com'";//usermail
            //string v5 = "'password'"; //password
            //string v6 = "7564"; //mailcode
            //string sql = "Insert into user values (" + v1 + "," + v2 + "," + v3 + "," + v4 + "," + v5 + "," + v6 + ");";
            //MySqlCommand command = new MySqlCommand(sql, conn);
            //command.ExecuteNonQuery();

            ////Checking ADMIN flag
            //string useremail = "'nik.trashko@gmail.com';";
            //string sql = "SELECT `adminflag` from user where email =" + useremail; // 1-admin, 0-user
            //MySqlCommand command = new MySqlCommand(sql, conn);
            //string flagik = command.ExecuteScalar().ToString();


            ////conn.Close();

            ////DATA WORK**************************************************************************************************************************-------------------------------------*

            ////Checking what id inside'a'cell
            //string cellid = "2;";
            //string sql = "SELECT `ID_Factory_ID Factory` from category where `cell id` =" + cellid;
            //MySqlCommand command = new MySqlCommand(sql, conn);
            //string pass = command.ExecuteScalar().ToString();

            //Checking what item with id
            string cellid = "1;";
            string sql = "SELECT `Название` from ID_Factory where `ID Factory` =" + cellid;
            MySqlCommand command = new MySqlCommand(sql, conn);
            string pass = command.ExecuteScalar().ToString();



            ////Delete item using cell
            //string cellnumber = "65"
            //string sql = "DELETE from ID_FACTORY where cell= " + cellnumber ;
            //MySqlCommand command = new MySqlCommand(sql, conn);
            //command.ExecuteNonQuery();

            ////Changing cell 
            //string itemid = "1205;";
            //string sql = "SELECT `cell id` from category where `ID_Factory_ID Factory` =" + itemid;
            //MySqlCommand command = new MySqlCommand(sql, conn);
            //string pass = command.ExecuteScalar().ToString();

            ////NEW  item in cell
            //string newid = "1200;";
            //string cellid = "1;";
            //string sql = "UPDATE category SET `ID_Factory_ID Factory` =" + newid + "WHERE `cell id` =" + cellid;
            //MySqlCommand command = new MySqlCommand(sql, conn);
            //command.ExecuteNonQuery();


            ////Whaiting flag
            //string cellid = "1;";
            //string newflag = "1";//WHAITING FLAG 0-empty cell; 1 - full cell; 2 - waiting cell;
            //string sql = "UPDATE category SET `cell id` =" + newflag + "WHERE `cell id` =" + cellid ;
            //MySqlCommand command = new MySqlCommand(sql, conn);
            //command.ExecuteNonQuery();








            conn.Close();
        }
    }
}