using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenWordsLibrary
{
    class BMPHandle
    {
        // because i have a GIANT HARDON for MVC, we're using a class to encapsulate the bitmap class, and hopefully encoding shit. 
        // IDK what functions will go here instead of Functions.cs but HEYYYY hopefully this dices out right. 
        // if not ill just refractor till it is pretty. 
        // -- VAL


        // -- Fields -- //
        private Bitmap InternalImage;
        private string ThroughText = string.Empty;
        // -- end Fields -- //


        // -- Constructors -- //
        public BMPHandle()
        {
            InternalImage = null;
        }
        public BMPHandle(String Image)
        {
            //string because this tankes a FILENAME
            InternalImage = new Bitmap(Image);
        }
        public BMPHandle(Bitmap Image)
        {
            InternalImage = new Bitmap(Image);
        }
        public BMPHandle(String Image, String Text)
        {
            InternalImage = new Bitmap(Image);
            ThroughText = Text;
        }
        public BMPHandle(Bitmap Image, String Text)
        {
            InternalImage = new Bitmap(Image);
            ThroughText = Text;
        }
        // -- End Constructors -- //

        // -- Functions -- //
        public void BigFatEncoding()
        {

            // Lock the bits
            byte[] RGBValues = LockAndSerializeBits();
            byte[] ASCIIValu = StringToChomp();
            // Begin Encoding Hell???????

        }

        public byte[] StringToChomp()
        {
            return Encoding.ASCII.GetBytes(ThroughText); // populates an array  with the byte values, immediately throws elsewhere. 
            // i didnt need this as its own function but w/e
        }

        public byte[] LockAndSerializeBits()
        {
            // made with help of MSDN!
            Rectangle rect = new Rectangle(0, 0, InternalImage.Width, InternalImage.Height);
            System.Drawing.Imaging.BitmapData bmpData = InternalImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, InternalImage.PixelFormat);

            // get address of line 1
            IntPtr ptr = bmpData.Scan0;

            // byte array to hold bytes
            int bytes = Math.Abs(bmpData.Stride) * InternalImage.Height; // calculate size needed
            byte[] RGBValues = new byte[bytes]; // an array that can hold RGB values.

            // populate array so it now holds the RGB values for the entire bitmap
            System.Runtime.InteropServices.Marshal.Copy(ptr, RGBValues, 0, bytes);

            // return said array of RGB
            return RGBValues;
        }

        // -- End Functions -- //
    }
}
