using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Creational.PrototypePattern
{
    public class Rectangle : Shape
    {
        public int Width { get; set; } = 10;
        public int Height { get; set; } = 5;

        public void Draw()
        {
            Console.WriteLine($"Drawing a Rectangle with Width: {Width} and Height: {Height}");
        }

        public Shape Duplicate()
        {
            var newRectangle = new Rectangle();
            newRectangle.Width = Width; // copy the width
            newRectangle.Height = Height; // copy the height
            return newRectangle;
        }
    }
}