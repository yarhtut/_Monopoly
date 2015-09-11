using System;
using System.Collections.Generic;
using System.Text;

namespace MolopolyGame
{
    public class UtilityFactory : PropertyFactory
    {
        public Utility create(string sName)
        {
            return new Utility(sName);
        }
    }
}
