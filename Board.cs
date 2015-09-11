using System.Collections;
using System.Text;

namespace MolopolyGame
{
    /// <summary>
    /// This is class for singleton Board that has properties and traders on it.
    /// </summary>
    
    public class Board
    {
        //provide an static instance of this class to create singleton
        static Board board;
        private ArrayList properties;
        private ArrayList players;
        int SQUARES = 40;
     
        //method to access singleton
        public static Board access()
        {
            if (board == null)
                board = new Board();
            return board;
        }

        public Board()
        {
            properties = new ArrayList(this.getSquares());
            players = new ArrayList();
        }

        public int getSquares()
        {
            return this.SQUARES;
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

        public void addPlayer(Player player)
        {
            players.Add(player);
        }

        public void addProperty(Property property)
        {
            this.properties.Add(property);
        }

        public int getPlayerCount()
        {
            return players.Count;
        }

       

        public Player getPlayer(int playerIndex)
        {
            return (Player)players[playerIndex];
        }

        public Player getPlayer(string sName)
        {
            foreach (Player p in players)
            {
                if (p.getName() == sName)
                    return p;
            }

            // if no players with that name return null
            return null;
        }

        public Property getProperty(int propIndex)
        {
            return (Property)properties[propIndex];
        }

        public ArrayList getPlayers()
        {
            return this.players;
        }

        public ArrayList getProperties()
        {
            return this.properties;
        }
    }
}
