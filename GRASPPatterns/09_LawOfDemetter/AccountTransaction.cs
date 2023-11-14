using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._09_LawOfDemetter
{
  public enum AccountTransactionType
  {
    Deposit,
    WithDraw
  }

  public class AccountTransaction
  {
    public decimal Amount { get; set; } // -1000, +1000
    public AccountTransactionType Type { get; set; }
  }
}
