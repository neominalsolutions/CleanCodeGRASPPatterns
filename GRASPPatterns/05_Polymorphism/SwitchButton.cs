using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASPPatterns._05_Polymorphism
{
  public class SwitchButton:Component
  {
    public SwitchButton()
    {
      Click += SwitchButton_Click;
    }

    
    public override void Draw()
    {
      Console.WriteLine("ekrana switch buton çizer");
    }

    private void SwitchButton_Click(object? sender, EventArgs e)
    {
      throw new NotImplementedException();
    }
  }
}
