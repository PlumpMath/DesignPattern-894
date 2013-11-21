using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CreationalPatterns.AbstractFactory.Mac;
using CreationalPatterns.AbstractFactory.Xorg;

namespace CreationalPatterns.AbstractFactory
{
   public class Console
    {
       public static void Wrtie()
       {
           var factory = CreateFactory("Mac");

           Print(factory);

           factory = CreateFactory("Xorg");

           Print(factory);
       }

       private static void Print(IGUIFactory factory)
       {
           var button = factory.CreateButton();
           var text = factory.CreateText();

           button.Paint();
           text.Paint();
       }

       private static IGUIFactory CreateFactory(string factoryName)
       {
           switch (factoryName)
           {
               case "Mac":
                   return new MacGUIFactory();
               case "Xorg":
                   return new OrgGUIFactory();
           }

           return null;
       }
    }
}
