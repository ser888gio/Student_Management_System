using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace SMS_Server
{
    internal class StudentClass
    {
        DBConnect connect = new DBConnect();

        public bool insertStudent(string first_name, string last_name, DateTime DB, string gender)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`Student_FN`, `Student_LN`, `Student_DB`, `Student_gender`) VALUES(@first_name, @last_name, @Student_DB, @gender)", connect.getconnection);

            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = first_name;
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = last_name;
            command.Parameters.Add("@Student_DB", MySqlDbType.DateTime).Value = DB;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;

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
        public DataTable getStudentList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string provPocet(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.getconnection);
            connect.openConnect();
            string pocet = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return pocet;
        }

        public string totalStudent()
        {
            return provPocet("SELECT COUNT(*) FROM student");
        }

        public string totalStudentM()
        {
            return provPocet("SELECT COUNT(*) FROM `student` WHERE `Student_Gender` = 'M'");
        }

        public string totalStudentF()
        {
            return provPocet("SELECT COUNT(*) FROM `student` WHERE `Student_Gender` = 'F'");
        }

        public DataTable searchStudent(string searchData)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`Student_FN`, `Student_LN`) LIKE '%" + searchData + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateStudent(int id, string first_name, string last_name, DateTime DB, string gender)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `Student_FN`= @first_name, `Student_LN`=@last_name, `Student_DB`=@Student_DB, `Student_Gender`= @gender WHERE `StudentID` = @id", connect.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = first_name;
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = last_name;
            command.Parameters.Add("@Student_DB", MySqlDbType.DateTime).Value = DB;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;

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

        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `StudentID`=@stid", connect.getconnection);

            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = id;

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

        public bool importStudentCSV(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] fields = reader.ReadLine().Split(',');

                        string first_name = fields[0];
                        string last_name = fields[1];
                        DateTime DB = DateTime.Parse(fields[2]);
                        string gender = fields[3];

                        insertStudent(first_name, last_name, DB, gender);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
