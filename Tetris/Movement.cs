using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    class Movement : Figure
    {
        int x_Multiplier, y_Multiplier;

        public void MovementDown(object sender, PaintEventArgs e, char[] digit_Multiplier, int movement)
        {
            for (int i = 0; i < digit_Multiplier.Length; i++)
            {
                if ((i == 0) || (i == 2) || (i == 4) || (i == 6))
                {
                    x_Multiplier = Convert.ToInt32(digit_Multiplier[i].ToString());
                    continue;
                }
                else
                {
                    y_Multiplier = Convert.ToInt32(digit_Multiplier[i].ToString());
                    e.Graphics.FillRectangle(Brushes.Red, x_Multiplier * 24, y_Multiplier * 24 + movement, 24, 24);
                }
            }
        }
    }
}
