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
    public partial class Viewport : Form
    {
        //Definición de la ventana;
        float xMin = 0;
        float xMax = 10;
        float yMin = 0;
        float yMax = 10;

        //Unidades en Pixel;
        private int offset = 15;
        public Viewport()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.BackColor = Color.White;
            //Dibujando;
            drawingPanel.Paint += new PaintEventHandler(drawingPanel_Paint);
            drawingPanel.BorderStyle = BorderStyle.FixedSingle;
            drawingPanel.Anchor = AnchorStyles.Bottom;
            drawingPanel.Anchor = AnchorStyles.Left;
            drawingPanel.Anchor = AnchorStyles.Right;
            drawingPanel.Anchor = AnchorStyles.Top;
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            drawingPanel.Left = offset;
            drawingPanel.Top = offset;
            drawingPanel.Width = ClientRectangle.Width - 2 * offset;
            drawingPanel.Height = ClientRectangle.Height - 2 * offset;
            Graphics g = e.Graphics;
            Pen aPen = new Pen(Color.Green, 3);
            Pen aPen2 = new Pen(Color.Beige, 3);
            Pen aPen3 = new Pen(Color.OrangeRed, 3);
            SolidBrush aBrush = new SolidBrush(Color.Black);
            SolidBrush aBrush2 = new SolidBrush(Color.MediumBlue);
            PointF[] pointsPolygon = {
                                         Point2D(new PointF(2, 3)),
                                         Point2D(new PointF(5, 5)), 
                                         Point2D(new PointF(10, 30))
                                     };

            PointF[] pol = {
                               Point2D(new PointF(70,7)),
                               Point2D(new PointF(-15,30)),
                               Point2D(new PointF(30,6))
                           };

            //g.FillPolygon(aBrush2, pol);
            //g.FillPolygon(aBrush, pointsPolygon);
            g.DrawLine(aPen, Point2D(new PointF(1, 1)), Point2D(new PointF(3,6)));
            g.DrawLine(aPen, Point2D(new PointF(3,6)), Point2D(new PointF(5, 1)));
            g.DrawLine(aPen, Point2D(new PointF(5, 1)), Point2D(new PointF(1, 1)));

            g.DrawLine(aPen2, Point2D(new PointF(1, -2)), Point2D(new PointF(1, -4)));
            g.DrawLine(aPen2, Point2D(new PointF(1, -4)), Point2D(new PointF(5, -4)));
            g.DrawLine(aPen2, Point2D(new PointF(5, -4)), Point2D(new PointF(5, -2)));
            g.DrawLine(aPen2, Point2D(new PointF(5, -2)), Point2D(new PointF(1, -2)));

            
            
            //aPen.Dispose();
            //g.Dispose();
        }

        private PointF Point2D(PointF ptf)
        {
            PointF aPoint = new PointF();
            aPoint.X = (ptf.X - xMin) * drawingPanel.Width / (xMax - xMin);
            aPoint.Y = drawingPanel.Height - (ptf.Y - yMin) * drawingPanel.Height / (yMax - yMin);
            return aPoint;
        }

        /*private Point Point2DD(Point ptf)
        {
            Point aPoint = new Point();
            aPoint.X = Convert.ToInt32((ptf.X - xMin) * drawingPanel.Width / (xMax - xMin));
            aPoint.Y = Convert.ToInt32(drawingPanel.Height - (ptf.Y - yMin) * drawingPanel.Height / (yMax - yMin));
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            xMin = xMin + 0;
            xMax = xMax + 0;
            yMin = yMin + 2;
            yMax = yMax + 2; 
            drawingPanel.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xMin = xMin + 0;
            xMax = xMax + 0;
            yMin = yMin - 2;
            yMax = yMax - 2;
            drawingPanel.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xMin = xMin + 2;
            xMax = xMax + 2;
            yMin = yMin + 0;
            yMax = yMax + 0;
            drawingPanel.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xMin = xMin - 2;
            xMax = xMax - 2;
            yMin = yMin + 0;
            yMax = yMax + 0;
            drawingPanel.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            xMin = 0;
            xMax = 10;
            yMin = 0;
            yMax = 10;
            drawingPanel.Invalidate();
        }


    }
}
