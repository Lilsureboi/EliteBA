namespace Models;

public class Generators
{
    private static int _accountIdCounter;
    private static int _customerIdCounter;
    private static int _transactionIdCounter;
    private static readonly Random _random = new Random();

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