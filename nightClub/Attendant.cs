using System;
using System.Collections.Generic;

namespace nightClub
{
    public class Attendant
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Here is a list of our current drink and their prices.");
            Console.WriteLine("1 : Drink NAme : Andre --Price : 1000");
            Console.WriteLine("2 : Drink NAme : smenorf --Price : 3000");
            Console.WriteLine("3 : Drink NAme : beer --Price : 2500");
            Console.WriteLine("4 : Drink NAme : don-Simon --Price : 3500");
            Console.WriteLine("select 1,2,3 or 4 to make your order.");
            
        }
        public static void PresentBillToCustomer()
        {
            BarMan.PresentCalculatedPrice();   
        }

        public static void GettingOrderFromCustomer(int choice)
        {
            BarMan.GetCalculatedPrice(choice);

        }
    }
}