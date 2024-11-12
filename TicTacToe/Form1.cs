namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X , O
        }
        Player currentPlayer;
        Random random = new Random();
        int kazananOyuncu = 0;
        int kazananPc = 0;
        List<Button> list;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void CPUtasima(object sender, EventArgs e)
        {
            if (list.Count >0)
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

        }
        private void RestartGame()
        {
            list = new List<Button>{ button1,button2,button3,button4,button5,button6,button7,button8,button9};
            foreach (Button button in list) {
                button.Enabled = true;
                button.Text = "?";
                button.BackColor = DefaultBackColor;

            }
        }
    }
}
