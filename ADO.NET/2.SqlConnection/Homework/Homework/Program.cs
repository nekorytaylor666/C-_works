using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace Homework
{
    class Program
    {
        static void WriteToDB(Group group)
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["StudentsConnectionString"].ConnectionString;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"insert into groups values ('{group.Name}')";
                command.ExecuteNonQuery();
                //SqlCommand selectCommand = new SqlCommand();
                //selectCommand.Connection = connection;
                //selectCommand.CommandText = "select * from people";
                //SqlDataReader dataReader = selectCommand.ExecuteReader();
                //while (dataReader.NextResult())
                //{
                //    Person receivedPerson = new Person()
                //    {
                //        Name = dataReader["name"].ToString(),
                //        Height = dataReader["height"].ToString()
                //    };
                //}
            }
        }

        static void Main(string[] args)
        {
            Group group = new Group { Name = "Peb-113" };
            WriteToDB(group);
        }
    }
}
