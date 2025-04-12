namespace Models;

public class Account
{
    public int AccountId { get; set; }
    public required string AccountNumber { get; set; }
    public required string AccountName { get; set; }
    public AccountTypeEnum AccountType { get; set; }
    public double Balance { get; set; } = 0.00;
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