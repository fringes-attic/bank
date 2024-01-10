// Account.cs

using System;

public class Account
{
    public int AccountNumber { get; private set; }
    public double Balance { get; private set; }

    public Account(int accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public bool Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            return true;
        }

        Console.WriteLine("Insufficient funds!");
        return false;
    }

    public void Display()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Balance: ${Balance}");
    }
}
