using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace MediaPlayer_0
{
    class MyBtn:Button
    {
        private int boardersize=0;
        private int BorderRadius = 40;
        private Color BorderColor = Color.PaleVioletRed;
        public MyBtn()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MidnightBlue;
            this.ForeColor = Color.White;
        }

        private GraphicsPath GetGraphicsPath(RectangleF rect,float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width=radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width=radius, rect.Height=radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height= radius, radius,radius, 90, 90);
            path.CloseFigure();
            return path;


        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 8f, this.Height - 1);

            if (BorderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetGraphicsPath(rectSurface, BorderRadius)) ;
                using (GraphicsPath pathSurfacF = GetGraphicsPath(rectBorder, BorderRadius-1F)) ;
                using (Pen penSurface=new Pen(this.Parent.BackColor,2)) ;
                using (Pen penBorder = new Pen(BorderColor,boardersize)) ;

                {
                    //penBorder.Aligrament = PenAlignment.Insert;
                    //this.Ragion = new Ragion(pathSurface);
                    //pevent.Graphics.DrawPath(PenSurface, pathSurface);


                }





            }
        }
    }
}
