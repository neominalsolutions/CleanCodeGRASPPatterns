using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._01_Cohesion
{
  public class EmailService
  {
    public void SendEmail(string to, string messsage) { }
  }

  public class DiscountService
  {
    public void ApplyPromationCode(string promationCode) { }
  }

  public class OrderRepository
  {
    public void Save(Order order) { }
  }

  public class HighCohesionOrderService
  {
    // field en üstde yazılmalı
    private readonly EmailService emailService;
    private readonly DiscountService discountService;
    private readonly OrderRepository orderRepository;

    // constructor
    public HighCohesionOrderService()
    {
      emailService = new EmailService();
      discountService = new DiscountService();
      orderRepository = new OrderRepository();
    }

    public HighCohesionOrderService(EmailService emailService, DiscountService discountService, OrderRepository orderRepository)
    {
      this.emailService = emailService;
      this.discountService = discountService;
      this.orderRepository = orderRepository;
    }

    // Method kullanımı

    /// <summary>
    /// Promosyon kod varsa promosyon koda göre indirim sağlanıp, sipariş verilir
    /// </summary>
    /// <param name="order"></param>
    /// <param name="promationCode"></param>
    public void SubmitOrder(Order order, string promationCode)
    {
      if (!string.IsNullOrEmpty(promationCode))
        discountService.ApplyPromationCode(promationCode);

      orderRepository.Save(order);

      emailService.SendEmail(order.CustomerName, "Siparişiniz başarılı");

    }
  }
}
