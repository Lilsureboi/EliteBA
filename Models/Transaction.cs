namespace Models;

public class Transaction
{
    private double _amount;
    public int TransactionId { get; set; }
    public int AccountId { get; set; }
    public TransactionTypeEnum TransactionType { get; set; }

    public double Amount
    {
        get => _amount;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Amount cannot be negative.");
                return;
            }

            _amount = value;
        }
    }

    public string? Narration { get; set; }
    public DateTime Date { get; set; }
    public int? RecipientAccountId { get; set; } // For transfers (not applicable to deposit and withdrawal)
    public decimal BalanceAfter { get; set; }
}

public enum TransactionTypeEnum
{
    Deposit,
    Withdrawal,
    TransferIn,
    TransferOut
}