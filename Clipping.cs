
// Window-Viewport with Clipping

using System.Drawing.Drawing2D;
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
    public partial class Clipping : Form
    {

        //Updates
        
        int[] datosx = { 180, 350, 350, 180 };
        int[] datosy = { 300, 300, 160, 160 };


        //Rescatando viejos valores;
        int[] datosxres = { 180, 350, 350, 180 };
        int[] datosyres = { 300, 300, 160, 160 };
        Point point1;
        Point point2;
        Point point3;
        Point point4;
       
        public Clipping()
        {
            InitializeComponent();
            point1 = new Point(datosx[0], datosy[0]);
            point2 = new Point(datosx[1], datosy[1]);
            point3 = new Point(datosx[2], datosy[2]);
            point4 = new Point(datosx[3], datosy[3]);
            this.Paint += new PaintEventHandler(drawingPanel_Paint);
            
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            point1 = new Point(datosxres[0], datosyres[0]);
            point2 = new Point(datosxres[1], datosyres[1]);
            point3 = new Point(datosxres[2], datosyres[2]);
            point4 = new Point(datosxres[3], datosyres[3]);
            Point[] polys = { point1, point2, point3, point4 };
            drawingPanel.Invalidate();
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath path = new GraphicsPath();
            Point[] polys = { point1, point2, point3, point4 };
            path.AddPolygon(polys);
            Pen pl = new Pen(Color.Black, 3);
            Region region = new Region(path);
            g.DrawPath(pl, path);
            g.SetClip(region, CombineMode.Replace);


            //Dibujados
            Pen aPen = new Pen(Color.Gray, 3);
            g.DrawLine(aPen, 180, 100, 300, 300);
            g.DrawLine(aPen, 300, 300, 60, 300);
            g.DrawLine(aPen, 60, 300, 180, 100);

            g.DrawRectangle(aPen, 190, 70, 450, 300);

            Rectangle rec = new Rectangle(450, 250, 200, 200);
            g.DrawEllipse(aPen, rec);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                datosy[i] = datosy[i] - 10;
            }

            point1 = new Point(datosx[0], datosy[0]);
            point2 = new Point(datosx[1], datosy[1]);
            point3 = new Point(datosx[2], datosy[2]);
            point4 = new Point(datosx[3], datosy[3]);
            Point[] polys = { point1, point2, point3, point4 };
            drawingPanel.Invalidate();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                datosy[i] = datosy[i] + 10;
            }

            point1 = new Point(datosx[0], datosy[0]);
            point2 = new Point(datosx[1], datosy[1]);
            point3 = new Point(datosx[2], datosy[2]);
            point4 = new Point(datosx[3], datosy[3]);
            Point[] polys = { point1, point2, point3, point4 };
            drawingPanel.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                datosx[i] = datosx[i] + 10;
            }

            point1 = new Point(datosx[0], datosy[0]);
            point2 = new Point(datosx[1], datosy[1]);
            point3 = new Point(datosx[2], datosy[2]);
            point4 = new Point(datosx[3], datosy[3]);
            Point[] polys = { point1, point2, point3, point4 };
            drawingPanel.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                datosx[i] = datosx[i] - 10;
            }

            point1 = new Point(datosx[0], datosy[0]);
            point2 = new Point(datosx[1], datosy[1]);
            point3 = new Point(datosx[2], datosy[2]);
            point4 = new Point(datosx[3], datosy[3]);
            Point[] polys = { point1, point2, point3, point4 };
            drawingPanel.Invalidate();
        }
    }
}
