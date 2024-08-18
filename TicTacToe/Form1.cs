using System.Drawing.Drawing2D;
using System.Numerics;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Toggle_All_Button(true);
            StatusLabel.Text = $"Current Turn: {gameModel.player1_name}";
        }


        private void Toggle_All_Button(bool toggle)
        {
            if (toggle is false)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
            }
        }

        private void button_hover(object sender, EventArgs e, int player = 1)
        {
            Button currButton = (Button)sender;
            string buttonName = currButton.Name;
            int button_in_int = int.Parse(buttonName);
            Tuple<int, int> corrdinates = gameModel.GetCoordinate(button_in_int);
            if (gameModel.grid[corrdinates.Item1][corrdinates.Item2] != -1)
            {
                return;
            }

            string button_string = "";
            if (player is 1)
            {
                button_string = "X";
            }
            else
            {
                button_string = "O";
            }
            Button currButton2 = (Button)sender;
            if (currButton.Text is not "X" || currButton.Text is not "Y")
            {
                currButton2.Text = button_string;
            }
        }


        private void button_MouseEnter(object sender, EventArgs e)
        {
            button_hover(sender, e);
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button currButton = (Button)sender;
            string buttonName = currButton.Name;
            int button_in_int = int.Parse(buttonName);
            Tuple<int, int> corrdinates = gameModel.GetCoordinate(button_in_int);
            if (gameModel.grid[corrdinates.Item1][corrdinates.Item2] == -1)
            {
                currButton.Text = "";
            }
            else
            {

            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button currButton = (Button)sender;
            string buttonName = currButton.Name;
            int button_in_int = int.Parse(buttonName);
            Tuple<int, int> corrdinates = gameModel.GetCoordinate(button_in_int);
            if (gameModel.grid[corrdinates.Item1][corrdinates.Item2] != -1)
            {
                return;
            }
            else
            {
                if (gameModel.currentPlayerID == 1)
                {
                    currButton.Text = "X";
                    StatusLabel.Text = $"Current Turn: {gameModel.player2_name}";
                }
                else
                {
                    currButton.Text = "O";
                    StatusLabel.Text = $"Current Turn: {gameModel.player1_name}";
                }
                gameModel.OnGridEvent(button_in_int);
                var result = gameModel.CheckGameStatus();
                if (result == -1 || result == 1 || result == 0)
                {
                    Toggle_All_Button(false);
                    StatusLabel.Text = "Game Over";
                }
            }
        }
    }
}