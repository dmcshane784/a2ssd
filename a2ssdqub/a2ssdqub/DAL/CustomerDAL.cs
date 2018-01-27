using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace a2ssdqub.DAL
{
    public class CustomerDAL
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["konekt"].ConnectionString;

        public static int AddNewCustomer(string fname, string dob, string sex)
        {
            int lastID = -1; // -1 suggests failed INSERT, looks like T for Trouble

            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("INSERT INTO CUSTOMERS OUTPUT INSERTED.CustID VALUES('{0}','{1}','{2}');", fname, dob, sex);
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);

                // int newlyMadeID = insertCommand.ExecuteNonQuery();

                lastID = (int) insertCommand.ExecuteScalar(); // returns a SCALAR (a value object), would need an int? type

                connection.Close();
                return lastID;
            }
        }

        public static int DeleteCustomer(int cusID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // No asterisk
                string sqlQuery = string.Format("DELETE FROM CUSTOMERS WHERE CustID = {0}", cusID);
                SqlCommand delCommand = new SqlCommand(sqlQuery, connection);
                int rowsAffected = delCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        public static Dictionary<int,string> GetListOfCustomers()
        {
            Dictionary<int, string> customerDetails = new Dictionary<int, string>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand getAll = new SqlCommand("SELECT * FROM CUSTOMERS ORDER BY CUSTOMERS.CustID ASC", connection);

                SqlDataReader reader = getAll.ExecuteReader();

                // iterate through the result set; each iteration is 1 record
                while(reader.Read())
                {
                    // LEFT = Key being extracted directly via IDataReader's .GetInt32() method
                    // RIGHT = Value to be visible on combo box, formed into a string by implicit cast
                    // 1st DRAFT:
                    // customerDetails.Add(reader.GetInt32(0),reader[0] + "," + reader[1]);
                    // 2nd DRAFT:
                    // NB Implicit typecasting still in use
                    string dictionaryEntry = string.Format("{0}, {1}, {2:dd/MM/yyyy}, {3}", reader[0], reader[1], reader.GetDateTime(2), reader[3]);
                    customerDetails.Add(reader.GetInt32(0),dictionaryEntry);
                }

                connection.Close();

                return customerDetails;
            }
        }
    }
}
