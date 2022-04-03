using System;
namespace AddressBookLinq
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressDataBook using LINQ !");
            //UC 2
            AdressDataBook adb = new AdressDataBook();
            adb.AddData();
        }
    }
}
