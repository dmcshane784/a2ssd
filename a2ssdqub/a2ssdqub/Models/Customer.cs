using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2ssdqub.Models
{
    public class Customer
    {
        // Instance variables, as Properties
        // VISIBILITY MODIFIER??????????????????????? - private??
        public int CusID { get; set; }
        public string Fname { get; set; }
        public DateTime Dob { get; set; }
        public string Sex { get; set; }

        /*
         * This is used when creating CUSTOMER objects/records
         */
        public Customer(string fnameP, DateTime dobP, string sexP)
        {
            // CusID will be auto-generated
            Fname = fnameP;
            Dob = dobP;
            Sex = sexP;
        }

        /*
         * This is used when retrieving CUSTOMER records as objects
         */
        public Customer(int cusIDP, string fnameP, DateTime dobP, string sexP)
        {
            CusID = cusIDP;
            Fname = fnameP;
            Dob = dobP;
            Sex = sexP;
        }

        public Customer()
        {
            // default constructor lost without this
        }


        // Formatting dates into strings
        public string GetFormattedDate()
        {
            return string.Format("{0:dd/MM/yyyy}",Dob);
        }


        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", CusID, Fname, GetFormattedDate(), Sex);
        }

    }
}
