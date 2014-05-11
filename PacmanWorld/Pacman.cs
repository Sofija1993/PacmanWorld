using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PacmanWorld
{
    public class Pacman
    {
        public Bitmap slika;
        public int Points;
        public int LifePoints;
        public int X, Y;
        public DIRETION nasoka;
        public bool isOpen;
      public  Brush  brush;

        public enum DIRETION
        {
            LEFT,
            RIGHT,
            UP,
            DOWN
        }

        public Pacman(int x, int y, DIRETION n)
        {
            Points = 0;
            LifePoints = 10;
            nasoka = n;
            X = x;
            Y = y;
            isOpen = false;

            brush = Brushes.Green;
            slika = new Bitmap(100, 100);
        }
            

        public void Move()
        {
           switch (nasoka)
            {
                case DIRETION.DOWN:
                    Y += 1;
                    Graphics.FromImage(slika).Clear(Color.Transparent);
                    Graphics.FromImage(slika).FillPie(brush, 0, 0, 100, 100, 135, 270);
                    break;
                case DIRETION.LEFT:
                    X -= 1;
                    Graphics.FromImage(slika).Clear(Color.Transparent);
                    Graphics.FromImage(slika).FillPie(brush, 0, 0, 100,100, 225, 270);
                    break;
                case DIRETION.RIGHT:
                    X += 1;
                    Graphics.FromImage(slika).Clear(Color.Transparent);
                    Graphics.FromImage(slika).FillPie(brush, 0, 0, 100, 100, 45, 270);
                    break;
                case DIRETION.UP:
                    Y -= 1;
                    Graphics.FromImage(slika).Clear(Color.Transparent);
                    Graphics.FromImage(slika).FillPie(brush, 0, 0, 100, 100, 315, 270);
                    break;
            }
        }

    }
}
