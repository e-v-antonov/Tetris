using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    class Figure
    {
        string[] list_Multiplier = {"00010203",   //список множителей
                              "00011102",
                              "00011112",
                              "00011121",
                              "00100102",
                              "00100111",
                              "00101112",
                              "00101121",
                              "00102011",
                              "00102030",
                              "10011112",
                              "10011121",
                              "10110102",
                              "10110212",
                              "10200111"};
        int choice_Multiplier; //выбор множителя
        string string_Multiplier;  //строка множителей
        int x_Multiplier, y_Multiplier;   //множители координат х и у
        public static char[] digit_Multiplier = new char[8]; //цифры множители
        public static  int[,] setka = new int[15, 10];

        public void Draw(object sender, PaintEventArgs e)   //рисование рандомной фигуры
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    setka[i, j] = 0;
                }
            }

            Random rnd = new Random();
            choice_Multiplier = rnd.Next(0, 15);    
            string_Multiplier = list_Multiplier[choice_Multiplier]; 
            digit_Multiplier = string_Multiplier.ToArray(); 

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
                    e.Graphics.FillRectangle(Brushes.Red, x_Multiplier * 24, y_Multiplier * 24, 24, 24);
                    setka[x_Multiplier, y_Multiplier] = 1;
                }
            }
        }
    }
}
