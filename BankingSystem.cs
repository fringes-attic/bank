// BankingSystem.cs

using System;
using System.Collections.Generic;

public class BankingSystem
{
    private List<Account> accounts = new List<Account>();

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public void DisplayAccounts()
    {
        Console.WriteLine("All Accounts in the Banking System:");
        foreach (var account in accounts)
        {
            account.Display();
        }
    }
}
