using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._03_InformationExpert
{
  // müşterin sipariş no üzerinden sipariş detayı erişmek veya tüm siparişlerine erişmek
  public class Customer
  {
    public int Id { get; set; }
    public string Name { get; set; }

    // sipariş müşteriye ait olduğu için eğer müşterinin bir sipariş bilgisine erişmek isytersen bunu customer sınıfı üzerinden yapmak bu işlemi yetki customer sınıfana vermek daha anlaşılır bir kodlama olacaktır. 

    private List<Order> orders  = new List<Order>();
    // Not bu tarz durumlarda veriyi aggregate olarak çekmeliyiz
    // customer load ederken siparişlerinide ekranda göstericek ise custorm ile birlikte sipariş bilgisini programdaki entity çekmeliyiz.

    public Order GetOrderByOrderId(int orderId)
    {
      return this.orders.FirstOrDefault(x => x.OrderId == orderId);
    }

    public IReadOnlyList<Order> GetOrdersAt(DateTime StartDate, DateTime EndDate)
    {
      return this.orders.Where(x => x.OrderDate >= StartDate && x.OrderDate <= EndDate).ToList();
    }


  }
}
