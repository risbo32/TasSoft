using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas.UI
{
   public class PrettyProgressBar : ProgressBar
    {
        [Description("Definit l'espacement entre la bordure et la progress Bar")]
        public int Spacing { get; set; }
        private Image image = new Bitmap(@"D:/collapse_arrow.png");

        public Color PaintColor { get; set; } = Color.Blue;
        public Color PaintFillColor { get; set; } = Color.AliceBlue;
        Pen penBorderDrawing;
        Pen penProgressDrawing;

        public PrettyProgressBar()
        {
            penBorderDrawing = new Pen(PaintColor);
            penBorderDrawing.Width = 2;
            penBorderDrawing.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            penProgressDrawing = new Pen(PaintFillColor);
            penProgressDrawing.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            this.Value = 34;
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            e.Graphics.DrawRectangle(penBorderDrawing, 0, 0, this.Value, this.Height);
            e.Graphics.FillRectangle(Brushes.Azure, this.DisplayRectangle);
            e.Graphics.DrawImage(image, 0, 0);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            //base.OnPaintBackground(pevent);
            pevent.Graphics.DrawImage(image, 0, 0);
        }

        private void drawBoxLines(Graphics graphics)
        {

        }

        
        
    }
}
