using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_prototipo
{
    public partial class Carga : Form
    {
        Timer t = new Timer();
        double pbUnit;
        int pbWIDTH, pbHEIGHT, PBComplete;
        Bitmap bmp;

        Graphics g;
        public Carga()
        {
            InitializeComponent();
        }

        private void Carga_Load(object sender, EventArgs e)
        {
            pbWIDTH = picCarga.Width;
            pbHEIGHT = picCarga.Height;
            pbUnit = pbWIDTH / 100.0;

            PBComplete = 0;

            bmp = new Bitmap(pbWIDTH, pbHEIGHT);
            t.Interval = 50;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            TextureBrush texture = new TextureBrush(Image.FromFile(Path.GetFullPath("barra.png")));
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.FillRectangle(texture, new Rectangle(0, 0, (int)(PBComplete * pbUnit), pbHEIGHT));
            g.DrawString(PBComplete + "%", new Font("Arial", pbHEIGHT / 2), Brushes.Black, new PointF(pbWIDTH / 2 - pbHEIGHT, pbHEIGHT/10));
            picCarga.Image = bmp;
            PBComplete++;
            if (PBComplete > 100)
            {
                g.Dispose();
                t.Stop();
                this.Close();
            }

        }
    }
}
