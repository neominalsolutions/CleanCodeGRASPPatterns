using GRASPPatterns._07_Indirection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._08_Controller
{
  // UI => Application Service => Bussiness Service

  // Request, Response Controller katmanında yöntemeyi tavsiye ediyor
  // Validation, Application Exception, Authorization, Session Application katmanı
  // Bussiness Logic => Bussiness Service
  public class UserController // Use Case yapılarını çalıştırmak için ilk isteğin atılıdğı katman kullanıcı etkileşim katmanı olan Controller => Use Case yapıları Application katmanına aktarılır.
  {
    private UserApplicationService userApplicationService;

    public UserController()
    {
      userApplicationService = new UserApplicationService();
    }

    public void Create(UserCreateDto dto)
    {
      userApplicationService.CreateUser(dto);
    }
  }
}
