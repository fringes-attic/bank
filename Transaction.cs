// Transaction.cs

public static class Transaction
{
    public static void PerformTransaction(Account account, double amount)
    {
        Console.WriteLine($"Performing transaction on account {account.AccountNumber}:");
        account.Deposit(amount);
        account.Withdraw(amount / 2);
        account.Display();
    }
}
