using System;
using System.Collections.Generic;
using System.Text;

namespace MolopolyGame
{
   
    /// <summary>
    /// This is the class for the Banker which is a singleton and can trade money
    /// </summary>
    /// 
    public class Banker : Trader
    {
        //provide an static instance of this class to create singleton
        static Banker banker;

        public Banker()
        {
            this.setName("Banker");

            this.setBalance(InitialValuesAccessor.getBankerStartingBalance());     

        }

        //method to access singleton
        public static Banker access()
        {
            if (banker == null)
                banker = new Banker();
            return banker;
        }
    }
}
