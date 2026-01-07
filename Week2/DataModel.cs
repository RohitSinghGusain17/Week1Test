namespace Week2Test
{
    /// <summary>
    /// Interface to get the summary
    /// </summary>
    interface IReportable
    {
        /// <summary>
        /// Function to get summary
        /// </summary>
        /// <returns>string</returns>
        public string GetSummary();
    }

    /// <summary>
    /// abstract class Transaction that implements IReportable
    /// </summary>
    public abstract class Transaction : IReportable
    {
        public int Id {get; set;} //Id of the transaction
        public DateTime Date {get; set;} //Date of the Transaction
        public decimal Amount {get; set;} //Amount of the Transaction
        public string? Description {get; set;} //Description of the Transaction
        /// <summary>
        /// creted abstract Fucntion to Get summary
        /// </summary>
        /// <returns>string</returns>
        public abstract string GetSummary();
    }

    /// <summary>
    /// Derived Class ExpenseTransaction from Transaction
    /// </summary>
    public class ExpenseTransaction : Transaction
    {
        public string? Category; //Category(MainCash, Banktransfer)
        /// <summary>
        /// Overrided function to get the summary
        /// </summary>
        /// <returns>string with id,amount, category, description</returns>
        public override string GetSummary()
        {
            return $"Id: {Id}\n Amount: {Amount}\n Category: {Category}\n Desription: {Description}";
        }
    }

    /// <summary>
    /// Derived Class IncomeTransaction from Transaction
    /// </summary>
    public class IncomeTransaction : Transaction
    {
        public string? Source; //Source(Stationary, Snacks etc)
        /// <summary>
        /// Overrided function to get the summary
        /// </summary>
        /// <returns>string with id, amount, source, description</returns>
        public override string GetSummary()
        {
            return $"Id: {Id}\n Amount: {Amount}\n Source: {Source}\n Desription: {Description}";
        }
    }
}