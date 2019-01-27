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

        int x, y;
        int zapx, zapy;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            //Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ////


            //e.Graphics.FillRectangle(Brushes.Red, 0, 0, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 26, 0, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 52, 0, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 78, 0, 24, 24);


            //
            //
            //
            //


            //e.Graphics.FillRectangle(Brushes.Red, 0, 0, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 0, 26, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 0, 52, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 0, 78, 24, 24);


            //
            //


            //e.Graphics.FillRectangle(Brushes.Red, 0, 0, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 26, 0, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 0, 26, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 26, 26, 24, 24);


            ////////
            //


            //e.Graphics.FillRectangle(Brushes.Red, 0, 0, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 26, 0, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 52, 0, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 26, 26, 24, 24);


            //
            ////
            //


            //e.Graphics.FillRectangle(Brushes.Red, 0, 0, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 0, 26, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 0, 52, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 26, 26, 24, 24);


            //
            ////
            //

            //e.Graphics.FillRectangle(Brushes.Red, 0, 26, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 26, 0, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 26, 26, 24, 24);
            //e.Graphics.FillRectangle(Brushes.Red, 26, 52, 24, 24);


            //
            //////

            for (int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                Random rnd1 = new Random();

                x = rnd.Next(0, 3);
                y = rnd.Next(0, 3);


                //e.Graphics.DrawString(x.ToString(), Font, SystemBrushes.WindowText, i + 5, 0);
                //panel1.Refresh();
                e.Graphics.FillEllipse(Brushes.Red, new Rectangle(x * 24, x * 24, 24, 24));

            }

            //e.Graphics.FillEllipse(Brushes.Red, new Rectangle(0 * 24, 0 * 24, 24, 24));
            //e.Graphics.FillEllipse(Brushes.Red, new Rectangle(1 * 24, 0 * 24, 24, 24));
            //e.Graphics.FillEllipse(Brushes.Red, new Rectangle(2 * 24, 0 * 24, 24, 24));
            //e.Graphics.FillEllipse(Brushes.Red, new Rectangle(3 * 24, 0 * 24, 24, 24));


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


        }
    }
}
