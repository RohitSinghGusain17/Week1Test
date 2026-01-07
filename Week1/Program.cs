using MediSure;
using QuickMart;
namespace Week1Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region MediSure (This is the main program for PatientBill.cs)
            // bool exit=false;
            // while (!exit)
            // {
            //     Console.WriteLine("------------------------------MediSure-----------------------------");
            //     Console.WriteLine("1. Create New Bill");
            //     Console.WriteLine("2. View Last Bill");
            //     Console.WriteLine("3. Clear Last Bill");
            //     Console.WriteLine("4. Exit");  
            //     Console.WriteLine("Enter your choice: ");
            //     int choice = int.Parse(Console.ReadLine()!);
            //     PatientBill P = new PatientBill();
            //     switch (choice)
            //     {
            //         case 1:
            //             P.Register();
            //             break;
            //         case 2:
            //             P.View();
            //             break;
            //         case 3:
            //             P.Clear();
            //             break;
            //         case 4:
            //             exit=true;
            //             break;
            //     } 
            // }
            #endregion


            #region QuickMart (This is the main Program for SalesTransaction.cs)
            bool exit=false;
            while (!exit)
            {
                Console.WriteLine("------------------------------QuickMart-----------------------------");
                Console.WriteLine("1. Create New Transaction");
                Console.WriteLine("2. View Last Transaction");
                Console.WriteLine("3. Calculate Profit/Loss");
                Console.WriteLine("4. Exit");  
                Console.WriteLine("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine()!);
                SaleTransaction s = new SaleTransaction();
                switch (choice)
                {
                    case 1:
                        s.Register();
                        break;
                    case 2:
                        s.View();
                        break;
                    case 3:
                        s.Calculation();
                        break;
                    case 4:
                        exit=true;
                        break;
                } 
            }
            #endregion
        }
    }
}
