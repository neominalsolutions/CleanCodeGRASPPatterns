using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._01_Cohesion
{
  public class OrderItem
  {
    public int OrderId { get; set; }
    public int Quantity { get; set; }
    public string ProductName { get; set; }

    public decimal UnitPrice { get; set; }
  }
}
