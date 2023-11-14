using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._02_Coupling
{
  public class TextLogger
  {
    public void Log(string message)
    {
      Console.WriteLine(message);
    }
  }

  public class DbLogger
  {
    public void Log(string message)
    {
      Console.WriteLine(message);
    }
  }
  // sıkı sıkıya bağımlılık
  // Sıkı sıkıya bağlılığı zayıflatmak için bu bağlılık koparmak için Dependecy Injection tasarım deseninden faydalanabiliriz.
  // Factory pattern ile instance alma
  public class TightCoupling
  {
    // uygulama içerisinde 100 farklı kod bloguna dağılıdığını düşünelim.
    // private TextLogger logger = new TextLogger();
    private DbLogger logger = new DbLogger();
    private TextLogger textLogger = new TextLogger();
    // bir sınıfın içerisinde başka bir sınıfın direk olarak instance alınıyor. 

    public void Do()
    {
      // yapılacak işlemlerden sonra loglama yapacağız
      logger.Log("İşlem OK");
      textLogger.Log("İşlem OK");
    }


  }
}
