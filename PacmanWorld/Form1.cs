using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace PacmanWorld
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer;
        static readonly int WORLD_WIDTH = 40;
        static readonly int WORLD_HEIGHT = 16;
        Bitmap doubleBuffer;
        Pacman pacman;
        Graphics graphics;
        Random randomFood;
        Element[][] element;
        
       

 
        public Form1()
        {
            InitializeComponent();
            newGame();
            

        }
        public void newGame()
        {
            randomFood = new Random();
            this.Width = 30 * WORLD_WIDTH;
            this.Height = 30 * WORLD_HEIGHT + 22;
            doubleBuffer = new Bitmap(30 * (WORLD_WIDTH + 1), 30 * (WORLD_HEIGHT + 1));
            graphics = CreateGraphics();

            pacman = new Pacman(WORLD_WIDTH / 2, WORLD_HEIGHT / 2, Pacman.DIRETION.RIGHT);

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);

            timer.Interval = 300;
            timer.Start();
            element = new Element[WORLD_HEIGHT][];
           

      
            for (int i = 0; i < WORLD_HEIGHT; i++)
            {
                element[i] = new Element[WORLD_WIDTH];
                for (int j = 0; j < element[i].Length; j++)
                {
                    if (i != pacman.Y || j != pacman.X)
                        if (i == 0 || i == WORLD_HEIGHT - 1 ||
                            j == 0 || j == WORLD_WIDTH - 1)
                            element[i][j] = new Block();
                        else
                            switch (randomFood.Next(5))
                            {
                                case 0: element[i][j] = new Food1(1); break;
                                case 1: element[i][j] = new Food2(1); break;
                                case 2: element[i][j] = new Block(1); break;
                                case 3: element[i][j] = new Mushroom(1); break;
                                default: /* element[i][j] = ; */ break;
                            }
                }
            }
        }
        public void initLevel2()
        {
            randomFood = new Random();

            pacman.Points = 0;
            graphics.Clear(Color.Orange);
            graphics = this.CreateGraphics();
            string drawString = "Wait!!!   You go on next level!!!";
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 30);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            float x = 300.0F;
            float y = 100.0F;
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
           graphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();

          
            element = new Element[WORLD_HEIGHT][];

      
            for (int i = 0; i < WORLD_HEIGHT; i++)
            {
                element[i] = new Element[WORLD_WIDTH];
                for (int j = 0; j < element[i].Length; j++)
                {
                    if (i != pacman.Y || j != pacman.X)
                        if (i == 0 || i == WORLD_HEIGHT - 1 ||
                            j == 0 || j == WORLD_WIDTH - 1)
                            element[i][j] = new Block();
                        else
                            switch (randomFood.Next(5))
                            {
                                case 0: element[i][j] = new Food1(2); break;
                                case 1: element[i][j] = new Food2(2); break;
                                case 2: element[i][j] = new Block(2); break;
                                case 3: element[i][j] = new Mushroom(2); break;
                                default: /* element[i][j] = ; */ break;
                            }
                }
            }
        }
       
        void timer_Tick(object sender, EventArgs e)
        {


            Graphics g = Graphics.FromImage(doubleBuffer);
            int W = this.Width / WORLD_WIDTH;
            int H = (this.Height - 22) / WORLD_HEIGHT;

            pacman.Move();
            if (element[pacman.Y][pacman.X] != null)
            
                if (element[pacman.Y][pacman.X].Dopir(pacman))
                {
                    element[pacman.Y][pacman.X] = null;
                   
                    
                    if (pacman.Points >200)
                    {
                        initLevel2();
                        return;
                    }
                    if (pacman.LifePoints < 4)
                    {
                        pacman.brush = Brushes.Yellow;
                    }
                    
                   
                    if (pacman.LifePoints == 0)
                    {
                        timer.Stop();

                        GameOver form = new GameOver();
                        form.TextBoxValue("Game over!  Total score:" + pacman.Points.ToString());
                        form.ShowDialog();

                    }

                }
                toolStripStatusLabel1.Text = "Total Score: " + pacman.Points.ToString();
                toolStripStatusLabel2.Text = "Life:" + pacman.LifePoints;
               
          
            g.Clear(Color.White);
            g.DrawImage(pacman.slika, pacman.X * W, pacman.Y * H, W, H);
             for (int i = 0; i <element.Length; i++)
            {
                for (int j = 0; j < element[i].Length; j++)
                {
                    if (element[i][j] != null)
                    {
                        g.DrawImage(element[i][j].slika, j * W, i * H, W, H);
                    }
                }
            }

            graphics.DrawImageUnscaled(doubleBuffer, 0, 0);
            
        }
      

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                pacman.nasoka =Pacman.DIRETION.UP;
            }
            if (e.KeyCode == Keys.Down)
            {
                pacman.nasoka = Pacman.DIRETION.DOWN;
            }
            if (e.KeyCode == Keys.Right)
            {
                pacman.nasoka = Pacman.DIRETION.RIGHT;
            }
            if (e.KeyCode == Keys.Left)
            {
                pacman.nasoka = Pacman.DIRETION.LEFT;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        }
    }

