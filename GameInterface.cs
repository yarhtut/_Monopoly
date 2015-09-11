using System;
using System.Collections.Generic;
using System.Text;

namespace MolopolyGame
{

    /// <summary>
    /// Interface for games
    /// </summary>
    
    interface GameInterface
    {
        void initializeGame();
        void makePlay(int player);
        bool endOfGame();
        void printWinner();
        void playOneGame(int playersCount);

    }
}
