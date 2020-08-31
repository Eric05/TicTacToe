using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic
{
    //Contract für AI
    public interface IAIController

    {       
        void CheckWinner();
        void MakeMoveEasy();
        void MakeMovePro();
        Move GetBestMove(GameState g, bool isMax, string currentPlayer, string otherPlayer);
    }
}
