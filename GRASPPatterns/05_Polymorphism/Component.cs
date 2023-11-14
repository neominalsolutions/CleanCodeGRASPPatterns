using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._05_Polymorphism
{
  // Inheritance
  public abstract class Component
  {
    public string Name { get; set; }
    public string Text { get; set; }

    public event EventHandler Click;

    // nasıl bir component ekrana çizileceğine dair bilgimiz yok.
    public abstract void Draw();


  }
}
