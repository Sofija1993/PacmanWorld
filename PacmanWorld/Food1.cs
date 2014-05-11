using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PacmanWorld
{
    public class Food1 :Element
    {
        public Food1(int resourceId = 1)
        {
            if (resourceId == 1)
            {
                slika = Properties.Resources.food1;
            }
            else
            {
                slika = Properties.Resources.food1;
            }
        }
        public override bool Dopir(Pacman p)
        {
            p.Points +=2;
            return true;
        }
    }
}
