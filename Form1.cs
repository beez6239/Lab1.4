using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._4
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        
        bool paint = false;
        Point px, py;
        
        Pen p = new Pen(Color.Black,1);
        Pen B = new Pen(Color.Black,4);

        Pen bl = new Pen(Color.Black, 12);
        Pen blue = new Pen(Color.Blue, 12);
        Pen green = new Pen(Color.Green, 12);
        Pen Cyan = new Pen(Color.Cyan, 12);
        Pen red = new Pen(Color.Red, 12);
        Pen mag = new Pen(Color.Magenta, 12);
        Pen yel = new Pen(Color.Yellow, 12);
        Pen wh = new Pen(Color.White, 12);
        



        Brush A;
        
        int index;
        int x, y, sx, sy, cx, cy;
        
        
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(ShapeView.Width, ShapeView.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            ShapeView.Image = bm;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {

            index = 6;
        }

        private void ShapeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void ShapeView_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cx, cy, sx, sy);
                }

                if (index == 4)
                {
                    g.DrawRectangle(p, cx, cy, sx, sy);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cx, cy, x, y);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            index = 8;
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            index = 9;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            index = 10;
        }

        private void btnMagenta_Click(object sender, EventArgs e)
        {
            index = 11;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            index = 12;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            index = 13;
        }

        private void ShapeView_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cx = e.X;
            cy = e.Y;
        }

        private void ShapeView_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            px = e.Location;

            sx = x - cx;
            sy = y - cy;
            if(index == 3)
            {
                g.DrawEllipse(p, cx, cy, sx, sy);
            }

            if (index == 4)
            {
                g.DrawRectangle(p, cx, cy, sx, sy);
            }
            if (index == 5)
            {
                g.DrawLine(p, cx, cy, x, y);
            }
        }

        private void ShapeView_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (paint)
            {
                if(index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(B, px, py);
                    py = px;
                }
               
                if (index == 6)
                {
                    px = e.Location;
                    g.DrawLine(bl, px, py);
                    py = px;
                }

                if (index == 7)
                {
                    px = e.Location;
                    g.DrawLine(blue, px, py);
                    py = px;
                }
                if (index == 8)
                {
                    px = e.Location;
                    g.DrawLine(green, px, py);
                    py = px;
                }
                if (index == 9)
                {
                    px = e.Location;
                    g.DrawLine(Cyan, px, py);
                    py = px;
                }
                if (index == 10)
                {
                    px = e.Location;
                    g.DrawLine(red, px, py);
                    py = px;
                }
                if (index == 11)
                {
                    px = e.Location;
                    g.DrawLine(mag, px, py);
                    py = px;
                }
                if (index == 12)
                {
                    px = e.Location;
                    g.DrawLine(yel, px, py);
                    py = px;
                }
                if (index == 13)
                {
                    px = e.Location;
                    g.DrawLine(wh, px, py);
                    py = px;
                }
            }
            
            ShapeView.Refresh();
            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;


        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            ShapeView.Image = bm;
            index = 0;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            index = 1;
            
        }
    }
}
