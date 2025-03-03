using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study18
{
    struct Rectangle
    {
        public int Width;
        public int Height;

        public int GetArea() => Width * Height;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect;
                rect.Width = 10;
            rect.Height = 20;
            //var rect = new Rectangle { Width = 5, Height = 4 };


            Console.WriteLine($"Area : {rect.GetArea()}");
        }
    }
}
