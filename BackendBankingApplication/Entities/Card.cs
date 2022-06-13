using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendBankingApplication.Entities
{
    public class Card
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
    }
}
