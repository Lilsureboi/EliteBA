namespace Models;

public class Account
{
    private double _balance;

    public int AccountId { get; set; } 
    public required string AccountNumber { get; set; }
    public required string AccountName { get; set; }
    public AccountTypeEnum AccountType { get; set; }

    public double Balance
    {
        get => _balance;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Balance cannot be negative");
                return;
            }
            _balance = value;
        }
    }

    public DateTime DateOpened { get; set; }
    public AccountStatusEnum AccountStatus { get; set; }
    public List<Transaction> Transactions { get; set; } = [];
}

public enum AccountTypeEnum
{
    Savings,
    Current,
    FixedDeposit,
    Domiciliary
}

public enum AccountStatusEnum
{
    Active,
    Dormant,
    Frozen,
    Closed
}