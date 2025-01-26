using System;

class Program
{
    static void Main(string[] args)
    {

                // Create an instance of the FinanceTracker class to manage transactions.
        FinanceTracker tracker = new FinanceTracker();
        string option;

        do
        {
            Console.WriteLine("\nSimple Finance Tracker");
            Console.WriteLine("1. Add Income");
            Console.WriteLine("2. Add Expense");
            Console.WriteLine("3. View Transactions");
            Console.WriteLine("4. Show Balance");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            option = Console.ReadLine();

            switch (option)
            {
                // Add Income transaction
                case "1":
                    Console.Write("Enter description: ");
                    string incomeDesc = Console.ReadLine();
                    Console.Write("Enter amount: ");
                    decimal incomeAmt = decimal.Parse(Console.ReadLine());
                    tracker.AddTransaction("Income", incomeDesc, incomeAmt);
                    break;

                    // Add Expense transaction
                case "2":
                    Console.Write("Enter description: ");
                    string expenseDesc = Console.ReadLine();
                    Console.Write("Enter amount: ");
                    decimal expenseAmt = decimal.Parse(Console.ReadLine());
                    tracker.AddTransaction("Expense", expenseDesc, expenseAmt);
                    break;

                case "3":
                    tracker.ViewTransactions();
                    break;

                case "4":
                    tracker.ShowBalance();
                    break;

                case "5":
                    Console.WriteLine("Exiting... Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } while (option != "5");
    }
}
