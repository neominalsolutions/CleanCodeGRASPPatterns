using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._01_Cohesion
{
  // 3 farklı sipariş sonrası müşteriye mail atma
  // sipariş oluşurken promosyon kod ile indirim yapma
  // sipariş submit etme onaylama
  public class LowCohesionOrderService
  {
    // Siparişin onaylanması siparişe ait bir sorumluluk mu
    public void SubmitOrder(Order order, string promationCode)
    {
      ApplyPromitionCode(promationCode);
      // Order DB ekle
      SendEmail(order.CustomerName, "Siparişiniz oluştu");
    }

    // promosyon koduna göre indirim uygulama siparişe ait bir sorumluluk mu
    private void ApplyPromitionCode(string promationCode)
    {

    }

    // Email gönderme sorumluluğu siparişe ait bir sorumluluk mu
    private void SendEmail(string email, string message)
    {

    }

  }
}
