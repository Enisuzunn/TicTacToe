using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class secimView : Form
    {
        public secimView()
        {
            InitializeComponent();
        }

        private void littleGame(object sender, EventArgs e)
        {
            _3x3View littlegame = new _3x3View();
            littlegame.Show(); 
            this.Hide();
        }

        private void mediumGame(object sender, EventArgs e)
        {
            _5x5View mediumGame = new _5x5View();
            mediumGame.Show();
            this.Hide();
        }

        private void bigGame(object sender, EventArgs e)
        {
            _7x7View bigGame = new _7x7View();
            bigGame.Show();
            this.Hide();
        }
    }
}
