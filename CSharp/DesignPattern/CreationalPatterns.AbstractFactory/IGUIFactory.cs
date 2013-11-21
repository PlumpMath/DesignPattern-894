using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.AbstractFactory
{
   public interface IGUIFactory
    {
       AbstractButton CreateButton();
       AbstractText CreateText();
    }
}
