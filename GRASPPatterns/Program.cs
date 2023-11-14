// See https://aka.ms/new-console-template for more information
using GRASPPatterns._02_Coupling;

Console.WriteLine("Hello, World!");

LooseCoupling lp = new LooseCoupling(LoggerType.TextLogger);
lp.Do();

TightCoupling tp = new TightCoupling();
tp.Do();

// DI ile zayıf bağlılık

LooseCouplingDI lpD = new LooseCouplingDI(new MyTextLogger());
lpD.Do(); // Text Logger ile işlem yap
lpD.DoWithLog(new MyDbLogger()); // DbLogger ile işlem.
