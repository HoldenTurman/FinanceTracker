using System;
using System.Collections.Generic;

// This class is responsible for managing the list of transactions and performing operations on them.
class FinanceTracker
{
    private List<Transaction> _transactions;

        // Constructor initializes the list of transactions.
    public FinanceTracker()
    {
        _transactions = new List<Transaction>();
    }



        // Adds a new transaction to the list (either income or expense).
    public void AddTransaction(string type, string description, decimal amount)
    {
        Transaction transaction = new Transaction(type, description, amount, DateTime.Now);
        _transactions.Add(transaction);
        Console.WriteLine("Transaction added successfully!");
    }


        // Displays all recorded transactions in a readable format.
    public void ViewTransactions()
    {
        if (_transactions.Count == 0)
        {
            Console.WriteLine("No transactions recorded yet.");
            return;
        }

        Console.WriteLine("\nTransactions:");
        foreach (var transaction in _transactions)
        {
            Console.WriteLine(transaction.GetTransactionDetails());
        }
    }

    public void ShowBalance()
    {
        decimal balance = 0;
        foreach (var transaction in _transactions)   // Iterate through the list of transactions and sum up their amounts.
        {
            balance += transaction.GetAmount();
        }

        Console.WriteLine($"\nCurrent Balance: ${balance:F2}");
    }
}
