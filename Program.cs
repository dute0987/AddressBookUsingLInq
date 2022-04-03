using System;
using System.Data;
namespace AddressBookLinq
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressDataBook using LINQ !");
            ////UC 2
            AdressDataBook adb = new AdressDataBook();
            //adb.AddData();

            //UC 3
            adb.DisplayAddressBook(table);
        }
    }
}