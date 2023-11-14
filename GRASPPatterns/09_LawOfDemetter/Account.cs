using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GRASPPatterns._09_LawOfDemetter
{
  // Deposit, WithDraw
  
  public class Account
  {
    public string AccountNumber { get; set; }
    public decimal Balance { get; private set; }
    // public List<AccountTransaction> Transactions { get; set; }

    private List<AccountTransaction> transactions = new List<AccountTransaction>();



    public void WithDraw(decimal amount)
    {
      // ilgili hesaptan para çekme işlemi 
    }

    public IReadOnlyList<AccountTransaction> GetTransactions()
    {
      return this.transactions.ToList();
    }

  


  }
}
