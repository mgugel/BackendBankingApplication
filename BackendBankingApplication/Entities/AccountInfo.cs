using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendBankingApplication.Entities
{
    public class AccountInfo
    {
        public Guid Id { get; } = Guid.NewGuid();
        //name
        public Person Person { get; set; }
        //card#--int
        public Card Card { get; set; }
        //Balance-- decimal
        public decimal Balance { get; set; }
        //last transaction amt --date time
        public DateTime LastTransaction { get; set; }

    }
}
