// See https://aka.ms/new-console-template for more information
using MySuperBank;

var account = new BankAccount("John", 10000);

Console.WriteLine($"Account {account.Number} was created for {account.Owner} with a balance of {account.Balance}");
