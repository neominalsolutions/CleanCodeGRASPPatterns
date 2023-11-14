// See https://aka.ms/new-console-template for more information
using GRASPPatterns._02_Coupling;
using GRASPPatterns._03_InformationExpert;
using GRASPPatterns._04_Creator;
using GRASPPatterns._05_Polymorphism;
using GRASPPatterns._07_Indirection;
using GRASPPatterns._09_LawOfDemetter;

Console.WriteLine("Hello, World!");

LooseCoupling lp = new LooseCoupling(LoggerType.TextLogger);
lp.Do();

TightCoupling tp = new TightCoupling();
tp.Do();

// DI ile zayıf bağlılık

LooseCouplingDI lpD = new LooseCouplingDI(new MyTextLogger());
lpD.Do(); // Text Logger ile işlem yap
lpD.DoWithLog(new MyDbLogger()); // DbLogger ile işlem.


Customer customer = new Customer();
var order = customer.GetOrderByOrderId(1);
var orders = customer.GetOrdersAt(DateTime.Now, DateTime.Now.AddDays(10));


// Geneneksel durumalarda
var invoice = new Invoice();
invoice.InvoiceDate = DateTime.Now;
invoice.InvoiceNumber = "213213";

//var invoiceItem = new InvoiceItem("Ürün-2", 3, 45);
//invoiceItem.Price = 56;

invoice.AddItem(1, 20, "Ürün-1");
invoice.AddItem(2, 20, "Ürün-2");

// Polymophisim yakalamak için nesneye is soruları soralım
// Button is Component ?
// Button ekrana nasıl çizdirilir ?

Button btn = new Button();
btn.Draw();

SwitchButton sb = new SwitchButton();
sb.Draw();


// ApplicationUser isteğini atalım.
// Application Katmanı üzerinden UserBussinessService katmanına bağlanıp UserCreateDto değerlerini validayon kontrolü yapıp, işlemi tetikledik.
var dto = new UserCreateDto();
dto.Email = "Ali";
dto.Password = "24234";

var service = new UserApplicationService();
service.CreateUser(dto);

// Bussiness katmanına direk bağlantı
var user = new User();
user.Email = "Ali";

var userBussinessService = new UserBussinessService();
userBussinessService.CreateAccount(user, "24332432");


// LawOfDemetter Yasası Bad Practice Yanlış kullanım
// Müşterinin hesap dökümünü almak istiyorum
var bankCustomer = new BankCustomer();
// bir nesnenin alt düğümlerine kadar inip law of demetter yasasını ihlal ediyoruz.
bankCustomer.Accounts.FirstOrDefault(x => x.AccountNumber == "2143213").Transactions.ToList();

bankCustomer.Accounts.FirstOrDefault(x => x.AccountNumber == "2143213").Transactions.Add().ToList();

bankCustomer.Accounts.FirstOrDefault(x => x.AccountNumber == "23233").Balance = 15;

// Law of Demetter yasası nesneler arasındaki ilişkileri sınırlandırma yasası, ve aynı zamanda bir nesnenin alt düğümlerine erişimi kısıtlama
var currentAccount = bankCustomer.GetCurrentAccount("3242343242");
// currentAccount.Balance = 56; koda müdahaleyi sınırladık
// hesap dökümünü getir.

// hesaba ait döküme erişimi sınırlandırdık.
var transactions2 = bankCustomer.GetCurrentAccount("23432432").GetTransactions();

bankCustomer.GetCurrentAccount("432432432").GetTransactions();



