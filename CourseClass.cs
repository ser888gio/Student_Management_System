using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Server
{
    internal class CourseClass
    {
        //ENG connecting to the MySQL database
        //CZ připojení k MySQL databazi
        DBConnect connect = new DBConnect();


        //ENG method for inserting and creating a Course instance into a database
        //CZ vkladaní a vytvoření entity v databazi
        public bool insertCourse(string course_name, int hr, string desc)
        {
            MySqlCommand  command = new MySqlCommand("INSERT INTO `course`(`Course_Name`, `Course_Hour`, `Course_Desc`) VALUES (@course_name, @hr, @desc)", connect.getconnection);
           
            command.Parameters.Add("@course_name", MySqlDbType.VarChar).Value = course_name;
            command.Parameters.Add("@hr", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;

            connect.openConnect();
            if(command.ExecuteNonQuery() == 1) 
            {
                connect.closeConnect();
                return true;
            }

            else
            {
                connect.closeConnect();
                return false;
            }

        }

        public DataTable getCourse(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateCourse(int id, string course_name, int hr, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `Course_Name`=@course_name,`Course_Hour`=@hr,`Course_Desc`=@desc", connect.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@course_name", MySqlDbType.VarChar).Value = course_name;
            command.Parameters.Add("@hr", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }

            else
            {
                connect.closeConnect();
                return false;
            }

        }

        public bool deleteCourse(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE `Course_ID` = @id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }

            else
            {
                connect.closeConnect();
                return false;
            }
        }
        public DataTable searchCourse(string searchData)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`Course_Name`, `Course_Hour`, `Course_Desc`) LIKE '%" + searchData + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }
}
