using System;
using System.Collections.Generic;
using System.Text;

namespace MolopolyGame
{
     public class PropertyFactory
    {
         public Property create(string name)
         {
             return new Property(name);
         }
    }
}
