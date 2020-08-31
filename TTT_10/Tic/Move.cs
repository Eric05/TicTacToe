namespace Tic
{
    /// <summary>
    /// Klasse für Move: _x/_y für Position in zweidimensionaler Matrix;  
    /// _score speichert die aktuelle Bewertung dieses move-Objekts( 0, 1, -1)
    /// _playerSymbol definiert 'X' oder 'O'
    /// </summary>
    public class Move
    {
        private int _score;
        private int _x;
        private int _y;
        private string _playerSymbol;

        public int Y { get => _y; set => _y = value; }
        public int X { get => _x; set => _x = value; }
        public int Score { get => _score; set => _score = value; }
        public string PlayerSymbol { get => _playerSymbol; set => _playerSymbol = value; }



        public Move(int x, int y, string playerSymbol)
        {
            _x = x;
            _y = y;
            _playerSymbol = playerSymbol;
        }

     
          
        public Move(int score)
        {
            _score = score;
        }

        public Move()
        {

        }
    }
}