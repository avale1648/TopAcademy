using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
namespace AN1cw
{
    //ADO NET - это фреймворк для подключения, настройки и использования баз данных.
    //1. Connection;
    //2. Quering;
    //3. ReadQueryData;
    //Entity Framework

    //Классы для подключения
        //DbConnection
        //DbCommand
        //DbDataReader
        //DbDataAdapter

    //Классы для хранения
        //DataTable
        //DataSet

    //Присоединенный режим - изменения в базе данных
    //Отсоединенный режим - просмотр данных, без именений в базе данных
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
                //string str1 = "Server=AVALE1648DESKTO\\avale1648;Database=Academy;Trusted_Connection=True";
                //SqlConnection sql1 = new SqlConnection();
               //sql1.ConnectionString = str1;
            //2.
                //SqlConnection sql2 = new SqlConnection(str1);
            //3.
            SqlConnection sqlConnection = new SqlConnection("Server=AVALE1648DESKTO;Database=Academy;Trusted_Connection=True");
            sqlConnection.Open();
            string command = "select * from [Academy].[dbo].[Students]";
            Console.WriteLine($"\n1. {command}\n");
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                var v1 = sqlDataReader[0];
                var v2 = sqlDataReader[1];
                var v3 = sqlDataReader[2];
                Console.WriteLine($"{v1}|{v2}|{v3}");
            }
            sqlConnection.Close();

            SqlConnection sqlConnection2 = new SqlConnection("Server=AVALE1648DESKTO;Database=Academy;Trusted_Connection=True");
            string command2 = "select sum(Salary) from Teachers";
            Console.WriteLine($"\n2. {command2}\n");
            SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConnection2);
            sqlConnection2.Open();
            object object1 = sqlCommand2.ExecuteScalar();
            Console.WriteLine(object1 + "\n");
            


            string delete1 = "delete from Students where Students.ID = (select max(Students.ID) from Students)";
            SqlCommand sqlCommand3 = new SqlCommand(delete1, sqlConnection2);
            int result = sqlCommand3.ExecuteNonQuery();
            if (result > 0)
                Console.Write("Object sucessfuly deleted");
            sqlConnection2.Close();
            //ExecuteScalar
            //ExecuteNonQuery
            //ExecuteReader
        }
    }
}
