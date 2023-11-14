using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._02_Coupling
{
  public interface ILogger
  {
    void Log(string message);
  }
  public class MyTextLogger : ILogger
  {
    public void Log(string message)
    {
      Console.Write("Text logger");
    }
  }

  public class MyDbLogger : ILogger
  {
    public void Log(string message)
    {
      Console.Write("Db logger");
    }
  }


  public enum LoggerType
  {
    TextLogger,
    DbLogger
  }

  public static class LoggerFactory
  {
    public static ILogger getLogger(LoggerType type)
    {
      switch (type)
      {
        case LoggerType.TextLogger:
          return new MyTextLogger();
        case LoggerType.DbLogger:
          return new MyDbLogger();
        default:
          return new MyTextLogger();
      }
    }

  }
}
