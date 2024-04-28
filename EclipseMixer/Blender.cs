using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace EclipseBlender
{
    public class Blender
    {
        public Blender()
        {
        }

        private Color eclipseBlend(Color bg, Color sun, double compressRate)
        {
            const int RedFactor = (int)(0.298912 * 1024);
            const int GreenFactor = (int)(0.586611 * 1024);
            const int BlueFactor = (int)(0.114478 * 1024);
            int SunGrayScale = (sun.R * RedFactor + sun.G * GreenFactor + sun.B * BlueFactor) >> 10;
            double trate = (double)SunGrayScale / 256;

            double y = compressRate * (compressRate + (1 - compressRate) * trate);
            double r = ((double)bg.R * y);
            double g = ((double)bg.G * y);
            double b = ((double)bg.B * y);

            int R = (int)r; if (R > 255) R = 255; if (R < 0) R = 0;
            int G = (int)g; if (G > 255) G = 255; if (G < 0) G = 0;
            int B = (int)b; if (B > 255) B = 255; if (B < 0) B = 0;

            return Color.FromArgb(R, G, B);
        }

        //Main Mix logic 
        public bool mixThem(string baseImage, string sunShapeImage, string outputImage, double maxBaseRate)
        {
            if (File.Exists(outputImage))
            {
                Console.WriteLine("Error: Output File already exists: " + outputImage);
                return false;
            }

            if (!File.Exists(baseImage))
            {
                Console.WriteLine("Error: Base Image File does not Exists: " + baseImage);
                return false;
            }

            if (!File.Exists(sunShapeImage))
            {
                Console.WriteLine("Error: Sun Shape File does not Exists: " + sunShapeImage);
                return false;
            }

            using (Bitmap bitmapSun = new Bitmap(sunShapeImage))
            using (Bitmap bitmapOut = new Bitmap(baseImage))
            {

                if (bitmapOut.Width != bitmapSun.Width || bitmapOut.Height != bitmapSun.Height)
                {
                    Console.WriteLine("Error: Pixel Width/Height are not matched ");
                    bitmapOut.Dispose();
                    bitmapSun.Dispose();
                    return false;
                }

                //Lock entire image data :Outfile
                Rectangle rectOut = new Rectangle(0, 0, bitmapOut.Width, bitmapOut.Height);
                BitmapData bitmapOutData = bitmapOut.LockBits(rectOut, ImageLockMode.ReadWrite, bitmapOut.PixelFormat);
                IntPtr ptrOut = bitmapOutData.Scan0;//Pointer for pixel data
                int bytesPerPixelOut = Image.GetPixelFormatSize(bitmapOut.PixelFormat) / 8;

                // Copy pixel data to byte array
                int bytesOut = Math.Abs(bitmapOutData.Stride) * bitmapOut.Height;
                byte[] rgbValuesOut = new byte[bytesOut];
                System.Runtime.InteropServices.Marshal.Copy(ptrOut, rgbValuesOut, 0, bytesOut);

                //Lock entire image data :Base file
                Rectangle rectSun = new Rectangle(0, 0, bitmapSun.Width, bitmapSun.Height);
                BitmapData bitmapSunData = bitmapSun.LockBits(rectSun, ImageLockMode.ReadWrite, bitmapSun.PixelFormat);
                IntPtr ptrSun = bitmapSunData.Scan0;//Pointer for pixel data
                int bytesPerPixelSun = Image.GetPixelFormatSize(bitmapSun.PixelFormat) / 8;

                // Copy pixel data to byte array
                int bytesSun = Math.Abs(bitmapSunData.Stride) * bitmapSun.Height;
                byte[] rgbValuesSun = new byte[bytesSun];
                System.Runtime.InteropServices.Marshal.Copy(ptrSun, rgbValuesSun, 0, bytesSun);

                //For Gray Scale
                const int RedFactor = (int)(0.298912 * 1024);
                const int GreenFactor = (int)(0.586611 * 1024);
                const int BlueFactor = (int)(0.114478 * 1024);

                int totalPixel = bitmapOut.Width * bitmapOut.Height;

                // each Pixel Operation
                for (int p = 0; p < totalPixel; p++)//Each Pixel
                {
                    int idxO = p * bytesPerPixelOut;
                    int idxS = p * bytesPerPixelSun;

                    //BGRA
                    int SunGrayScale = (
                        (int)rgbValuesSun[idxS + 2] * RedFactor
                        + (int)rgbValuesSun[idxS + 1] * GreenFactor
                        + (int)rgbValuesSun[idxS + 0] * BlueFactor)
                        >> 10;
                    double trate = (double)SunGrayScale / 256;

                    double y = (maxBaseRate + (1 - maxBaseRate) * trate);
                    double r = ((double)rgbValuesOut[idxO + 2] * y);
                    double g = ((double)rgbValuesOut[idxO + 1] * y);
                    double b = ((double)rgbValuesOut[idxO + 0] * y);

                    int R = (int)r; if (R > 255) R = 255; if (R < 0) R = 0;
                    int G = (int)g; if (G > 255) G = 255; if (G < 0) G = 0;
                    int B = (int)b; if (B > 255) B = 255; if (B < 0) B = 0;
                    rgbValuesOut[idxO + 2] = (byte)R;
                    rgbValuesOut[idxO + 1] = (byte)G;
                    rgbValuesOut[idxO + 0] = (byte)B;

                }

                System.Runtime.InteropServices.Marshal.Copy(rgbValuesOut,0,ptrOut,bytesOut);

                //Unlock bitmap
                bitmapOut.UnlockBits(bitmapOutData);
                bitmapSun.UnlockBits(bitmapSunData);

                //Save overwrite
                if (File.Exists(outputImage))
                {
                    File.Delete(outputImage);
                }

                bitmapOut.Save(outputImage);


                //Dispose
                bitmapOut.Dispose();
                bitmapSun.Dispose();

                Console.WriteLine("mix completed.");

            }
            return true;
        }
    }
}
