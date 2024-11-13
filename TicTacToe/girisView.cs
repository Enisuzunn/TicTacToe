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
    public partial class girisView : Form
    {
        public girisView()
        {
            InitializeComponent();
        }

        private void startButton(object sender, EventArgs e)
        {
            secimView secim = new secimView();
            secim.Show();
            this.Hide();
        }
    }
}
