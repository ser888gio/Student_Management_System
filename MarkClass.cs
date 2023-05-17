using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Server
{
    internal class MarkClass
    {
        DBConnect connect = new DBConnect();

        public bool insertMark(int student_id, string course_name, int znamk, string Description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `marks`(`StudentID`, `Course_Name`, `Mark`, `Description`) VALUES (@stid, @cn, @mark, @description)", connect.getconnection);

            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = student_id;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = course_name;
            command.Parameters.Add("@mark", MySqlDbType.Int32).Value = znamk;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = Description;

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

        public DataTable getMark(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool checkMark(int stdID, string course_name)
        {
            DataTable table = getMark(new MySqlCommand("SELECT * FROM `marks` WHERE `StudentID` = " + stdID + " AND `Course_Name` = '" + course_name + "'"));
            if (table.Rows.Count>0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateMark(string course_name, int student_id,  int znamk, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `marks` SET `Mark` = @mark, `Description` = @description WHERE `StudentID`=@stid AND `Course_Name` =@course_name", connect.getconnection);
            command.Parameters.Add("@course_name", MySqlDbType.VarChar).Value = course_name;
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = student_id;
            command.Parameters.Add("@mark", MySqlDbType.Int32).Value = znamk;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = desc;

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

        public bool deleteMark(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `marks` WHERE `StudentID`=@stid", connect.getconnection);

            command.Parameters.Add("@stid", MySqlDbType.Int32).Value= id;

            connect.openConnect();
            if (command.ExecuteNonQuery()==1)
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

        public DataTable searchMark(string searchData)
        {
            MySqlCommand command = new MySqlCommand("SELECT marks.StudentID, student.Student_FN, student.Student_LN,marks.Mark, marks.Description FROM student INNER JOIN marks ON marks.StudentID = student.StudentID WHERE CONCAT(student.Student_FN, student.Student_LN, marks.Course_Name) LIKE '%" + searchData + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
