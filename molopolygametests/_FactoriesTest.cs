using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace MolopolyGame
{
    [TestFixture]
    public class _FactoriesTest
    {
        [Test]
        public void testProperty()
        {
            //create instance of factory
            PropertyFactory f = new PropertyFactory();
            //create instance from factory
            Property p = f.create("Property");
            //check that it is right type
            Type t = new Property().GetType();
            Assert.IsInstanceOfType(t, p);
        }

        [Test]
        public void testLuck()
        {
            //create instance of factory
            LuckFactory f = new LuckFactory();
            //create instance from factory
            Luck p = f.create("Luck", true, 50) ;
            //check that it is right type
            Type t = new Luck().GetType();
            Assert.IsInstanceOfType(t, p);
        }

        [Test]
        public void testResidential()
        {
            //create instance of factory
            ResidentialFactory f = new ResidentialFactory();
            //create instance from factory
            Residential p = f.create("Residential", 50, 50, 50);
            //check that it is right type
            Type t = new Residential().GetType();
            Assert.IsInstanceOfType(t, p);
        }

        [Test]
        public void testTransport()
        {
            //create instance of factory
            TransportFactory f = new TransportFactory();
            //create instance from factory
            Transport p = f.create("Transport");
            //check that it is right type
            Type t = new Transport().GetType();
            Assert.IsInstanceOfType(t, p);
        }

        [Test]
        public void testUtility()
        {
            //create instance of factory
            UtilityFactory f = new UtilityFactory();
            //create instance from factory
            Utility p = f.create("Utility");
            //check that it is right type
            Type t = new Utility().GetType();
            Assert.IsInstanceOfType(t, p);
        }
    }
}
