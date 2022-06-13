using BackendBankingApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendBankingApplication.Services
{
    public class TransactionService
    {
        //make method in the service called create transaction
        public Guid CreateTransaction(AccountInfo accountInfo, decimal transactionAmount)
        {
            var transactionId = Guid.NewGuid();
            
            accountInfo.Balance -= transactionAmount;

            return transactionId;
        }
    }
}
