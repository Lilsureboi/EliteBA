namespace Models;

public class Generators
{
    private static int _accountIdCounter;
    private static int _customerIdCounter;
    private static int _transactionIdCounter;
    private static readonly Random _random = new Random();

//This method handles the generation of account Ids. This is going to be our unique identifier for each account created. The method increments the accountId by 1 for each account created
    public static int GenerateAccountId() => _accountIdCounter++;
    public static int GenerateCustomerId() => _customerIdCounter++;
    public static int GenerateTransactionId() => _transactionIdCounter++;

    public static string GenerateAccountNumber(List<Account> existingAccounts)
    {
        string number;
        do
        {
            number = _random.Next(0, 999999999).ToString("10D");
        } while (existingAccounts.Any(account => account.AccountNumber == number));

        return number;
    }
}