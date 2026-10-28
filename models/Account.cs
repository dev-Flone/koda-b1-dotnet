namespace Banking.Console.Models;

public class Account
{
    public string AccountNumber { get; set; }
    public string OwnerName { get; set; }
    public decimal Balance { get; set; }

    public Account(string accountNumber, string ownerName, decimal balance)
    {
        if (string.IsNullOrWhiteSpace(accountNumber))
        {
            throw new ArgumentException("Account Number harus diisi");
        }
        if (string.IsNullOrWhiteSpace(ownerName))
        {
            throw new ArgumentException("Owner Name harus diisi");
        }
        if (balance < 0)
        {
            throw new ArgumentException("Balance harus positif");
        }

        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = balance;

    }

    public string getInformation()
    {
        return ($"Account Number: {AccountNumber}\nName: {OwnerName}\nBalance: Rp.{Balance}");
    }
}