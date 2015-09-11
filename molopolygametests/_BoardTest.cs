using System;
using System.Collections;
using System.Text;
using NUnit.Framework;

namespace MolopolyGame
{
    [TestFixture]
    public class _BoardTest
    {
        [Test]
        public void testSingleton()
        {
            //Access twice and tests that it is the same object
            Assert.AreSame(Board.access(), Board.access());
        }

        [Test]
        public void testAddGetPlayer()
        {
            Player p = new Player("Go");
            Board.access().addPlayer(p);

            //check that the player is equal to a new player with name "Go"
            Assert.AreEqual(Board.access().getPlayer("Go"), p);


        }
        [Test]
        public void addGetProperty()
        {
            Property p = new Property();
            Board.access().addProperty(p);

            Assert.AreEqual(p, Board.access().getProperty(0));

            ArrayList props = Board.access().getProperties();

            CollectionAssert.Contains(props, p);
        }

        [Test]
        public void testGetPlayerCount()
        {
            //test that is 0 when no players
            Assert.AreEqual(0, Board.access().getPlayerCount());

            //add a player
            Board.access().addPlayer(new Player());

            //count should be 1
            Assert.AreEqual(1, Board.access().getPlayerCount());

            //add 5 more players
            for (int i = 0; i < 5; i++)
            {
                //add a player
                Board.access().addPlayer(new Player());
            }

            //count should be 6
            Assert.AreEqual(6, Board.access().getPlayerCount());

        }
    }
}
