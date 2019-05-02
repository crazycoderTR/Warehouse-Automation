using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace MessagingToolkit.QRCode.Codec.Data
{
    public class QRCodeBitmapImage : QRCodeImage
    {
         Bitmap image;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="image">Bitmap image/param>
        public QRCodeBitmapImage(Bitmap image)
        {
            this.image = image;
        }

        virtual public int Width
        {
            get
            {
                return image.Width;
            }

        }
        virtual public int Height
        {
            get
            {
                return image.Height;
            }

        }
     

        public virtual int GetPixel(int x, int y)
        {
            return image.GetPixel(x, y).ToArgb();
        }

        public int[][] GetPixelsLock()
        {
            BitmapData bData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),ImageLockMode.ReadOnly,PixelFormat.Format32bppRgb);
            int bpp = 4;
            int nBytes = image.Height * image.Width * bpp;
            int[][] pixels = new int[image.Width][];

            for (int x = 0; x < image.Width; x++)
            {
                pixels[x] = new int[image.Height];
                for (int y = 0; y < image.Height; y++)
                {
                    int offset = (y * bData.Stride) + (x * bpp);

                    byte b = Marshal.ReadByte(bData.Scan0, offset);
                    byte g = Marshal.ReadByte(bData.Scan0, offset + 1);
                    byte r = Marshal.ReadByte(bData.Scan0, offset + 2);

                    pixels[x][y] =
                    (int)(255 << 24) +
                    (int)(r << 16) +
                    (int)(g << 8) +
                    (int)b;
                }
            }

            image.UnlockBits(bData);

            return pixels;
        }
    }
}
