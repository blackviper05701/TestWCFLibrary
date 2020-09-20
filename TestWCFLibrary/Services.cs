using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWCFLibrary
{
    class Services : IServices
    {
        public string GetData()
        {
            return "www.portal.azure.com";
        }

        public string GetMessage(string name)
        {
            return "Hello " + name;
        }

        public string GetResult(string name, int mark1, int mark2, int mark3)
        {
            double result = mark1 + mark2 + mark3 / 3.0;
            if (result > 35.0)
                return "student:"+name+" pass";
            else
                return "student:" + name + " fail";
        }

        public int[] GetSorted(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

        public Student GetTopper(List<Student> students)
        {
            List<double> averageMarks =new List<double>();
            foreach (Student stu in students)
            {
               double average = stu.mark1 + stu.mark2 + stu.mark3 / 3.0;
                averageMarks.Add(average); 
            }
            int index=(int)averageMarks.IndexOf(averageMarks.Max());
            return students[index];
        }

        public List<DeviceUsers> GetUsers()
        {
            List<DeviceUsers> users = new List<DeviceUsers>();
           string connectionString = "Data Source=deviceskits-auth-db-server.database.windows.net;Initial Catalog=deviceskits-auth-db;User ID=sqladmin;Password=QAZxsw1234567890;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [dbo].[Userdata]",sqlConnection);
            sqlConnection.Open();
            SqlDataReader data = sqlCommand.ExecuteReader();
            while(data.Read())
            {
                DeviceUsers user = new DeviceUsers();
                user.id = int.Parse(data[0].ToString());
                user.userName = data[1].ToString();
                users.Add(user);
            }
            data.Close();
            sqlConnection.Close();
            return users;
         }
    }
}
