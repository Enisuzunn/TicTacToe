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

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void CPUtasima(object sender, EventArgs e)
        {

        }

        private void playerclickbutton(object sender, EventArgs e)
        {

        }

        private void restartgame(object sender, EventArgs e)
        {

        }
        private void CheckGame()
        {

        }
        private void RestartGame()
        {
            List<Button> list = new List<Button>{ button1,button2,button3,button4,button5,button6,button7,button8,button9};
            foreach (Button button in list) {
                button.Enabled = true;
                button.Text = "?";
                button.BackColor = DefaultBackColor;

            }
        }
    }
}
