using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nfl
{
    public partial class Form1 : Form
    {
        Image Football;
        bool goLeft, goRight, goUp, goDown;
        int speed = 10;
        int positionX = 20;
        int positionY = 180;
        int height = 40;

    
        int width = 60;

 

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("football2.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Football = Image.FromFile("ball.png");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(goLeft && positionX > 0)
            {
                positionX -= speed;
            }
            if(goRight && positionX + width < ClientSize.Width)
            { positionX += speed; }
            if(goUp && positionY > 0)
            {
                positionY -= speed; 
            }
            if(goDown && positionY + height < ClientSize.Height)
            { positionY += speed; }
            this.Invalidate();

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;
            Canvas.DrawImage(Football, positionX, positionY, width, height);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Left)
            {
                goLeft = false;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if(e.KeyCode == Keys.Up)
            {
                goUp = false;   
            }
            if(e.KeyCode == Keys.Down)
            {
                goDown = false; 
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

        }

    }
}
