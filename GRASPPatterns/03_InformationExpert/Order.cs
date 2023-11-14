using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._03_InformationExpert
{
  public class Order
  {
    public int OrderId { get; set; }
    public int CustomerId { get; set; } // CustomerId = 1 olan siparişleri getir. 
    public DateTime OrderDate { get; set; }

    public List<OrderItem> Items { get; set; }


  }
}
