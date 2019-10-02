using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTas.components
{
    public class MonBouton : Button
    {
        public MonBouton()
        {
        }

        public Image NormalImage { get; set; }
        public Image HoverImage { get; set; }
        public Image ClickedImage { get; set; }
        

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        private void drawButton(Graphics g,Image image)
        {
            Rectangle rectangle = new Rectangle
            {
                Height = this.DisplayRectangle.Height - 30,
                Width = this.DisplayRectangle.Width - 60,
                X = this.DisplayRectangle.X + 30,
                Y =this.DisplayRectangle.Y +30
            };
            g.DrawImage(image, this.DisplayRectangle);
            //g.DrawString(this.Text, this.Font, new Brush(), this.Padding, this.Padding);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            drawButton(pevent.Graphics, NormalImage);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
           // base.OnPaintBackground(pevent);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            
        }

    }
}
