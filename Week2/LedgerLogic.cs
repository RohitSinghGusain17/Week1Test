namespace Week2Test
{
    /// <summary>
    /// Generic Class Ledger with T : Transaction 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Ledger<T> where T : Transaction
    {
        private List<T> entries = new List<T>(); // list to add all transaction
        /// <summary>
        /// Function to add transaction Entry in entries
        /// </summary>
        /// <param name="entry"></param>
        public void AddEntry(T entry)
        {
            entries.Add(entry);
        }

        /// <summary>
        /// Function to get transactions by their date
        /// </summary>
        /// <param name="date"></param>
        /// <returns>will return the transactions list</returns>
        public List<T> GetTransactionbyDate(DateTime date)
        {
            List<T> result = new List<T>(); //list created to store the date matched transactions
            foreach (T i in entries)
            {
                if (i.Date.Date == date.Date)
                {
                    result.Add(i);
                }
            }

            return result;
        }

        /// <summary>
        /// Function To get All Transactions
        /// </summary>
        /// <returns>list of all transactions</returns>
        public List<T> GetAllTransactions()
        {
            return entries;
        }
    }

    /// <summary>
    /// Static class created for amount calculation
    /// </summary>
    public static class Calculation
    {
        /// <summary>
        /// static Function to Calculate Total Amount
        /// </summary>
        /// <returns>total of amount</returns>
        public static decimal CalculateTotal<T>(List<T> entries) where T : Transaction
        {
            decimal total=0;//total of amount
            foreach(T i in entries)
            {
                total+=i.Amount;
            }

            return total;
        }
    }
}