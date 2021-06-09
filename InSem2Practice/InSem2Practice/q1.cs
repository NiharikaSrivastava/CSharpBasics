/*
//Q1. A Photo Studio provides many photo services, like, converting a set of photos to gray scale album. The
//following code implements a class PhotoStudio which takes the order (through function PlaceOrder)
//where it takes set of photos. And, then it can convert the photo set into gray scale. See the following implementation
//There are several problems with the implementation. For example, both gray scale conversion
//functions do pretty much the same thing, other than working on different type of image format,
//violating the DRY principle. Also, whole PhotoStudio class gets affected if new type of photo(like bmp) is introduced.

//Use guidance on SOLID principles and OOP concepts to come up with modified code that is a much
//better design, while achieving the same purpose – to convert a set of photos into gray scale set. In your
//answer re-write complete code. Goals of your solutions should be:
//1.DRY principle is not violated i.e.there is only one function to process the album into gray scale for any photo type
//2. If 3rd type of photo is introduced in the system, nothing in class PhotoStudio changes other than
//addition of switch case for the new type of photo in PlaceOrder function. (Don’t introduce a 3rd
//type, only imagine and test where all your code changes)

using System;
using System.Collections.Generic;
using System.Text;
namespace InSem2Practice
{
    class q1
    {
        static void Main(string[] args)
        {
            List<Jpeg> jpegPictures = new List<Jpeg>()
            {
                new Jpeg{filename="Picture1"},
                new Jpeg{filename="Picture2"},
                new Jpeg{filename="Picture3"}
            };
            List<Png> pngPictures = new List<Png>()
            {
                new Png{filename="Picture4"},
                new Png{filename="Picture5"},
                new Png{filename="Picture6"}
            };
            PhotoStudio ps = new PhotoStudio();
            foreach (var pic in jpegPictures)
                ps.PlaceOrder(pic,PhotoType.Jpeg);
            foreach (var pic in pngPictures)
                ps.PlaceOrder(pic, PhotoType.Png);
            List<Image> grayScaleJpegPictures = ps.GetGrayScaleAlbumForJpeg();
            List<Image> grayScalePngPictures = ps.GetGrayScaleAlbumForPng();
            
        }
    }
    public enum PhotoType { Jpeg, Png };
    class Image {
        public string filename { get; set; }
        public bool isGrayScale;
        internal Image(){
            isGrayScale = false;
        }
          
    } //represents all images
    class Jpeg:Image {
        string extension;
        internal Jpeg(){
            extension = ".jpeg";
        }
    } // represents a JPEG file
    class Png:Image{
        public string extension;
        internal Png(){
            extension = ".png";
        }
    } // represents a PNG file

    class ImageFilter //converting all types of images to grayscale 
    {
        public Image covertToGrayScale(Image img, PhotoType imgType) //single function converting all image types to grayscale
        {
            switch (imgType)
            {
                case PhotoType.Jpeg:
                    //coverting jpeg image to grayscale
                    Console.WriteLine("Converted jpeg image: {0} to grayscale!",img.filename);
                    img.isGrayScale = true;
                    break;
                case PhotoType.Png:
                    //coverting png image to grayscale
                    Console.WriteLine("Converted png image: {0} to grayscale!",img.filename);
                    img.isGrayScale = true;
                    break;
                default:
                    Console.WriteLine("Invalid Image type");
                    break;
            }
            return img;
        }
    }
    class JpegFilter:ImageFilter
    {
        public Image getGrayScaleJpeg(Image jpeg)
        {
            covertToGrayScale(jpeg,PhotoType.Jpeg);
            return jpeg; 
        }
    }
    class PngFilter:ImageFilter
    {
        public Image getGrayScalePng(Image png) 
        {
            covertToGrayScale(png,PhotoType.Png);
            return png;
        }
    }
    class PhotoStudio
    {
        private JpegFilter jpegFilter;
        private PngFilter pngFilter;
        internal List<Image> jpegs;
        internal List<Image> pngs;
        internal PhotoStudio()
        {
            jpegFilter = new JpegFilter();
            pngFilter = new PngFilter();
            jpegs = new List<Image>();
            pngs = new List<Image>();
        }
        public void PlaceOrder(Image photoOrder, PhotoType image)
        {
            switch (image)
            {
                case PhotoType.Jpeg:
                    Console.WriteLine("Order placed for jpeg image: "+photoOrder.filename);
                    jpegs.Add(photoOrder);          
                    break;
                case PhotoType.Png:
                    Console.WriteLine("Order placed for png image: " + photoOrder.filename);
                    pngs.Add(photoOrder);
                    break;
            }
        }
        public List<Image> GetGrayScaleAlbumForJpeg()
        {
            List<Image> album = new List<Image>();
            foreach (var photo in jpegs)
                album.Add(jpegFilter.getGrayScaleJpeg(photo));
            return album;
        }
        public List<Image> GetGrayScaleAlbumForPng()
        {
            List<Image> album = new List<Image>();
            foreach (var photo in pngs)
                album.Add(pngFilter.getGrayScalePng(photo));
            return album;
        }
    }
}
*/
