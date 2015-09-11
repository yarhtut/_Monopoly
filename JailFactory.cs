using System;
using System.Collections.Generic;
using System.Text;

namespace MolopolyGame
{
    public class JailFactory : PropertyFactory
    {
        public Jail create(string sName,bool isJail)
        {
            return new Jail(sName, isJail);
        }
    }
}
