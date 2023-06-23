using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogsWinFormsApp
{
    public partial class WinForm : Form
    {
        private int score;
        public WinForm(int score)
        {
            InitializeComponent();
            this.score = score;
        }

        private void WinForm_Load(object sender, EventArgs e)
        {
            if (score > 24)
                addTextLabel.Text = "Вы выиграли,но не за минимальное количество ходов!\n" +
                    "Минимальное равно - 24";
        }
    }
}
