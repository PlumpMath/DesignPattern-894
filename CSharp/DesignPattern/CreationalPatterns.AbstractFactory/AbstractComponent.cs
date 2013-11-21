using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.AbstractFactory
{
   public abstract class AbstractComponent:IComponent
    {


       protected abstract void OnPaint();
       

       public void Paint()
       {
           OnPaint();
       }
    }
}
