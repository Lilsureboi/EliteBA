using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteBA.DB;
using EliteBA.Models;
using EliteBA.Utilities;

namespace EliteBA.Operations
{
    public class TransactionRequestDto
    {

        public TransactionRequestDto()
        {
            TransactionId = Generators.GenerateTransactionId();
            TransactionType = TransactionType.Transfer;
            DateCreated = DateTime.Now;

        }

        public int TransactionId { get; set; }
        public string AccountNumber { get; set; }
        public TransactionType TransactionType { get; set; }
        public double Amount { get; set; }
        [Required(ErrorMessage = "Amount is required")]
        [Range(1, double.MaxValue, ErrorMessage = "Amount must be greater than zero")]
        public string? Narration { get; set; }
        public DateTime DateCreated { get; set; }

        public int _recipientAccountId;



    }

    public class TransactionService
    {

        public TransactionService()
        {
            IsSuccess = false;
        }
        public string Message { get; set; }
        public string NewBalance { get; set; }
        public bool IsSuccess { get; set; }

        public TransactionService WithdrawAmount(TransactionRequestDto request)
        {
            var response = new TransactionService();
            try
            {
                var getAccountDetails = Tables.accounts.FirstOrDefault(x => x.AccountNumber == request.AccountNumber);

                if (getAccountDetails == null)
                {
                    response.Message = "Account not found";
                    response.NewBalance = null;
                    return response;

                }
                if (getAccountDetails.Balance < request.Amount)
                {
                    response.Message = "Insufficient balance";
                    response.NewBalance = null;
                    return response;
                }
                getAccountDetails.Balance -= request.Amount;
                response.Message = "SUCCESS";
                response.NewBalance = getAccountDetails.Balance.ToString("N");
                response.IsSuccess = true;
                return response;
            }
            catch (Exception ex)
            {

                throw;
            }


        }

    }
}
