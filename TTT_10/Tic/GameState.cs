using System;
using System.Collections.Generic;
using System.Linq;

namespace Tic
{

    // Klasse für die Kapselung eines Spielzustandes 

    public class GameState
    {
        private string[,] _gameField = new string[3, 3];
        public static int GAME_WIDTH = 3;
        public static int GAME_HEIGHT = 3;
        public static int WIN_COUNT = 3;

        // Konstruktor führt Methode InitField aus - 2 dimensionales Spielfeld wird erzeugt

        public GameState()
        {
            InitField();

        }

        // Versetzt alle Felder im Array wieder in den Urzustand
        public void InitField()
        {

            for (int y = 0; y < GAME_HEIGHT; y++)
            {
                for (int x = 0; x < GAME_WIDTH; x++)
                {
                    _gameField[y, x] = " ";
                }
            }
        }

        /// <summary>
        /// Bewertung des aktuellen Spielzustands:
        /// 1 - Bei Sieg von Spieler 'X'
        /// -1 - Bei Sieg von Spieler 'O'
        /// 0 - Bei Unentschieden
        /// 2 - in allen anderen Fällen
        /// </summary>
        /// <returns>int</returns>

        public int EvaluateState()
        {
            // check horizontals && verticals
            int playerXCountHorizontal = 0;
            int playerXCountVertical = 0;
            int playerOCountVertical = 0;
            int playerOCountHorizontal = 0;
            int fieldCounter = 0;

            //Verschachtelte Schleifen, um zweidimensionales Array zeilenweise zu iterieren
            for (var y = 0; y < GAME_HEIGHT; y++)
            {
                //Zähler muss zurückgesetzt werden, um Gewinner in der nächsten Zeile korrekt bestimmen zu können
                playerXCountHorizontal = 0;
                playerXCountVertical = 0;
                playerOCountHorizontal = 0;
                playerOCountVertical = 0;

                //innere Schleife
                for (var x = 0; x < GAME_WIDTH; x++)
                {
                    //Prüfung horizontal
                    if (_gameField[y, x] != " ")
                    {
                        if (_gameField[y, x] == "x")
                        {
                            playerXCountHorizontal++;
                        }
                        else
                        {
                            playerOCountHorizontal++;
                        }
                    }
                    else
                    {
                        fieldCounter++; //wenn Feld leer ist, Zähler erhöhen
                    }

                    //Prüfung vertical
                    if (_gameField[x, y] != " ")
                    {
                        if (_gameField[x, y] == "x")
                        {
                            playerXCountVertical++;
                        }
                        else
                        {
                            playerOCountVertical++;
                        }
                    }
                }
                //Ende der inneren Schleife
                //Test ob es einen Gewinner gibt in dieser Zeile

                if (playerOCountVertical == WIN_COUNT || playerOCountHorizontal == WIN_COUNT)
                {
                    return -1;
                }
                if (playerXCountHorizontal == WIN_COUNT || playerXCountVertical == WIN_COUNT)
                {
                    return 1;
                }
            }

            //check Diagonalen
            int playerXCountDiagonal = 0;
            int playerOCountDiagonal = 0;
            int playerOCountDiagonal2 = 0;
            int playerXCountDiagonal2 = 0;

            for (int i = 0, j = GAME_HEIGHT - 1; i < GAME_HEIGHT && j >= 0; i++, j--)
            {
                if (_gameField[i, i] != " ")
                {
                    if (_gameField[i, i] == "x")
                    {
                        playerXCountDiagonal++;
                    }
                    else
                    {
                        playerOCountDiagonal++;
                    }
                }
                if (_gameField[i, j] != " ")
                {
                    if (_gameField[i, j] == "x")
                    {
                        playerXCountDiagonal2++;
                    }
                    else
                    {
                        playerOCountDiagonal2++;
                    }
                }
            }
            if (playerXCountDiagonal == WIN_COUNT || playerXCountDiagonal2 == WIN_COUNT)
            {
                return 1;
            }
            if (playerOCountDiagonal == WIN_COUNT || playerOCountDiagonal2 == WIN_COUNT)
            {
                return -1;
            }

            // bis hierher hat noch kein Spieler gewonnen, prüfe ob es ein Unentschieden ist
            if (fieldCounter == 0)
            {
                return 0;
            }
            return 2;
        }

        /// <summary>
        /// Generiert Züge ausgehend vom aktuellen Zustand für den übergebenen Spieler
        /// </summary>
        /// <param name="playerSymbol"></param>
        /// <returns></returns>
        public List<Move> GenerateNextMoves(string playerSymbol)
        {
            List<Move> moves = new List<Move>();
            for (int y = 0; y < GAME_HEIGHT; y++)
            {
                for (int x = 0; x < GAME_WIDTH; x++)
                {
                    if (_gameField[y, x] == " ")
                    {
                        moves.Add(new Move(x, y, playerSymbol));
                    }
                }
            }

            return moves;
        }

        //übergebenen Move im Spielzustand setzen - falls Mensch ungültigen Zug macht...
        public void ApplyMove(Move m)
        {
            if (_gameField[m.Y, m.X] != " ")
            {
                throw new Exception("Invalid Move");
            }
            _gameField[m.Y, m.X] = m.PlayerSymbol;
        }

        //...Zug zurücknehmen
        public void UndoMove(Move m)
        {
            _gameField[m.Y, m.X] = " ";
        }

    }
}





