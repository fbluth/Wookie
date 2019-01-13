using DevExpress.Utils.Svg;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

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

        /// <summary>
        /// Returns a binary stream from the given SVG Image
        /// </summary>
        /// <param name="image">SVG image that has to be converted into a binary object.</param>
        /// <returns></returns>
        public static System.Data.Linq.Binary GetBinaryFromSvgImage(SvgImage image)
        {
            // If the input image is null, nothing has to be done
            if (image == null) return null;

            System.Data.Linq.Binary binary = null;

            try
            {
                // Convert the image into a binary object using a MemoryStream and the SvgSerializer from DevExpress
                using (MemoryStream ms = new MemoryStream())
                {
                    SvgSerializer.SaveSvgImageToXML(ms, image);
                    binary = new System.Data.Linq.Binary(ms.GetBuffer());
                }
            }
            catch
            {
                binary = null;
            }

            return binary;
        }
        
        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static System.Drawing.Image ResizeImage(System.Drawing.Image image, int width, int height)
        {
            if (image == null) return null;
            if (width < 0 || height < 0) return null;

            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
