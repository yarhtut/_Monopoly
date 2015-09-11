using System;
using System.Collections.Generic;
using System.Text;

namespace MolopolyGame
{
    
    /// <summary>
    /// Class that loads the intials values from file
    /// </summary>
   
    public static class InitialValuesAccessor
    {
        static public decimal getBankerStartingBalance()
        {
            return 10000;
        }

        static public decimal getPlayerStartingBalance()
        {
            return 1500;
        }


    }
}

