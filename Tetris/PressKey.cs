using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tetris
{
    class PressKey : Movement
    {    
        public void PressMovement(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.NumPad6)
                movementX += 24;
            else
                if (e.KeyCode == Keys.NumPad4)
                    movementX -= 24;
            else
                    if (e.KeyCode == Keys.NumPad2)
                        movementY += 24;
            //else
            //    if (e.KeyCode == Keys.PageUp)
            //{
            //    movementX += 3;
            //    MovementDown(sender, a);
            //}
        }
    }
}
