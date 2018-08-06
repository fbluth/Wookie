using System.Drawing;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Text;
using DevExpress.XtraSplashScreen;


namespace Wookie.Controls
{
    class SplashImagePainter : ICustomImagePainter
    {
        static SplashImagePainter()
        {
            Painter = new SplashImagePainter();
        }
        protected SplashImagePainter() { }
        public static SplashImagePainter Painter { get; private set; }

        ViewInfo info = null;
        public ViewInfo ViewInfo
        {
            get
            {
                if (this.info == null) this.info = new ViewInfo();
                return this.info;
            }
        }

        #region Drawing
        public void Draw(GraphicsCache cache, Rectangle bounds)
        {
            PointF pt = ViewInfo.CalcProgressLabelPoint(cache, bounds);
            Rectangle rt = ViewInfo.CalcProgressRectangle(cache, bounds);
            cache.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(32,114,180)), rt);
            cache.Graphics.DrawString(ViewInfo.Text, ViewInfo.ProgressLabelFont, ViewInfo.Brush, pt);
        }
        #endregion
    }

    class ViewInfo
    {
        public ViewInfo()
        {
            Counter = 1;
            Stage = string.Empty;
        }

        public int Counter { get; set; }
        public string Stage { get; set; }

        public PointF CalcProgressLabelPoint(GraphicsCache cache, Rectangle bounds)
        {
            const int yOffset = 20;
            Size size = TextUtils.GetStringSize(cache.Graphics, Text, ProgressLabelFont);
            return new Point(bounds.Width / 2 - size.Width / 2, bounds.Height-yOffset);
        }

        public Rectangle CalcProgressRectangle(GraphicsCache cache, Rectangle bounds)
        {
            const int height = 20;
            return new Rectangle(new Point(0, bounds.Height - height), new Size(bounds.Width * Counter / 100, height));
        }
        Font progressFont = null;
        public Font ProgressLabelFont
        {
            get
            {
                if (this.progressFont == null) this.progressFont = new Font("Calibri", 12);
                return this.progressFont;
            }
        }
        Brush brush = null;
        public Brush Brush
        {
            get
            {
                if (this.brush == null) this.brush = new SolidBrush(Color.Black);
                return this.brush;
            }
        }
        public string Text { get { return string.Format("{0} - ({1}%)", Stage, Counter.ToString("D2")); } }
    }

}
