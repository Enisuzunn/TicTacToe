namespace TicTacToe
{
    public partial class _3x3View : Form
    {
        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        Random random = new Random();
        int kazananOyuncu = 0;
        int kazananPc = 0;
        List<Button> list;

        public _3x3View()
        {
            InitializeComponent();
            RestartGame();
        }

        private void CPUtasima(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                int index = random.Next(list.Count);
                list[index].Enabled = false;
                currentPlayer = Player.O;
                list[index].Text = currentPlayer.ToString();
                list[index].BackColor = Color.DarkSalmon;
                list.RemoveAt(index);
                CheckGame();
                gameTimer.Stop();
            }
        }

        private void playerclickbutton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Cyan;
            list.Remove(button);
            CheckGame();
            gameTimer.Start();

        }

        private void restartgame(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" || button4.Text == "X" && button5.Text == "X"
                && button6.Text == "X" || button7.Text == "X" && button8.Text == "X" && button9.Text == "X" || button1.Text == "X"
                && button4.Text == "X" && button7.Text == "X" || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X" || button1.Text == "X" && button5.Text == "X"
                && button9.Text == "X" || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                gameTimer.Stop();
                MessageBox.Show("Player Wins");
                kazananOyuncu++;
                label1.Text = "Player Wins: " + kazananOyuncu;
                RestartGame();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" || button4.Text == "O" && button5.Text == "O"
                && button6.Text == "O" || button7.Text == "O" && button8.Text == "O" && button9.Text == "O" || button1.Text == "O"
                && button4.Text == "O" && button7.Text == "O" || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O" || button1.Text == "O" && button5.Text == "O"
                && button9.Text == "O" || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                gameTimer.Stop();
                MessageBox.Show("Pc Wins");
                kazananPc++;
                label2.Text = "Pc Wins: " + kazananPc;
                RestartGame();
            }
            
        }
        private void RestartGame()
        {
            list = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button button in list)
            {
                button.Enabled = true;
                button.Text = "?";
                button.BackColor = DefaultBackColor;

            }

        }

        private void _3x3View_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
