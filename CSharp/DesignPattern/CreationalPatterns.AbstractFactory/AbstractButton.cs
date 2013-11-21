using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.AbstractFactory
{
    public  class AbstractButton:AbstractComponent
    {
        protected override void OnPaint()
        {
            System.Console.WriteLine("绘制抽象的Button");
        }
    }
}
