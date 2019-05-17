using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUIForm_20150507
{
    [Serializable]
    public class Record
    {
        public int Account { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Balance { get; set; }

        public Record()
            :this(0,string.Empty,string.Empty,0M)
        {
        }

        public Record(int account,string firstname,string lastname, decimal balance)
        {
            Account = account;
            FirstName = firstname;
            LastName = lastname;
            Balance = balance;
        }
    }
}
