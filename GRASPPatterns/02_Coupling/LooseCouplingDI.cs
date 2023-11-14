using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._02_Coupling
{
  public class LooseCouplingDI
  {
    private readonly ILogger logger;

    // bir sınıfın ihtiyaç duyduğu bağımlılık constructor üzerinden diğer sınıfa parametere olarak geçiliyorsa buna dependency injection pattern diyoruz. // 3 farklı şekilde oluyor. en yaygın kullanım contructor injection, 2. kullanım propertyInjection 3. kullanım method injection
    public LooseCouplingDI(ILogger logger) // constructor injection
    {
      this.logger = logger;
    }

    public void Do()
    {
      this.logger.Log("Loglama yapıld");
    }

    public void DoWithLog(ILogger logger) // method di injection
    {
      logger.Log("Method Injection");
    }
  }
}
