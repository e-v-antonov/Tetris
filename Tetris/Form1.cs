using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Tetris
{
    public partial class Form1 : Form
    {
        Figure figure = new Figure();
        Movement movement = new Movement();
        PressKey presskey = new PressKey();
        bool oneDraw = true;
        

        public Form1()
        {
            Program.form1 = this;
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
                movement.MovementDown(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // if (movement.allow_Movement != false)
                panel1.Refresh();
            //else
            //{
            //    //timer1.Enabled = false;
            //    panel1.Refresh();
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            presskey.PressMovement(sender, e);
            panel1.Refresh();
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
