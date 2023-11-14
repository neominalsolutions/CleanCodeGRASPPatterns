using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._07_Indirection
{
  public class UserBussinessService
  {
    public void CreateAccount(User user, string password)
    {
      user.PasswordHash = password.Replace("@", "!");
    }
  }
}
