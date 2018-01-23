using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2ssdqub.DAL
{
    class ContactDAL
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public static int Add(string forename, string surname)
        {
            using (var handle = new SqlConnection(connectionString))
            {
                handle.Open();
                var cmd = new SqlCommand(string.Format("INSERT INTO Contacts (Forename, Surname) VALUES ('{0}', '{1}')", forename, surname), handle);
                int rows = cmd.ExecuteNonQuery();
                handle.Close();
                return rows;
            }
        }
    }
}
