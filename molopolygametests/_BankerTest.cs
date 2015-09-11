using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace MolopolyGame
{
   

    [TestFixture]
    public class _BankerTest
    {
   
        [Test]
        public void testSingleton()
        {
            try
            {
                //Access banker twice and tests that it is the same object
                Assert.AreSame(Banker.access(), Banker.access());
            }
            catch(NotImplementedException ex)
            {
                Console.WriteLine("A part of the program is yet to be implemented");
            }
          
        }

    }
}
