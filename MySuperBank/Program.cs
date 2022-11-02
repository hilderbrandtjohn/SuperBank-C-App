// See https://aka.ms/new-console-template for more information
using MySuperBank;

var account = new BankAccount("John", 10000);

Console.WriteLine($"Account {account.Number} was created for {account.Owner} with a balance of {account.Balance}");
account.MakeWithdrawal(300, DateTime.Now, "Chocolate");
//Console.WriteLine(account.Balance);

////test that the initial balances must be positive.
//try
//{
//	var invalidAccount = new BankAccount("invalid", -55);
//}
//catch (ArgumentOutOfRangeException e)
//{
//	Console.WriteLine("Exeption caught creating account with negative balance");
//	Console.WriteLine(e.ToString());
	
//}

account.MakeWithdrawal(50, DateTime.Now, "Sausage");
//Console.WriteLine(account.Balance);
Console.WriteLine(account.GetAccountDetails());