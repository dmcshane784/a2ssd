using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; // needed for _connectionString
using System.Data.SqlClient; // needed for SqlConnection
using a2ssdqub.Models; // to link to Models folder full of class-representations

namespace a2ssdqub.DAL
{
    public class CustomerDAL
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["konekt"].ConnectionString;

        public static int AddNewCustomer(Customer Cus)
        {
            int lastID = -1; // -1 suggests failed INSERT, looks like T for Trouble

            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // Syntax with TRANSACTION notation: with option of ROLLBACK instead of COMMIT if it fails
                // string sqlQuery = string.Format("BEGIN TRANSACTION; INSERT INTO CUSTOMERS OUTPUT INSERTED.CustID VALUES('{0}','{1}','{2}'); COMMIT;", fname, dob, sex);
                string sqlQuery = string.Format("INSERT INTO CUSTOMERS OUTPUT INSERTED.CustID VALUES('{0}','{1}','{2}');", Cus.Fname, Cus.GetFormattedDate(), Cus.Sex);
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);

                // int newlyMadeID = insertCommand.ExecuteNonQuery();

                lastID = (int) insertCommand.ExecuteScalar(); // returns a SCALAR (a value object), would need an int? type

                connection.Close();
                return lastID;
            }
        }

        public static int UpdateCustomer(Customer Cus)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // No asterisk
                string sqlQuery = string.Format("UPDATE CUSTOMERS SET Forename='{0}',DoB='{1}',Gender='{2}' WHERE CustID = '{3}';", Cus.Fname, Cus.GetFormattedDate(), Cus.Sex, Cus.CusID);
                SqlCommand updateCommand = new SqlCommand(sqlQuery, connection);
                int rowsAffected = updateCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        public static int DeleteCustomer(int cusID) // better name: DeleteCusByID
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

        public static List<Customer> GetListOfCustomers()
        {
            List<Customer> customerDetails = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Constructs the command
                SqlCommand getAll = new SqlCommand("SELECT * FROM CUSTOMERS ORDER BY CUSTOMERS.CustID ASC", connection);

                // Executes the early stages of doing the command by figuring out how many results there'll be
                // Ensures size of result set isn't egregious
                SqlDataReader reader = getAll.ExecuteReader();

                // iterate through the result set; each iteration is 1 record
                while(reader.Read())
                {
                    // This is where the mapping between the SQL data type and C# data type is controlled
                    // It adds further direction to the List and the Model
                    customerDetails.Add(new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader[3].ToString()));
                }

                connection.Close();

                return customerDetails;
            }
        }

        public static string[] GetCustomer(int cid)
        {
            string[] soughtData = { "","","" };

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand getAll = new SqlCommand(string.Format("SELECT CustID, Forename, DoB, Gender FROM CUSTOMERS WHERE CustID = {0}",cid), connection);

                SqlDataReader reader = getAll.ExecuteReader();

                if(reader.Read())
                {
                    soughtData[0] = reader[1].ToString();
                    soughtData[1] = reader.GetDateTime(2).ToString();
                    soughtData[2] = reader[3].ToString();
                }

                connection.Close();

                return soughtData;
            }
        }
    }
}
