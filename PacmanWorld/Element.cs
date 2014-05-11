using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PacmanWorld
{
    public abstract class Element
    {
        public Bitmap slika;
        public abstract bool Dopir(Pacman p);

    }
}
