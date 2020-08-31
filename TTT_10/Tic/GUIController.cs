using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic
{
    class GUIController : IGUIController
    {
   
        //Klasse mit Methoden, die auf User Input reagieren
        private MainForm form1;


        public GUIController(MainForm form1)
        {
            this.form1 = form1;
        }

        // Next: Sämtliche Einstellungen werden wieder zurückgesetzt, der Count der gewonnen Partien bleibt
        public void NNext()
        {
            form1.Textbox.Text = "";
            form1.TurnCount = 0;
            form1.Counter++;



            try
            {
                foreach (Control c in form1.Controls)
                {
                    Button b = c as Button;
                    if (b != null)
                    {
                        b.Text = "";
                        b.Enabled = true;

                    }
                }
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

            form1.gameState.InitField();

            if ((form1.Counter % 2 != 0) && (form1.LevelEasy))
            {
                form1.Turn = false;
                form1.PcMove();

            }
            else if ((form1.Counter % 2 != 0) && (form1.LevelPro))
            {
                form1.Turn = false;
                form1.PcMovePro();
            }
            else if ((form1.Counter % 2 != 0) && (form1.LevelExpert))
            {
                form1.Turn = false;
                form1.PcMoveExpert();
            }
            else
            {

                form1.Turn = true;
                form1.PcTurn = false;
            }

        }

        // New Game: Sämtliche Einstellungen werden wieder zurückgesetzt
        public void NNewGame()
        {
            form1.Textbox.Text = "";
            form1.TurnCount = 0;
            form1.Turn = true;
            form1.Owin.Text = (Int32.Parse("0").ToString());
            form1.Xwin.Text = (Int32.Parse("0").ToString());
            form1.Draw.Text = (Int32.Parse("0").ToString());

            form1.gameState.InitField();


            try
            {
                foreach (Control c in form1.Controls)
                {
                    Button b = c as Button;
                    if (b != null)
                    {
                        b.Enabled = true;
                        b.Text = "";
                    }

                }
            }
            catch
            {


            }
        }

        // Ereignisse auf Click auf Button
        public async void BButtonClick(Button b)
        {
            Move m = null;


            if (b.Text != "")
            {
                b.Enabled = false; //wenn User auf bereits benutzten Button klickt, wird dieser disabled
                form1.TurnCount -= 1; // der entsprechende Zug darf nicht gezählt werden
                form1.Turn = !form1.Turn; // wer am Zug ist, darf sich durch Fehlclick nicht ändern
            }

            else
            {
                m = form1.GetMoveForButton(b);
                if (form1.Turn) // _x ist am Zug
                {

                    b.Text = "x";
                    m.PlayerSymbol = "x";
                    b.ForeColor = System.Drawing.Color.Lime;
                }
                else
                {
                    m.PlayerSymbol = "o";
                    b.Text = "o"; // o ist am Zug
                    b.ForeColor = System.Drawing.Color.Lime;
                }
            }

            try
            {
                form1.gameState.ApplyMove(m);


            }
            catch (Exception)
            {

            }
            // Nach jedem Zug, wird der Ausführende gewechselt, um eins inkrementiert und die Funktion, ob es 
            // einen Gewinner gibt aufgerufen
            form1.Turn = !form1.Turn;
            form1.TurnCount++;
            form1.CheckWinner();
            form1.PcTurn = true;
            if ((!form1.Turn) && (form1.PcTurn) && (form1.LevelEasy))
            {
                await Task.Delay(500); //Verzögerung erfordert async
                form1.PcMove();
            }
            else if ((!form1.Turn) && (form1.PcTurn) && (form1.LevelPro))
            {
                await Task.Delay(500); //Verzögerung erfordert async
                form1.PcMovePro();
            }
            else if ((!form1.Turn) && (form1.PcTurn) && (form1.LevelExpert))
            {
                await Task.Delay(500); //Verzögerung erfordert async
                form1.PcMoveExpert();
            }
        }



        // Buttons disablen
        public void DDisableButtons()
        {
            try
            {

                // sucht alle Buttons in der gesamten Form und deaktiviert sie
                foreach (Control c in form1.Controls)
                {
                    Button b = c as Button;
                    if (b != null)
                    {
                        b.Enabled = false;
                    }
                }
            }
            catch
            {


            }
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
