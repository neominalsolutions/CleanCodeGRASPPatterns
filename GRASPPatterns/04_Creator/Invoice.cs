using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._04_Creator
{
  // Fatura Entity
  public class Invoice
  {
    // field
    private List<InvoiceItem> items = new List<InvoiceItem>();

    // property

    // GIB324324324 unique
    public string InvoiceNumber { get; set; }
    public DateTime InvoiceDate { get; set; }

    // adet,gun, hizmet, birim fiyat => 
    public IReadOnlyList<InvoiceItem> Items => items;

    public void AddItem(int quantity, decimal unitPrice, string serviceName)
    {
      // creator ile InvoiceItem nesnesinin instance yönetimi Invoice nesnesine devredilmiş oldu. 
      var item = new InvoiceItem(quantity: quantity, price: unitPrice, serviceName:serviceName);

      // tek kalemde 10000 üzeri bir rakam girişi varsa bu durumda hata ver
      if(quantity * unitPrice > 1000000)
      {
        throw new Exception("Tek kalem 100.000 den fazla tutar e-arşiv üzerinden kesilemez");
      }

      var totalSum = items.Sum(x => x.quantity * x.Price);

      if(totalSum < 5000)
      {
        throw new Exception("5000 altındaki tutarlar e-arşiv den kesilemez");
      }

      // 5000 tl altı bir tutarsa ise faturayı oluşturma

      items.Add(item);
    }
  }
}
