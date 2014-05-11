using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PacmanWorld
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        public void TextBoxValue(string value)
        {
           label1.Text  = value;
            label1.ForeColor = Color.Red;
            
           


        }

        

    }
}
