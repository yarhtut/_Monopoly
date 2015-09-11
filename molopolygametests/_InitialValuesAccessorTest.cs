using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace MolopolyGame
{
    [TestFixture]
    class _InitialValuesAccessorTest
    {
        [Test]
        public void testGetBankerStartingBalancey()
        {
            Assert.AreEqual(10000, InitialValuesAccessor.getBankerStartingBalance());
            
        }

        [Test]
        public void testGetPlayerStartingBalance()
        {
            Assert.AreEqual(1500, InitialValuesAccessor.getPlayerStartingBalance());

        }
    }
}
