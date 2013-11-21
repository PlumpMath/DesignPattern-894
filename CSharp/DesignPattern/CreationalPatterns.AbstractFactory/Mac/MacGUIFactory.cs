using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.AbstractFactory.Mac
{
    public class MacGUIFactory:IGUIFactory
    {
        public AbstractButton CreateButton()
        {
            return new Button();
        }

        public AbstractText CreateText()
        {
            return new Text();
        }
    }
}
