using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Tic
{
    
    //Klasse mit Methoden, die den nächstbesten Zug berechnen 
    public class AIController : IAIController, IGUIController
    {
        private MainForm form1;




        public AIController(MainForm form1)
        {
            this.form1 = form1;
        }


        //Bewertungslogik

        public void CheckWinner()
        {
            bool isWinner = false;

            if ((TopLeftButtonContent == TopCenterButtonContent) && (TopCenterButtonContent == TopRightButtonContent) && (TopLeftButtonContent != ""))
                isWinner = true;
            else if ((CenterLeftButtonContent == CenterButtonContent) && (CenterButtonContent == CenterRightButtonContent) && (CenterRightButtonContent != ""))
                isWinner = true;
            else if ((BottomLeftButtonContent == BottomCenterButtonContent) && (BottomCenterButtonContent == BottomRightButtonContent) && (BottomLeftButtonContent != ""))
                isWinner = true;

            //vertical

            if ((TopLeftButtonContent == CenterLeftButtonContent) && (CenterLeftButtonContent == BottomLeftButtonContent) && (TopLeftButtonContent != ""))
                isWinner = true;
            else if ((TopCenterButtonContent == CenterButtonContent) && (CenterButtonContent == BottomCenterButtonContent) && (TopCenterButtonContent != ""))
                isWinner = true;
            else if ((TopRightButtonContent == CenterRightButtonContent) && (CenterRightButtonContent == BottomRightButtonContent) && (TopRightButtonContent != ""))
                isWinner = true;

            //diagonal

            if ((TopLeftButtonContent == CenterButtonContent) && (CenterButtonContent == BottomRightButtonContent) && (TopLeftButtonContent != ""))
                isWinner = true;
            else if ((BottomLeftButtonContent == CenterButtonContent) && (CenterButtonContent == TopRightButtonContent) && (CenterButtonContent != ""))
                isWinner = true;



            // falls neun Züge erreicht werden, bevor ein Gewinner feststeht ist es ein Draw
            if ((form1.TurnCount == 9) && (isWinner == !true))
            {
                form1.DisableButtons();
                form1.Textbox.Text = "\ndraw";
                form1.Draw.Text = (Int32.Parse(form1.Draw.Text) + 1).ToString();

            }

            // falls es einen Gewinner gibt

            if (isWinner)
            {
                form1.DisableButtons();
                string winner = "";
                if (form1.Turn) // o ist der Gewinner
                {
                    form1.Owin.Text = (Int32.Parse(form1.Owin.Text) + 1).ToString();
                    winner = "o";

                }
                else // _x ist der Gewinner
                {
                    form1.Xwin.Text = (Int32.Parse(form1.Xwin.Text) + 1).ToString();
                    winner = "x";
                }
                form1.Textbox.Text = '\n'+winner + "   wins";
            }

        }


        //Methode für Random Zug

        public void MakeMoveEasy()
        {
            if (form1.TurnCount != 9)
                if (form1.LevelEasy)
                {
                    List<Button> rand2 = new List<Button>();  // Liste in die freie Felder "gepusht(JS) werden

                    List<Button> rand = new List<Button>();

                    rand.Add(form1.TopLeftButton);
                    rand.Add(form1.TopCenterButton);
                    rand.Add(form1.TopRightButton);
                    rand.Add(form1.CenterLeftButton);
                    rand.Add(form1.CenterButton);
                    rand.Add(form1.CenterRightButton);
                    rand.Add(form1.BottomLeftButton);
                    rand.Add(form1.BottomCenterButton);
                    rand.Add(form1.BottomRightButton);

                    for (int i = 0; i < rand.Count; i++)
                    {
                        if (rand[i].Text == "")
                        {
                            rand2.Add(rand[i]);
                        }
                    }

                    Random rnd = new Random();

                    int zufall = rnd.Next(0, rand2.Count);
                    try
                    {
                        rand2[zufall].PerformClick();
                        form1.PcTurn = false;
                    }
                    catch
                    {
                        // Click auf nicht mehr freien Button ignorieren
                    }
                }
        }


        // Zwei Methoden für Pro Move

        public void MakeMovePro()
        {
            if (form1.TurnCount != 9)
            {
                if (form1.LevelPro)
                {
                    Button move = null;

                    move = LookForWinOrLoose("o"); //look for win
                    if (move == null)
                    {
                        move = LookForWinOrLoose("x"); //look for block
                        if (move == null)

                        {
                            List<Button> rand2 = new List<Button>();

                            List<Button> rand = new List<Button>();

                            rand.Add(form1.TopLeftButton);
                            rand.Add(form1.TopCenterButton);
                            rand.Add(form1.TopRightButton);
                            rand.Add(form1.CenterLeftButton);
                            rand.Add(form1.CenterButton);
                            rand.Add(form1.CenterRightButton);
                            rand.Add(form1.BottomLeftButton);
                            rand.Add(form1.BottomCenterButton);
                            rand.Add(form1.BottomRightButton);


                            int i;
                            for (i = 0; i < rand.Count; i++)
                            {
                                if (rand[i].Text == "")
                                {
                                    rand2.Add(rand[i]);
                                }
                            }

                            Random rnd = new Random();

                            int zufall = rnd.Next(0, rand2.Count);
                            try
                            {
                                move = rand2[zufall];
                                form1.PcTurn = false;
                            }
                            catch
                            {

                            }
                        }

                    }
                    move.PerformClick();
                }
            }
        }
        private Button LookForWinOrLoose(string buttonText)
        {
            //horizontal

            if ((TopLeftButtonContent == buttonText) && (TopCenterButtonContent == buttonText) && (TopRightButtonContent == ""))
                return form1.TopRightButton;
            if ((TopCenterButtonContent == buttonText) && (TopRightButtonContent == buttonText) && (TopLeftButtonContent == ""))
                return form1.TopLeftButton;
            if ((TopLeftButtonContent == buttonText) && (TopRightButtonContent == buttonText) && (TopCenterButtonContent == ""))
                return form1.TopCenterButton;

            if ((CenterLeftButtonContent == buttonText) && (CenterButtonContent == buttonText) && (CenterRightButtonContent == ""))
                return form1.CenterRightButton;
            if ((CenterButtonContent == buttonText) && (CenterRightButtonContent == buttonText) && (CenterLeftButtonContent == ""))
                return form1.CenterLeftButton;
            if ((CenterLeftButtonContent == buttonText) && (CenterRightButtonContent == buttonText) && (CenterButtonContent == ""))
                return form1.CenterButton;

            if ((BottomLeftButtonContent == buttonText) && (BottomCenterButtonContent == buttonText) && (BottomRightButtonContent == ""))
                return form1.BottomRightButton;
            if ((BottomCenterButtonContent == buttonText) && (BottomRightButtonContent == buttonText) && (BottomLeftButtonContent == ""))
                return form1.BottomLeftButton;
            if ((BottomLeftButtonContent == buttonText) && (BottomRightButtonContent == buttonText) && (BottomCenterButtonContent == ""))
                return form1.BottomCenterButton;


            //vertical

            if ((TopLeftButtonContent == buttonText) && (CenterLeftButtonContent == buttonText) && (BottomLeftButtonContent == ""))
                return form1.BottomLeftButton;
            if ((CenterLeftButtonContent == buttonText) && (BottomLeftButtonContent == buttonText) && (TopLeftButtonContent == ""))
                return form1.TopLeftButton;
            if ((TopLeftButtonContent == buttonText) && (BottomLeftButtonContent == buttonText) && (CenterLeftButtonContent == ""))
                return form1.CenterLeftButton;

            if ((TopCenterButtonContent == buttonText) && (CenterButtonContent == buttonText) && (BottomCenterButtonContent == ""))
                return form1.BottomCenterButton;
            if ((CenterButtonContent == buttonText) && (BottomCenterButtonContent == buttonText) && (TopCenterButtonContent == ""))
                return form1.TopCenterButton;
            if ((TopCenterButtonContent == buttonText) && (BottomCenterButtonContent == buttonText) && (CenterButtonContent == ""))
                return form1.CenterButton;

            if ((TopRightButtonContent == buttonText) && (CenterRightButtonContent == buttonText) && (BottomRightButtonContent == ""))
                return form1.BottomRightButton;
            if ((CenterRightButtonContent == buttonText) && (BottomRightButtonContent == buttonText) && (TopRightButtonContent == ""))
                return form1.TopRightButton;
            if ((TopRightButtonContent == buttonText) && (BottomRightButtonContent == buttonText) && (CenterRightButtonContent == ""))
                return form1.CenterRightButton;

            //diagonal

            if ((TopLeftButtonContent == buttonText) && (CenterButtonContent == buttonText) && (BottomRightButtonContent == ""))
                return form1.BottomRightButton;
            if ((CenterButtonContent == buttonText) && (BottomRightButtonContent == buttonText) && (TopLeftButtonContent == ""))
                return form1.TopLeftButton;
            if ((TopLeftButtonContent == buttonText) && (BottomRightButtonContent == buttonText) && (CenterButtonContent == ""))
                return form1.CenterButton;

            if ((TopRightButtonContent == buttonText) && (CenterButtonContent == buttonText) && (BottomLeftButtonContent == ""))
                return form1.BottomLeftButton;
            if ((CenterButtonContent == buttonText) && (BottomLeftButtonContent == buttonText) && (TopRightButtonContent == ""))
                return form1.TopRightButton;
            if ((TopRightButtonContent == buttonText) && (BottomLeftButtonContent == buttonText) && (CenterButtonContent == ""))
                return form1.CenterButton;

            return null;
        }


        // Zwei Methoden für Expert Move

        public Move GetBestMove(GameState g, bool isMax, string currentPlayer, string otherPlayer)
        {
            //aktuellen Zustand bewerten 
            //x = menschlicher Spieler und maximiert (bool isMax)
            int score = g.EvaluateState();
            if (score != 2)
            {
                // return state evaluation
                return new Move(score);
            }

            Move bestMove = new Move();

            //Initial den Zug umgekehrt bewerten
            if (isMax)
            {
                bestMove.Score = Int32.MinValue;
            }
            else
            {
                bestMove.Score = Int32.MaxValue;
            }

            //erzeugt Liste aller nächst möglichen Züge ausgehend vom aktuellen Spielstand für den aktuellen Spieler
            var nextMoves = g.GenerateNextMoves(currentPlayer);
            //Durchmische Reihenfolge der nächsten Züge, um für Abwechslung zu sorgen
            nextMoves = Randomize(nextMoves);

            foreach (var move in nextMoves)
            {
                g.ApplyMove(move);
                if (isMax)
                {
                    Move possibleBestMove = GetBestMove(g, !isMax, otherPlayer, currentPlayer);
                    if (possibleBestMove.Score > bestMove.Score)
                    {
                        bestMove.X = move.X;
                        bestMove.Y = move.Y;
                        bestMove.Score = possibleBestMove.Score;
                    }
                }
                else
                {
                    Move possibleBestMove = GetBestMove(g, !isMax, otherPlayer, currentPlayer);
                    if (possibleBestMove.Score < bestMove.Score)
                    {
                        bestMove.X = move.X;
                        bestMove.Y = move.Y;
                        bestMove.Score = possibleBestMove.Score;
                    }
                }
                //resette den aktuellen Zug, da Felder sonst doppelt belegt werden
                g.UndoMove(move);
            }

            return bestMove;

        }

        /// <summary>
        /// Generische Methode, die eine übergebne Liste zufällig mischt -- Methode von StackOverflow
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<T> Randomize<T>(List<T> list)
        {
            List<T> randomizedList = new List<T>();
            Random rnd = new Random();
            while (list.Count > 0)
            {
                int index = rnd.Next(0, list.Count); //pick a random item from the master list
                randomizedList.Add(list[index]); //place it at the end of the randomized list
                list.RemoveAt(index);
            }
            return randomizedList;
        }


        #region Implementation
        public string TopLeftButtonContent { get => ((IGUIController)form1).TopLeftButtonContent; set => ((IGUIController)form1).TopLeftButtonContent = value; }
        public string TopCenterButtonContent { get => ((IGUIController)form1).TopCenterButtonContent; set => ((IGUIController)form1).TopCenterButtonContent = value; }
        public string TopRightButtonContent { get => ((IGUIController)form1).TopRightButtonContent; set => ((IGUIController)form1).TopRightButtonContent = value; }
        public string CenterLeftButtonContent { get => ((IGUIController)form1).CenterLeftButtonContent; set => ((IGUIController)form1).CenterLeftButtonContent = value; }
        public string CenterButtonContent { get => ((IGUIController)form1).CenterButtonContent; set => ((IGUIController)form1).CenterButtonContent = value; }
        public string CenterRightButtonContent { get => ((IGUIController)form1).CenterRightButtonContent; set => ((IGUIController)form1).CenterRightButtonContent = value; }
        public string BottomLeftButtonContent { get => ((IGUIController)form1).BottomLeftButtonContent; set => ((IGUIController)form1).BottomLeftButtonContent = value; }
        public string BottomCenterButtonContent { get => ((IGUIController)form1).BottomCenterButtonContent; set => ((IGUIController)form1).BottomCenterButtonContent = value; }
        public string BottomRightButtonContent { get => ((IGUIController)form1).BottomRightButtonContent; set => ((IGUIController)form1).BottomRightButtonContent = value; }

        #endregion

    }
}