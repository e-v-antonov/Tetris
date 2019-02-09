using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    class PressKey
    {
        Figure figure = new Figure();
        int movement = 25;

        public void PressMovement(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.PageDown)
            //    figure.FigureMovement(sender, PaintEventArgs, movement);

        }
    }
}
