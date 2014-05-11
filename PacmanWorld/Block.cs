using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using PacmanWorld.Properties;

namespace PacmanWorld
{
    public class Block : Element
    {
       public Block(int resourceId = 1)
       {
       if (resourceId == 1)
            {
                slika = Properties.Resources.block;
            }
            else
            {
                slika = Properties.Resources.block1;
            }
   }
        public override bool Dopir(Pacman p)
        {
            switch (p.nasoka)
            {
                case Pacman.DIRETION.DOWN:
                    p.nasoka = Pacman.DIRETION.UP;
                    break;
                case Pacman.DIRETION.UP:
                    p.nasoka = Pacman.DIRETION.DOWN;
                    break;
                case Pacman.DIRETION.RIGHT:
                    p.nasoka = Pacman.DIRETION.LEFT;
                    break;
                case Pacman.DIRETION.LEFT:
                    p.nasoka = Pacman.DIRETION.RIGHT;
                    break;
            }
            p.Move();
 

            return false;
        }
    }
}
