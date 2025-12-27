using System.Data.Common;

namespace QuickMart
{
    /// <summary>
    /// This is Main class SaleTransaction
    /// </summary>
    public class SaleTransaction
    {
        /// <summary>
        /// Variable Declaration
        /// </summary>
        public string? InvoiceNo;
        public string? CustomerName;
        public string? ItemName;
        public int? Quantity;
        public double PurchaseAmount;
        public double SellingAmount;
        public string? ProfitOrLossStatus;
        public double ProfitOrLossAmount;
        public double ProfitMarginPercent;
        public static SaleTransaction? LastTransaction;
        public static bool HasLastTransaction;


        /// <summary>
        /// Function to register user's transaction
        /// </summary>
        public void Register()
        {
            SaleTransaction s = new SaleTransaction();
            Console.Write("Enter Invoice Number: ");
            s.InvoiceNo=Console.ReadLine()!;
            Console.Write("Enter Customer Name: ");
            s.CustomerName = Console.ReadLine()!;
            Console.Write("Enter Item Name : ");
            s.ItemName=Console.ReadLine()!;
            Console.Write("Enter Quantity: ");
            int quantity;
            while(!int.TryParse(Console.ReadLine(),out quantity) || quantity <= 0)
            {
                Console.WriteLine("Enter Value greater than 0. ReEnter");
            }
            s.Quantity=quantity;
            Console.Write("Enter Purchase Amount: ");
            while(!double.TryParse(Console.ReadLine(),out s.PurchaseAmount) || s.PurchaseAmount<=0)
            {
                Console.WriteLine("Enter Value greater than 0. ReEnter");
            }
            Console.Write("Enter Selling Amount: ");
            while(!double.TryParse(Console.ReadLine(),out s.SellingAmount) || s.SellingAmount < 0)
            {
                Console.WriteLine("Enter Value greater than or equal to 0. ReEnter");
            }

            if (s.SellingAmount > s.PurchaseAmount)
            {
                s.ProfitOrLossStatus="PROFIT";
                s.ProfitOrLossAmount=s.SellingAmount-s.PurchaseAmount;
            }
            else if (s.SellingAmount < s.PurchaseAmount)
            {
                s.ProfitOrLossStatus="Loss";
                s.ProfitOrLossAmount=s.PurchaseAmount-s.SellingAmount;
            }
            else if (s.SellingAmount == s.PurchaseAmount)
            {
                ProfitOrLossStatus="Break-Even";
                ProfitOrLossAmount=0;
            }

            s.ProfitMarginPercent=Math.Round(s.ProfitOrLossAmount/s.PurchaseAmount*100,2);

            LastTransaction=s;
            HasLastTransaction=true;
        }

        /// <summary>
        /// Function to view Last Transaction
        /// </summary>
        public void View()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction");
            }
            else
            {
                Console.WriteLine("Your last transaction: ");
                Console.WriteLine("Invoice Number : "+LastTransaction?.InvoiceNo);
                Console.WriteLine("Customer name : "+LastTransaction?.CustomerName);
                Console.WriteLine("Item Name : "+LastTransaction?.ItemName);
                Console.WriteLine("Quantity : "+LastTransaction?.Quantity);
            }
        }

        /// <summary>
        /// Fucntion to recalculate last transaction
        /// </summary>
        public void Calculation()
        {   

            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction");
            }
            else
            {
                if (LastTransaction?.SellingAmount > LastTransaction?.PurchaseAmount)
            {
                LastTransaction?.ProfitOrLossStatus="PROFIT";
                LastTransaction?.ProfitOrLossAmount=LastTransaction.SellingAmount-LastTransaction.PurchaseAmount;
            }
            else if (LastTransaction?.SellingAmount < LastTransaction?.PurchaseAmount)
            {
                LastTransaction.ProfitOrLossStatus="Loss";
                LastTransaction.ProfitOrLossAmount=LastTransaction.PurchaseAmount-LastTransaction.SellingAmount;
            }
            else if (LastTransaction?.SellingAmount == LastTransaction?.PurchaseAmount)
            {
                LastTransaction?.ProfitOrLossStatus="Break-Even";
                LastTransaction?.ProfitOrLossAmount=0;
            }

            LastTransaction?.ProfitMarginPercent=Math.Round(LastTransaction.ProfitOrLossAmount/LastTransaction.PurchaseAmount*100,2);
            }

            Console.WriteLine("Calculation Done");
        }
    }
}