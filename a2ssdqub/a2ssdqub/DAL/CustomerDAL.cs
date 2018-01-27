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
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sqlQuery = string.Format("INSERT INTO CUSTOMERS VALUES('{0}','{1}','{2}')",fname,dob,sex);
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);
                int rowsAffected = insertCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
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
                SqlCommand getAll = new SqlCommand("SELECT CUSTOMERS.CustID,CUSTOMERS.Forename FROM CUSTOMERS", connection);

                SqlDataReader reader = getAll.ExecuteReader();

                // iterate through the result set; each iteration is 1 record
                while(reader.Read())
                {
                    // LEFT = Key, RIGHT = Value to be visible on combo box, formed into a string by implicit cast
                    customerDetails.Add(int.Parse(reader[0].ToString()),reader[0] + "," + reader[1]);
                }

                connection.Close();

                return customerDetails;
            }
        }
    }
}
