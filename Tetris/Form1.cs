using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Tetris
{
    public partial class Form1 : Form
    {
        int movementFigure = 0;
        Figure figure = new Figure();
        Movement movement = new Movement();
        bool oneDraw = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (oneDraw == true)
            {
                figure.Draw(sender, e);
                oneDraw = false;
            }
            else
            {
                movementFigure += 15;                
                movement.MovementDown(sender, e, movementFigure);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}




//00010203
//00011102
//00011112
//00011121                        
//00100102
//00100111
//00101112            
//00101121
//00102011                      
//00102030

//10011112
//10011121
//10110102
//10110212            
//10200111
