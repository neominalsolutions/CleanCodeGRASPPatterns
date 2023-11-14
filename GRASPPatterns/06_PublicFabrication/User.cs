using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._06_PublicFabrication
{
  // Bir sınıfa verilen sorumluluk artıkça araya bu sınıf ile ilgili işlemleri yönetecek başka sanal bir sınıf tanımlaması yapılması lazım. Pure Fabrication
  // UserValidator
  // UserRepository
  // UserService => PureFabrication
  // Entity yeterli olmadığı noktadaki entity fazla sorumluluğu servislere dağıtımı süreci.
  public class User
  {
    public string UserName { get; set; }
    public string Password { get; set; }

    public void ChangePassword(string password)
    {
      // PASSWORDHASH
      this.Password = password;
    }

    public void Validate()
    {

    }

    public void Save()
    {

    }

  }
}
