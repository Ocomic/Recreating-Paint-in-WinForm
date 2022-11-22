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
        float penSize = 1;
        bool paint = false;
        Point pointX, pointY;
        Pen DrawPen = new Pen(Color.Black);
        Pen eraser = new Pen(Color.White, 10);
        int x, y, sX, sY, clickX, clickY;

        

        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(picture.Width, picture.Height);
            graphics = Graphics.FromImage(bmp);
            picture.Image = bmp;
            graphics.Clear(Color.White);

        }
                
        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            pointY = e.Location; // X+Y coordinates of click event in the Image/ Picture

            clickX = e.X;
            clickY = e.Y;
            picture.Cursor = Cursors.Cross;


        }
        

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    pointX = e.Location;
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    DrawPen.StartCap = DrawPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
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
            sX = x - clickX;
            sY = y - clickY;

            coordinates.Text = "Location:" + e.Location + " x:" + x + " y:" + y  +" clickX:" +clickX +" clickY:" +clickY +"sX:" + sX + " sY:" +sY;
        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (paint)
            {
                
                if (index == 4)
                {
                    graphics.DrawRectangle(DrawPen, clickX, clickY, sX, sY);
                }
                if (index == 5)
                {
                    graphics.DrawEllipse(DrawPen, clickX, clickY, sX, sY);
                }
                if (index == 6)
                {
                    graphics.DrawLine(DrawPen, clickX, clickY, x, y);
                }
                if (index == 7)
                {
                    PointF[] triangle = new PointF[]
                {
                    new PointF(clickX, clickY),
                    new PointF(sY, sX),
                    new PointF(clickX +sX, clickY +sY),

                };
                    graphics.DrawPolygon(DrawPen, triangle);
                }

            }
        }

        
        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            if (index == 4)
            {
                graphics.DrawRectangle(DrawPen, clickX, clickY, sX, sY);//show shape on the picture to see what you draw
            }
            if (index == 5)
            {
                graphics.DrawEllipse(DrawPen, clickX, clickY, sX, sY);
            }
            if (index == 6)
            {
                graphics.DrawLine(DrawPen, clickX, clickY, x, y);
            }
            if (index == 7)
            {
                PointF[] triangle = new PointF[]
                {
                    new PointF(clickX, clickY),
                    new PointF(sY, sX),
                    new PointF(clickX +sX, clickY +sY),

                };

                graphics.DrawPolygon(DrawPen,triangle);
            }

        }
        

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;           

        }
        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void ellipseBtn_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void triangleBtn_Click(object sender, EventArgs e)
        {
            index = 7;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            penSize = Convert.ToInt16(comboBox1.SelectedIndex);
            DrawPen.Width = penSize;
            eraser.Width = penSize;      
        }

    }
}
