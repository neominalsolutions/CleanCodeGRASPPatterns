using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._05_Polymorphism
{
  public class Button:Component
  {
    public Button()
    {
      Text = "Button";
      Name = "btn";
      Click += Button_Click;
    }

    public override void Draw()
    {
      Console.WriteLine("Button ekran çizer");
    }

    private void Button_Click(object? sender, EventArgs e)
    {
      throw new NotImplementedException();
    }
  }
}
