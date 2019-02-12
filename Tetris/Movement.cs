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
        public static int movementY = 0;
        public static int movementX = 0;
        public bool allow_Movement = true;
        public  int xSetka, ySetka;

        public void MovementDown(object sender, PaintEventArgs e)   //движение фигуры вниз
        {
            movementY += 24;
            int primer = y_Multiplier * 24 + movementY + 24;


            for (int i = 14; i >= 0; i--)
            {
                for (int j = 9; j >= 0; j--)
                {
                    if (setka[14, j] == 1)
                        Program.form1.timer1.Enabled = false;

                    if (setka[i, j] == 1)
                    {
                        setka[i, j] = 0;
                        setka[i + 1, j] = 1;
                    }
                }
            }


           // if (primer <= 200)
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
                        e.Graphics.FillRectangle(Brushes.Red, x_Multiplier * 24 + movementX, y_Multiplier * 24 + movementY, 24, 24);
                    }                    
                }
            //else
            //    allow_Movement = false;
        }
    }
}
