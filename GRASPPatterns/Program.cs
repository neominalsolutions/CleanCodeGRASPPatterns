// See https://aka.ms/new-console-template for more information
using GRASPPatterns._02_Coupling;
using GRASPPatterns._03_InformationExpert;
using GRASPPatterns._04_Creator;
using GRASPPatterns._05_Polymorphism;

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


