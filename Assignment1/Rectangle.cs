using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Rectangle
    {
        private int length;
        private int width;

        // Initializing Setters and Getters.
        public int GetLength()
        {
            return this.length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }


        // Default Constructor
        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }

        // Parameterized constructor
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        // Method to get the Perimeter of the Rectangle
        public int GetPerimeter()
        {
            return (2 * (this.length + this.width));
        }

        // Method to get the Area of the Rectangle.
        public int GetArea()
        {
            return (this.length * this.width);
        }



    }
}
