using System;
using System.Collections;
using System.Text;
using NUnit.Framework;

namespace MolopolyGame
{
   
    /// <summary>
    /// Test for the Trader class
    /// </summary>
    
    [TestFixture]
    public class _TraderTest
    {
        

        [Test]
        public void nameAccessorModifierTest()
        {
            Trader t = new Trader();
            t.setName("Banker");
            Assert.AreEqual(t.getName(), "Banker");
          
        }

        [Test]
        public void balanceAccessorModifierTest()
        {
            Trader t = new Trader();
            t.setBalance(1050);
            Assert.AreEqual(t.getBalance(), 1050);

        }

        [Test]
        public void constructorTest()
        {          
            Trader t2 = new Trader("Player2", 1500);

            Assert.AreEqual(t2.getName(), "Player2");
            Assert.AreEqual(t2.getBalance(), 1500);
        }

        [Test]
        public void receiveTest()
        {
            Trader t = new Trader("Player1", 1500);

            t.receive(55);

            Assert.AreEqual(t.getBalance(), 1555);
        }

        [Test]
        public void payTest()
        {
            Trader t = new Trader("Player1", 1500);

            t.pay(111);

            Assert.AreEqual(t.getBalance(), 1500 - 111);
        }

        [Test]
        public void checkBankrupt()
        {
            Trader t = new Trader("Player1", 1500);

            try
            {
                t.checkBankrupt();//nothing should happen (no exception thrown)
                
            }
            catch (Exception ex)
            {
                Console.Write("Exception Thrown: " + ex.Message);
                Assert.Fail();
            }

        }

        [Test]
        public void checkBankruptZero()
        {
            Trader t = new Trader("Player1", 0);

            try
            {
                t.checkBankrupt();//exception should be thrown so should not run follwing line
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Console.Write("Exception Thrown: " + ex.Message);
            }
        }

        [Test]
        public void checkBankruptNegative()
        {
            Trader t = new Trader("Player1", -100);
            try
            {
                t.checkBankrupt();//exception should be thrown so should not run follwing line
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Console.Write("Exception Thrown: " + ex.Message);
            }

        }

        [Test]
        public void outputToString()
        {
            Trader t = new Trader();

            Console.Write(t);
        }


        [Test]
        public void propetyTest()
        {
            Trader t = new Trader();
            Property p = new Property("Queen Street");
            t.obtainProperty(ref p);
            Assert.Contains(p, t.getPropertiesOwned());

        }
    }
}
