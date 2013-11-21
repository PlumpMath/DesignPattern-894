using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.AbstractFactory
{
    public class AbstractText:AbstractComponent
    {
        protected override void OnPaint()
        {
            System.Console.WriteLine("绘制抽象的文本");
        }
    }
}
