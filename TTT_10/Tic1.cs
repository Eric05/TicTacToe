using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic
{
    public partial class MainForm : Form, IGUIController
    {
        #region Deklaration der Variablen
        private int counter = 0; // regelt, dass bei Next() Spieler B das 2. Spiel beginnt
        private bool pcTurn = true; //ist Pc am Zug
        private bool turn = true; // definiert, wer am Zug ist
        private int turnCount = 0; // zählt Züge
        private bool isSimulation = true;
        private bool levelEasy = false; //gegen Pc ohne AI spielen
        private bool levelPro = false; //gegen Pc Pro spielen
        private bool levelExpert = false;

        public GameState gameState;
        private AIController aiController;
        private GUIController guiController;

        //Kapselung
        public int TurnCount { get => turnCount; set => turnCount = value; }
        public bool PcTurn { get => pcTurn; set => pcTurn = value; }
        public bool LevelPro { get => levelPro; set => levelPro = value; }
        public bool LevelExpert { get => levelExpert; set => levelExpert = value; }
        public bool LevelEasy { get => levelEasy; set => levelEasy = value; }
        public bool Turn { get => turn; set => turn = value; }
        public bool IsSimulation { get => isSimulation; set => isSimulation = value; }
        public int Counter { get => counter; set => counter = value; }

        #endregion

        public MainForm()
        {
            gameState = new GameState();
            aiController = new AIController(this);
            guiController = new GUIController(this);
            InitializeComponent();
        }


        // vom button wird ein Move-Objekt instanziert mit x und y Koordinaten, um mit applyMove zu setzen
        public Move GetMoveForButton(Button b)
        {
            Move m = new Move();
            if (b == a1)
            {
                m.X = 0;
                m.Y = 0;
            }
            else if (b == a2)
            {
                m.X = 1;
                m.Y = 0;
            }
            else if (b == a3)
            {
                m.X = 2;
                m.Y = 0;
            }
            else if (b == b1)
            {
                m.X = 0;
                m.Y = 1;
            }
            else if (b == b2)
            {
                m.X = 1;
                m.Y = 1;
            }
            else if (b == b3)
            {
                m.X = 2;
                m.Y = 1;
            }
            else if (b == c1)
            {
                m.X = 0;
                m.Y = 2;
            }
            else if (b == c2)
            {
                m.X = 1;
                m.Y = 2;
            }
            else if (b == c3)
            {
                m.X = 2;
                m.Y = 2;
            }
            return m;
        }

        //gibt für für einen Move den entsprechenden Button zurück
        public Button GetButtonForMove(Move m)
        {

            if (m.X == 0 && m.Y == 0)
            {
                return a1;
            }
            else if (m.X == 1 && m.Y == 0)
            {
                return a2;
            }
            else if (m.X == 2 && m.Y == 0)
            {
                return a3;
            }
            else if (m.X == 0 && m.Y == 1)
            {
                return b1;
            }
            else if (m.X == 1 && m.Y == 1)
            {
                return b2;
            }
            else if (m.X == 2 && m.Y == 1)
            {
                return b3;
            }
            else if (m.X == 0 && m.Y == 2)
            {
                return c1;
            }
            else if (m.X == 1 && m.Y == 2)
            {
                return c2;
            }
            else
            {
                return c3;
            }

        }


        //Click Events. Werden in GUIController geregelt

        public void ButtonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            guiController.BButtonClick(b);

        }

        public void DisableButtons()
        {
            guiController.DDisableButtons();

        }

        private void Next(object sender, EventArgs e)
        {
            guiController.NNext();

        }

        public void NewGame(object sender, EventArgs e)
        {
            guiController.NNewGame();

        }


        //Methoden für die Spielstufen. Werden in AIController geregelt

        public void CheckWinner()
        {
            aiController.CheckWinner();
        }

        public void PcMove()
        {
            aiController.MakeMoveEasy();
        }

        public void PcMovePro()
        {
            aiController.MakeMovePro();
        }

        public void PcMoveExpert()
        {

            // MinMax aufrufen mit isMax=false (Computer minimiert immer)
            Move bestMove = aiController.GetBestMove(this.gameState, false, "o", "x");
            //der von AI berechnete Zug muss auf den entsprechenden Button übertragen werden
            Button bu = GetButtonForMove(bestMove);
            bu.PerformClick();

        }


        //  Methoden für RadioButtons

        private void LevelVs(object sender, EventArgs e)
        {
            LevelExpert = false;
            LevelEasy = false;
            LevelPro = false;
        }

        private void Level_Easy(object sender, EventArgs e)
        {

            LevelExpert = false;
            LevelPro = false;
            LevelEasy = true;
        }

        private void Level_Pro(object sender, EventArgs e)
        {
            LevelExpert = false;
            LevelEasy = false;
            LevelPro = true;
        }

        private void Level_Expert(object sender, EventArgs e)
        {
            LevelExpert = true;
            LevelEasy = false;
            LevelPro = false;
        }



        //Simulation

        private async void Simulation_Click(object sender, EventArgs e)
        {
            IsSimulation = true;
            for (int j = 0; j < 25; j++)
            {
                if (IsSimulation)

                {
                    guiController.NNext();
                    for (int i = 0; i < 10; i++)
                    {
                        await Task.Delay(200); //Verzögerung erfordert async

                        pcTurn = false;
                        LevelEasy = true;
                        PcMove();


                    }
                }
            }
        }

        private async void SimulationPro_Click(object sender, MouseEventArgs e)
        {
            IsSimulation = true;
            for (int j = 0; j < 25; j++)
            {

                if (IsSimulation)
                {

                    guiController.NNext();
                    for (int i = 0; i < 10; i++)
                    {
                        await Task.Delay(200); //Verzögerung erfordert async

                        pcTurn = false;
                        LevelPro = true;
                        PcMovePro();

                    }
                }
            }
        }

        private async void SimulationExpert_Click(object sender, EventArgs e)
        {
            IsSimulation = true;


            for (int j = 0; j < 25; j++)
            {

                if (IsSimulation)
                {

                    guiController.NNext();
                    for (int i = 0; i < 10; i++)
                    {
                        await Task.Delay(200); //Verzögerung erfordert async

                        pcTurn = false;
                        LevelPro = true;
                        PcMovePro();
                        LevelPro = false;
                        await Task.Delay(200); //Verzögerung erfordert async
                        PcMoveExpert();


                    }
                }
            }

        }

        private void ResetSimulation(object sender, EventArgs e)
        {
            IsSimulation = false;
        }




        // Methoden für schöneres Design

        private void HoverSimul(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = Color.LightGray;

        }

        private void ResetHoverSimul(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            l.BackColor = Color.Transparent;

        }

        private void Hover(object sender, EventArgs e)
        {
            //Simulation.ForeColor = Color.White;
            //Simulation.BorderStyle = BorderStyle.Fixed3D;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Hover_Reset(object sender, EventArgs e)
        {
            //Simulation.BorderStyle = BorderStyle.FixedSingle;
            //Simulation.ForeColor = Color.Gainsboro;
        }

        private void Hover1(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
            label7.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Hover1_Reset(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Gainsboro;
            label7.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Hover2(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
            label4.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Hover2_Reset(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Gainsboro;
            label4.BorderStyle = BorderStyle.FixedSingle;
        }



        #region ITicTacToeGui implementaions

        public string TopLeftButtonContent { get => TopLeftButton.Text; set => TopLeftButton.Text = value; }
        public string CenterLeftButtonContent { get => CenterLeftButton.Text; set => CenterLeftButton.Text = value; }
        public string TopRightButtonContent { get => TopRightButton.Text; set => TopRightButton.Text = value; }
        public string TopCenterButtonContent { get => TopCenterButton.Text; set => TopCenterButton.Text = value; }
        public string CenterButtonContent { get => CenterButton.Text; set => CenterButton.Text = value; }
        public string CenterRightButtonContent { get => CenterRightButton.Text; set => CenterRightButton.Text = value; }
        public string BottomLeftButtonContent { get => BottomLeftButton.Text; set => BottomLeftButton.Text = value; }
        public string BottomCenterButtonContent { get => BottomCenterButton.Text; set => BottomCenterButton.Text = value; }
        public string BottomRightButtonContent { get => BottomRightButton.Text; set => BottomRightButton.Text = value; }
        #endregion


    }

}
