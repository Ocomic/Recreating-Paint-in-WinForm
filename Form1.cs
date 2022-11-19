using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recreating_Paint_in_WinForm
{
    public partial class Form1 : Form
    {
        
        Bitmap bmp;
        Graphics graphics;
        int index;
        bool paint = false;
        Point pointX, pointY;
        Pen DrawPen = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 10);
        int x, y, sX, sY, cX, cY;

        public Form1()
        {
            InitializeComponent();

            picture.Width = 1300;
            picture.Height = 800;
            bmp = new Bitmap(picture.Width, picture.Height);
            graphics = Graphics.FromImage(bmp);
            picture.Image = bmp;
            graphics.Clear(Color.White);

        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            pointY = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    pointX = e.Location;
                    graphics.DrawLine(DrawPen, pointX, pointY);
                    pointY = pointX;
                }

                if (index == 2)
                {
                    pointX = e.Location;
                    graphics.DrawLine(eraser, pointX, pointY);
                    pointY = pointX;
                }
            }
            picture.Refresh();//without refreshing you won't see the drawings and the image would stay white
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }



        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }
    }
}
