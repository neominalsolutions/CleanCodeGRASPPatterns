using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._07_Indirection
{
  // Bussiness katmanında kullanılcak olan Object
  public class User
  {
    public int Id { get; set; }
    public bool AccountEnabled { get; set; }

    public string Email { get; set; }
    public string UserName { get; set; }
    public string PasswordHash { get; set; }

    public void disable()
    {
      this.AccountEnabled = false;
    }

  }
}
