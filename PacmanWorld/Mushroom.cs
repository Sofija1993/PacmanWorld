using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using PacmanWorld.Properties;

namespace PacmanWorld
{
    public class Mushroom : Element
    {
        public Mushroom(int resourceId = 1)
        {
            if (resourceId == 1)
            {
                slika = Properties.Resources.bomb;
            }
            else
            {
                slika = Properties.Resources.mushroom1;
            }
        }
        public override bool Dopir(Pacman p)
        {
            p.LifePoints-=1;
            
            return true;
        }
    }
}
