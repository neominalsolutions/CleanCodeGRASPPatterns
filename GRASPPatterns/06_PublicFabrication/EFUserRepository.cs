using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._06_PublicFabrication
{
  public interface IRepository<T>
  {
    public void Save(T entity);
  }

  public class EFUserRepository: IRepository<User>
  {
    public void Save(User user)
    {
      Console.WriteLine("EF User Save");
    }
  }

  public class DapperUserRepository: IRepository<User>
  {
    public void Save(User user)
    {
      Console.WriteLine("Dapper User Save");
    }
  }
}
