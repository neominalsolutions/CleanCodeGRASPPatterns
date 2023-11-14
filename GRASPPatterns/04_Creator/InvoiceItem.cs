using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._04_Creator
{
  public class InvoiceItem
  {
    public InvoiceItem(string serviceName, int quantity, decimal price)
    {
      ServiceName = serviceName;
      this.quantity = quantity;
      Price = price;
    }

    // sadece property değerleri initialize yani constructor aşamasında set edilebiliyor
    public string ServiceName { get; init; }
    public int quantity { get; init; } // hours, day, quantity
    public decimal Price { get; init; } // birim fiyat
    
  }
}
