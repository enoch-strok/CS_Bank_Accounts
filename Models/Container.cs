using System.Collections.Generic;

namespace CS_Bank_Accounts.Models
{
    public class Container
    {
        public User User { get; set; }
        public List<User> AllUsers { get; set; }
        public LoginUser UserLogin { get; set; }
        public Transaction OneTransaction { get; set; }
        public List<Transaction> AllTransactions { get; set; }

        // public Deposit OneDeposit {get; set;}

        // public List<Deposit> AllDeposits {get; set;}
    }
}