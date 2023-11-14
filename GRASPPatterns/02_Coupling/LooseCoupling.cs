using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._02_Coupling
{
  public class LooseCoupling
  {
    private readonly ILogger logger;

    public LooseCoupling(LoggerType loggerType)
    {
      logger = LoggerFactory.getLogger(loggerType);
    }

    public void Do()
    {
      logger.Log("Logla");
    }
  }
}
