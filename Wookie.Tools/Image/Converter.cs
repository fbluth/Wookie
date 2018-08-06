using DevExpress.Utils.Svg;
using System.Drawing;
using System.IO;


namespace Wookie.Tools.Image
{
    public static class Converter
    {
        public static System.Data.Linq.Binary GetBinaryFromImage(System.Drawing.Image image)
        {
            if (image == null) return null;
            System.Data.Linq.Binary binary;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                binary = new System.Data.Linq.Binary(ms.GetBuffer());
            }

            return binary;
        }

        public static System.Drawing.Image GetImageFromBinary(System.Data.Linq.Binary binary)
        {
            if (binary == null) return null;
            System.Drawing.Image returnImage = null;

            using (MemoryStream ms = new MemoryStream(binary.ToArray()))
            {
                try
                {
                    returnImage = System.Drawing.Image.FromStream(ms);
                }
                catch
                {
                    returnImage = null;
                }

            }

            return returnImage;
        }

        public static SvgImage GetSvgImageFromBinary(System.Data.Linq.Binary binary)
        {
            if (binary == null) return null;
            SvgImage returnImage = null;

            using (MemoryStream ms = new MemoryStream(binary.ToArray()))
            {
                try
                {
                    returnImage = SvgImage.FromStream(ms);
                }
                catch
                {
                    returnImage = null;
                }
            }

            return returnImage;
        }
    }
}
