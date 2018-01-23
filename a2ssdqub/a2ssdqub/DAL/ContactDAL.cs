using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using a2ssdqub.Models;

namespace a2ssdqub.DAL
{
    class ContactDAL
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public static int Add(Contact contact)
        {
            using (var handle = new SqlConnection(connectionString))
            {
                handle.Open();
                var query = string.Format("INSERT INTO Contacts (Forename, Surname) VALUES ('{0}', '{1}')", contact.Forename, contact.Surname);
                var cmd = new SqlCommand(query, handle);
                int rows = cmd.ExecuteNonQuery();
                handle.Close();
                return rows;
            }
        }

        public static List<Contact> All()
        {
            var list = new List<Contact>();

            using (var handle = new SqlConnection(connectionString))
            {
                handle.Open();

                var cmd = new SqlCommand("SELECT * FROM Contacts", handle);
                var reader = cmd.ExecuteReader();

                while(reader.Read()) list.Add(new Contact {
                    Id = (int) reader["Id"],
                    Forename = (string) reader["Forename"],
                    Surname = (string) reader["Surname"]
                });

                handle.Close();
            }

            return list;
        }
    }
}
