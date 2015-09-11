using System;
using System.Collections.Generic;
using System.Text;

namespace MolopolyGame
{
    public class TransportFactory : ResidentialFactory
    {
        public Transport create(string sName)
        {
            return new Transport(sName);
        }
    }
}
