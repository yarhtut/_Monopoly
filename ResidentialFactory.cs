using System;
using System.Collections.Generic;
using System.Text;

namespace MolopolyGame
{
    public class ResidentialFactory : PropertyFactory
    {
        public Residential create(string sName, decimal dPrice, decimal dRent, decimal dHouseCost, ConsoleColor dColor = ConsoleColor.White)
        {
            return new Residential(sName, dPrice, dRent, dHouseCost, dColor);
        }
    }
}

