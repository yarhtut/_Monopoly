using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace MolopolyGame
{
    
    /// <summary>
    /// Test for the Die Class
    /// </summary>
    
    [TestFixture]
    public class _DieTest
    {
        [Test]
        public void TestDieRollRange()
        {
            Die die = new Die();
           int roll = die.roll();
           //Test that roll is between 1 & 6
            Assert.LessOrEqual(roll, 6);
           Assert.GreaterOrEqual(roll, 1);
      
        }
        [Test]
        public void TestDieRollOneThousandRange()
        {
             Die die = new Die();
            for (int i = 0; i < 1000; i++)
            {
               
                int roll = die.roll();
                Assert.LessOrEqual(roll, 6);
                Assert.GreaterOrEqual(roll, 1);
            }
        }

        [Test]
        public void testToString()
        {
            Die die = new Die();
           //test that toString converts last roll of die same as converting result of roll to string
            int roll = die.roll();
            Assert.AreEqual(roll.ToString(), die.ToString());
        }

        [Test]
        public void testRandomnessRandomOutput1Die()
        {
            Die die = new Die();
            Console.WriteLine("Random Numbers: ");
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(die.roll().ToString()); //outputs 1000 random numbers 
            }
         
        }

        [Test]
        public void testRandomnessRandomOutputManyDice()
        {
           
            Console.WriteLine("Random Numbers: ");
            for (int i = 0; i < 1000; i++)
            {
                Die die = new Die();
                Console.WriteLine(die.roll().ToString());//outputs 1000 random numbers 
            }
        }

        [Test]
        public void testRandomness1Fail1in6()
        {
            //Test randomness that should fail on average 1 in 6 times
             Die die = new Die();
            
                int numberToTest = 1;
                int roll = die.roll();
                Assert.AreNotEqual(roll, numberToTest);
                numberToTest = roll;

        }

        [Test]
        public void testRandomness2Fail1in6()
        {
            //Test randomness that should fail on average 1 in 6 times
            Die die = new Die();

            int numberToTest = 2;
            int roll = die.roll();
            Assert.AreNotEqual(roll, numberToTest);
            numberToTest = roll;
        }

        [Test]
        public void testRandomness3Fail1in6()
        {
            //Test randomness that should fail on average 1 in 6 times
            Die die = new Die();

            int numberToTest = 3;
            int roll = die.roll();
            Assert.AreNotEqual(roll, numberToTest);
            numberToTest = roll;
        }

        [Test]
        public void testRandomness4Fail1in6()
        {
            //Test randomness that should fail on average 1 in 6 times
            Die die = new Die();

            int numberToTest = 4;
            int roll = die.roll();
            Assert.AreNotEqual(roll, numberToTest);
            numberToTest = roll;
        }

        [Test]
        public void testRandomness5Fail1in6()
        {
            //Test randomness that should fail on average 1 in 6 times
            Die die = new Die();

            int numberToTest = 5;
            int roll = die.roll();
            Assert.AreNotEqual(roll, numberToTest);
            numberToTest = roll;
        }

        [Test]
        public void testRandomness6Fail1in6()
        {
            //Test randomness that should fail on average 1 in 6 times
            Die die = new Die();

            int numberToTest = 6;
            int roll = die.roll();
            Assert.AreNotEqual(roll, numberToTest);
            numberToTest = roll;
        }
        
    }
}
