using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas.UI
{
   public class MyProgressBar :Control
    {
        public MyProgressBar()
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, false);
            Maximum = 100;
            this.ForeColor = Color.Red;
            this.BackColor = Color.White;
            penBorderDrawing = new Pen(PaintColor);
            penBorderDrawing.Width = 5;
            penBorderDrawing.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            brushDrawing = Brushes.Brown;
        }
        public decimal Minimum { get; set; }  // fix: call Invalidate in setter
        public decimal Maximum { get; set; }  // fix as above
        public Color PaintColor { get; set; } = Color.Blue;
        public Color PaintFillColor { get; set; } = Color.AliceBlue;
        Pen penBorderDrawing;
        Brush brushDrawing;

        private decimal mValue;
        public decimal Value
        {
            get { return mValue; }
            set { mValue = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int padding = 5;
            var rc = new RectangleF(0, 0, (float)(this.Width * (Value - Minimum) / Maximum), this.Height);
            using (var br = new SolidBrush(this.ForeColor))
            {
                e.Graphics.FillRectangle(br, rc);
                e.Graphics.DrawRectangle(penBorderDrawing, 0, 0,this.Width, this.Height);
                e.Graphics.FillRectangle(brushDrawing, padding -2, padding -2, (float)this.Value -padding, this.Height-(padding*8));
            }
         //   base.OnPaint(e);
        }

        public Vector3 vecteur { get; set; } = new Vector3();


        public  struct Vector3{
            int height;
            int width;
            int z;
        }
    }
}
