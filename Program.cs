// Program.cs

class Program
{
    static void Main()
    {
        // Create accounts
        var account1 = new Account(12345, 1000.0);
        var account2 = new Account(67890, 2000.0);

        // Create a banking system
        var bankingSystem = new BankingSystem();

        // Add accounts to the banking system
        bankingSystem.AddAccount(account1);
        bankingSystem.AddAccount(account2);

        // Perform transactions on accounts
        Transaction.PerformTransaction(account1, 500.0);
        Transaction.PerformTransaction(account2, 1000.0);

        // Display information about the banking system
        bankingSystem.DisplayAccounts();
    }
}
