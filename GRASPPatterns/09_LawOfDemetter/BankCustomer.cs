using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GRASPPatterns._09_LawOfDemetter
{
  public class BankCustomer
  {
    public string Name { get; set; }
    // public List<Account> Accounts { get; set; }

    private List<Account> account = new List<Account>();



    public Account GetCurrentAccount(string accountNumber)
    {
      return this.account.FirstOrDefault(x => x.AccountNumber == accountNumber);
    }

  }
}
