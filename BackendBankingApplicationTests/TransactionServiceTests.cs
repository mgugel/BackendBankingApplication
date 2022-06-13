using BackendBankingApplication.Entities;
using BackendBankingApplication.Services;

namespace BackendBankingApplicationTests
{
    [TestClass]
    public class TransactionServiceTests
    {
        [TestMethod]
        public void TestTransaction()
        {
            AccountInfo accountInfo = new AccountInfo();
            accountInfo.Balance = 100;
            decimal transactionAmount = 10;

            TransactionService transactionService = new TransactionService();
            transactionService.CreateTransaction(accountInfo, transactionAmount);

            Assert.AreEqual(90,accountInfo.Balance);
        }
    }
}