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
            Figure figure = new Figure();
            figure.Draw(sender, e);
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
