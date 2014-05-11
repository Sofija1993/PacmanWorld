using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PacmanWorld
{
   public class Food2 :Element
    {

       public Food2(int resourceId = 1)
       {
       if (resourceId == 1)
            {
                slika = Properties.Resources.food;
            }
            else
            {
                slika = Properties.Resources.food;
            }
   }
       public override bool Dopir(Pacman p)
       {
           p.Points += 3;
           return true;
       }
    }
}
