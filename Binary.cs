//BMP to Binary

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficacionApps
{
    public partial class Binary : Form
    {
        string file;
        Bitmap bmp;
        byte[] bmpData;
        public Binary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                bmp = new Bitmap(@"" + file + "", true);
                bmpData = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, ImageFormat.Png);
                    ms.Seek(0, 0);
                    bmpData = ms.ToArray();
                }
                string hexData = "";
                foreach (byte b in bmpData)
                {
                    hexData = hexData + " " + b.ToString("x2").PadLeft(2, '0');
                }
                using (StreamWriter sw = new StreamWriter(@"D:\\bmpHexStuff.bin"))
                {
                    sw.Write(hexData);
                }

                MessageBox.Show("Conversión Realizada Correctamente!");
            }else{
                MessageBox.Show("No se selecciono ninguna imagen!");
            }
        }
    }
}
