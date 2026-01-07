using Week2Test;

public class Program
{
    public static void Main(string[] args)
    {
        #region Ledger<IncomeTransaction>
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();//object of Ledger class
        IncomeTransaction income = new IncomeTransaction();//object of IncomeTransaction class
        income.Id=1;
        income.Amount=500;
        income.Date=DateTime.Now;
        income.Description="Description of Income's MainCash transaction";
        income.Source="MainCash";
        incomeLedger.AddEntry(income); //income Entry Added
        #endregion

        #region Ledger<ExpenseTransaction>
        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();//object of Ledger class
        ExpenseTransaction expense1 = new ExpenseTransaction();//object of ExpenseTransaction class
        expense1.Id=2;
        expense1.Amount=20;
        expense1.Date=DateTime.Now;
        expense1.Description="Description of Stationary transaction";
        expense1.Category="Stationery";
        expenseLedger.AddEntry(expense1); //expense Entry Added

        ExpenseTransaction expense2 = new ExpenseTransaction();//object of ExpenseTransaction
        expense2.Id=3;
        expense2.Amount=15;
        expense2.Date=DateTime.Now;
        expense2.Description="Description of Snacks transaction";
        expense2.Category="Team Snacks";
        expenseLedger.AddEntry(expense2); //expense Entry Added
        #endregion

        #region Amount Calculation
        decimal TotalIncome=Calculation.CalculateTotal(incomeLedger.GetAllTransactions());//total income calculation
        decimal TotalExpense=Calculation.CalculateTotal(expenseLedger.GetAllTransactions());//total expense calculation
        Console.WriteLine("Total Expense is : "+TotalExpense);
        Console.WriteLine("Total Income is : "+TotalIncome);
        Console.WriteLine("Net balance is : "+(TotalIncome-TotalExpense));//Balance remaining
        #endregion

        #region Summary
        List<Transaction> transactions = new List<Transaction>();//List created to store all transaction(using for summary)
        transactions.AddRange(incomeLedger.GetAllTransactions());//adding transactions in list
        transactions.AddRange(expenseLedger.GetAllTransactions());//adding transactions in list

        Console.WriteLine("\n................All Transaction Summary..............");
        foreach(Transaction i in transactions)
        {
            Console.WriteLine(i.GetSummary()); //Getting summary of transaction
        }
        #endregion
    }
}