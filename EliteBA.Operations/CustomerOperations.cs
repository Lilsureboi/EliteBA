using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EliteBA.DB;
using EliteBA.Models;
using static EliteBA.Models.Account;

namespace EliteBA.Operations;

public class CustomerOperations
{
    public class AccountDetails
    {

        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public string AccountStatus { get; set; }
        public string AccountType { get; set; }

    }

    public AccountDetails GetAccountDetails(string accountNumber, string email, int phoneNumber)
    {
        AccountDetails accountDetails = new AccountDetails();

        Account account;

        if (string.IsNullOrEmpty(accountNumber))
        {
            Console.WriteLine("Please enter account Number");
        }

        else
        {
            account = Tables.accounts.SingleOrDefault(acct => acct.AccountNumber == accountNumber);

            if (!string.IsNullOrEmpty(account?.AccountNumber))
            {
                accountDetails.AccountId = account.AccountId;
                accountDetails.AccountNumber = account.AccountNumber;
                accountDetails.AccountName = account.AccountName;
                accountDetails.AccountStatus = account.AccountStatus.ToString();
                accountDetails.AccountType = account.AccountType.ToString();
                accountDetails.Balance = account.Balance;
            }

        }

        return accountDetails;
    }

}