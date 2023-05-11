using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// подключаемые библиотеки
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.ComponentModel.Design;
using static System.Console;
// подключение через файл API
using System.Configuration;

namespace classwork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // подключение через App.config
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["AcademyAdd"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(sqlConnectionString))
            {
                conn.Open();

                // реализация с return
                //string cmd_text = "[dbo].[stp_TeacherAdd_2]";

                //SqlCommand sqlCommand = new SqlCommand(cmd_text, conn);
                //sqlCommand.CommandType = CommandType.StoredProcedure;
                //SqlCommandBuilder.DeriveParameters(sqlCommand); // исп. статического метода

                //// создаем массив и записываем нулевое значение
                //sqlCommand.Parameters[0].Value = DBNull.Value; // return-параметр возвращается в 0 ячейку

                //sqlCommand.Parameters[1].Value = DateTime.Now.AddYears(-1).ToShortDateString();
                //sqlCommand.Parameters[2].Value = "Ella";
                //sqlCommand.Parameters[3].Value = "Chornogor";
                //sqlCommand.Parameters[4].Value = 1000.0;
                //sqlCommand.Parameters[5].Value = 15000.0;
                //sqlCommand.Parameters[6].Value = 0;
                //sqlCommand.Parameters[7].Value = 1;

                //sqlCommand.ExecuteNonQuery();
                //int newTeacher_ID = (int)sqlCommand.Parameters[0].Value;
                //WriteLine(newTeacher_ID);

                // реализация с output
                string cmd_text = "[dbo].[stp_TeacherAdd_1]";

                SqlCommand sqlCommand = new SqlCommand(cmd_text, conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(sqlCommand); // исп. статического метода

                // создаем массив и записываем нулевое значение
                sqlCommand.Parameters[8].Value = DBNull.Value; // !!! 

                sqlCommand.Parameters[1].Value = DateTime.Now.AddYears(-1).ToShortDateString();
                sqlCommand.Parameters[2].Value = "Ella_1";
                sqlCommand.Parameters[3].Value = "Chornogor_1";
                sqlCommand.Parameters[4].Value = 1000.0;
                sqlCommand.Parameters[5].Value = 15000.0;
                sqlCommand.Parameters[6].Value = 0;
                sqlCommand.Parameters[7].Value = 1;

                sqlCommand.ExecuteNonQuery();
                int newTeacher_ID = (int)sqlCommand.Parameters[8].Value;
                WriteLine(newTeacher_ID);
            }
            ReadKey();
        }
    }
}

