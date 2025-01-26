using System;
// This class represents a single financial transaction (either income or expense).
class Transaction
{
    private string _type;
    private string _description;
    private decimal _amount;
    private DateTime _date;

    public Transaction(string type, string description, decimal amount, DateTime date)
    {
        _type = type;
        _description = description;
        _amount = amount;
        _date = date;
    }

        // Returns a formatted string with the details of the transaction.
    public string GetTransactionDetails()
    {
        return $"[{_date.ToShortDateString()}] {_type}: {_description} - ${_amount:F2}";
    }


        // Returns the transaction amount as positive for income and negative for expenses.
    public decimal GetAmount()
    {
        return _type == "Income" ? _amount : -_amount;
    }
}
