using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._07_Indirection
{
  public interface IUserApplicationService
  {
    void CreateUser(UserCreateDto reques);
  }

  public class UserApplicationService: IUserApplicationService
  {
    private UserBussinessService bussinessService;
    private UserValidator userValidator;

    public UserApplicationService()
    {
      bussinessService = new UserBussinessService();
      userValidator = new UserValidator();
    }

    // Kullanıcı bilgileri veri tabanına kaydedilmesi için repo
    // email ile bilgilendirme
    // validasyon kontrolü
    public void CreateUser(UserCreateDto request)
    {

      userValidator.Validate(request);

      Console.WriteLine("User Create Request");
      var user = new User();
      user.AccountEnabled = false;
      user.Email = request.Email;
      bussinessService.CreateAccount(user, request.Password);
    }
  }
}
