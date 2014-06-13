
//Bresenham Algorithm

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficacionApps
{
    public partial class Bresenham : Form
    {
        Bitmap draw;
        int xx = 10, yy = 10;
        int dx, dy, x, y, xEnd, p, xa, xb, ya, yb;
        public Bresenham()
        {
            InitializeComponent();
            draw = new Bitmap(drawArea.Width, drawArea.Height);
        }

        private void dibujarBtn_Click_1(object sender, EventArgs e)
        {
            string[] datosI;
            string[] datosS;
            String puntoI = pointFirst.Text;
            String puntoS = pointSecond.Text;
            label4.Text = puntoI;
            label5.Text = puntoS;
            pointFirst.Text = "";
            pointSecond.Text = "";
            datosI = puntoI.Split(',');
            datosS = puntoS.Split(',');
            Form1 ins = new Form1();
            x = 0;
            y = 0;
            xEnd = 0;
            p = 0;
            Console.Write(int.Parse(datosI[0]) + " " + int.Parse(datosI[1]) + " " + int.Parse(datosS[0]) + " " + int.Parse(datosS[1]));
            xa = int.Parse(datosI[0]);
            ya = int.Parse(datosI[1]);
            xb = int.Parse(datosS[0]);
            yb = int.Parse(datosS[1]);

            dx = Math.Abs(xa - xb);
            dy = Math.Abs(ya - yb);
            p = (2 * dy) - dx;

            if (xa > xb)
            {
                x = xb;
                y = yb;
                xEnd = xa;
            }
            else
            {
                x = xa;
                y = ya;
                xEnd = xb;
            }
            draw.SetPixel(x, y, Color.Black);
            drawArea.Image = draw;
            do
            {
                x = x + 1;
                if (p < 0)
                {
                    p = p + 2 * dy;
                }
                else
                {
                    y = y + 1;
                    p = p + 2 * (dy - dx);
                }
                draw.SetPixel(x, y, Color.Black);
                drawArea.Image = draw;
            } while (x < xEnd);
        }

        private void pxlBtn_Click_1(object sender, EventArgs e)
        {
            draw.SetPixel(xx, yy, Color.Black);
            xx = xx + 1;
            yy = yy + 1;
            drawArea.Image = draw;
        }
    }
}
