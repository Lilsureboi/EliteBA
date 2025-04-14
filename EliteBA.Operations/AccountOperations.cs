using EliteBA.Models;

namespace EliteBA.Operations;

public class AccountOperations
{
    private static readonly List<Account> _accounts = new List<Account>();

    /**
   * This method handles the generation of account numbers.
   * The method generates a random 10 digits string and compares with existing accounts list to ensure it is unique.
   * Returns the generated 10 digits (string)
   */
    private string GenerateAccountNumber()
    {
        Random random = new Random();
        string accountNumber = "";

        for (int i = 0; i < 10; i++)
        {
            accountNumber += random.Next(0, 9);
        }

        return accountNumber;
    }
}