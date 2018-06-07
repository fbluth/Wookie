using DevExpress.Utils.Svg;
using System.Drawing;
using System.IO;


namespace Wookie.Tools
{
    public static class ImageHelper
    {
        public static System.Data.Linq.Binary GetBinaryFromImage(Image image)
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

        public static Image GetImageFromBinary(System.Data.Linq.Binary binary)
        {
            if (binary == null) return null;
            Image returnImage = null;

            using (MemoryStream ms = new MemoryStream(binary.ToArray()))
            {
                returnImage = Image.FromStream(ms);

            }

            return returnImage;
        }

        public static SvgImage GetSvgImageFromBinary(System.Data.Linq.Binary binary)
        {
            if (binary == null) return null;
            SvgImage returnImage = null;

            using (MemoryStream ms = new MemoryStream(binary.ToArray()))
            {
                returnImage = SvgImage.FromStream(ms);

            }

            return returnImage;
        }
    }
}
