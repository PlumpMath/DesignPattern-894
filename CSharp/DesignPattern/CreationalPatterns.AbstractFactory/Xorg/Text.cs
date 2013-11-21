using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns.AbstractFactory.Xorg
{
   public class Text:AbstractText
    {
       protected override void OnPaint()
       {
           System.Console.WriteLine("绘制Xorg的Text");
           System.Console.WriteLine("开始绘制自定义Text");
           base.OnPaint();
           System.Console.WriteLine("结束绘制自定义Text");
       }
    }
}
