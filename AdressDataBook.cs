using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    public class AdressDataBook
    {
        public void AddData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("FirstName");
            table.Columns.Add("LastName");
            table.Columns.Add("Address");
            table.Columns.Add("City");
            table.Columns.Add("State");
            table.Columns.Add("Zip");
            table.Columns.Add("PhoneNumber");
            table.Columns.Add("Emails");

        }
        public void DisplayAddressBook(DataTable table)
        {
            DataRow[] dr = table.Select();
            for (int i = 0; i < dr.Length; i++)
            {
                Console.WriteLine("First name:" + dr[i][0] + " Second Name:" + dr[i][1] + " City:" + dr[i][2] + " State:" + dr[i][3] +
                    " Zip No:" + dr[i][4] + " gmail:" + dr[i][5]);
            }
        }
    }
}
