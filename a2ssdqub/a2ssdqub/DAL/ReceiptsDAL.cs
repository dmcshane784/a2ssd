using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; // needed for _connectionString
using System.Data.SqlClient; // needed for SqlConnection

namespace a2ssdqub.DAL
{
    public class ReceiptsDAL // ! // Set as public
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["konekt"].ConnectionString;

        public static int AddNewReceipt(string dateOfIssue, int cusCharged, decimal totDue, string payMethod) // no primary key passed
        {
            int lastID = -1; // -1 suggests failed INSERT, looks like T for Trouble

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sqlQuery = string.Format("INSERT INTO RECEIPTS OUTPUT INSERTED.RecID VALUES('{0}','{1}','{2}','{3}');", dateOfIssue, cusCharged, totDue, payMethod);
                SqlCommand insertCommand = new SqlCommand(sqlQuery, connection);

                // get the result from the OUTPUT command in the SQL query
                lastID = (int)insertCommand.ExecuteScalar(); // returns a SCALAR (a value object), would need an int? type

                connection.Close();
                return lastID;
            }
        }


        public static int UpdateReceipt(int receiptID, string dateOfIssue, int cusCharged, decimal totDue, string payMethod)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // No asterisk
                dateOfIssue = string.Format("{0:dd/MM/yyyy}", dateOfIssue);
                string sqlQuery = string.Format("UPDATE RECEIPTS SET DateIssued='{0}',CusToBill='{1}',TotalDue='{2}',PaymentMethod='{3}' WHERE RecID = '{4}';", dateOfIssue, cusCharged, totDue, payMethod, receiptID);
                SqlCommand updateCommand = new SqlCommand(sqlQuery, connection);
                int rowsAffected = updateCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        public static int DeleteReceipt(int receiptID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // No asterisk needed in this SQL
                string sqlQuery = string.Format("DELETE FROM RECEIPTS WHERE RecID = {0}", receiptID);
                SqlCommand delCommand = new SqlCommand(sqlQuery, connection);
                int rowsAffected = delCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }



    }
}
