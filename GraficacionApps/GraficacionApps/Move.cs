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
    public partial class Move : Form
    {
        Bitmap draw;
        int[] datosx = new int[3];
        int[] datosy = new int[3];
        int[] protacion = new int[2];
        float[] datosmodx = new float[3];
        float[] datosmody = new float[3];
        int i = 0, j = 0, acumulador = 0, tetAngule2;
        double tetaAngule;
        public Move()
        {
            InitializeComponent();
            draw = new Bitmap(drawArea.Height, drawArea.Width);
            drawArea.Image = draw;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i <= 3)
            {
                datosx[i - 1] = int.Parse(xpoint.Text);
                datosy[i - 1] = int.Parse(ypoint.Text);
                xpoint.Text = "";
                ypoint.Text = "";
            }
            else { MessageBox.Show("Solo se permite introducir 3 puntos (X y Y)."); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            j = 0;
            foreach (int data in datosx)
            {
                acumulador = acumulador + data;
            }

            j = 0;
            protacion[0] = acumulador / 3;
            acumulador = 0;

            foreach (int data in datosy)
            {
                acumulador = acumulador + data;
            }

            j = 0;
            protacion[1] = acumulador / 3;
            acumulador = 0;
            valPR.Text = "[ " + protacion[0] + " , " + protacion[1] + " ]";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pen blackPen = new Pen(Color.Gray, 1);
            Point point1 = new Point(datosx[0], datosy[0]);
            Point point2 = new Point(datosx[1], datosy[1]);
            Point point3 = new Point(datosx[2], datosy[2]);
            Graphics g = Graphics.FromImage(draw);
            Point[] curvepoints = { point1, point2, point3 };
            g.DrawPolygon(blackPen, curvepoints);
            drawArea.Image = draw;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            tetAngule2 = int.Parse(teta.Text);
            tetaAngule = Math.PI * tetAngule2 / 180; 
            for (int k = 0; k <= 2; k++)
            {
                datosmody[k] = Convert.ToSingle(Math.Abs(protacion[0] + ((datosx[k] - protacion[0]) * (Math.Cos(tetaAngule))) - ((datosy[k] - protacion[1]) * (Math.Sin(tetaAngule)))));
                datosmodx[k] = Convert.ToSingle(Math.Abs(protacion[0] + ((datosx[k] - protacion[0]) * (Math.Sin(tetaAngule))) - ((datosy[k] - protacion[1]) * (Math.Cos(tetaAngule)))));
            }

            Pen blackPen = new Pen(Color.Red, 1);
            PointF point1 = new PointF(datosmodx[0], datosmody[0]);
            PointF point2 = new PointF(datosmodx[1], datosmody[1]);
            PointF point3 = new PointF(datosmodx[2], datosmody[2]);
            Console.WriteLine(" " + point1 + " " + point2 + " " + point3);
            Graphics g = Graphics.FromImage(draw);
            PointF[] curvepoints = { point1, point2, point3 };
            g.DrawPolygon(blackPen, curvepoints);
            drawArea.Image = draw;
        }
    }
}
