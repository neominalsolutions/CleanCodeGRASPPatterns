using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._03_InformationExpert
{
  public class OrderService
  {
    Order GetOrder(int orderId, int customerId) {
      return new Order();
    }
    List<Order> GetOrdersAt(DateTime startDate, DateTime endDate, int customerId)
    {
      return new List<Order>();
    }
  }
}
