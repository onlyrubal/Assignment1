using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            bool checkStatus = true;
            int userInput;
            do
            {
                Console.WriteLine("\n### Select option from the Menu ###");
                Console.WriteLine("1. Get the Rectangle Length");
                Console.WriteLine("2. Change the Rectangle Length");
                Console.WriteLine("3. Get the Rectangle Width");
                Console.WriteLine("4. Change the Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");

                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Enter the input in Int value format");
                    continue;
                }

                switch (userInput)
                {
                    case 1:
                        var length = rectangle.GetLength();
                        Console.WriteLine("Length of the rectangle is : " + rectangle.GetLength() + "\n");
                        break;

                    case 2:
                        Console.WriteLine("### Enter the new Rectangle Length ###");
                        try
                        {
                            length = Convert.ToInt32(Console.ReadLine());
                            if (length >= 1)
                            {
                                rectangle.SetLength(length);
                                Console.WriteLine("###Length Value Set###\n");

                            }
                            else
                            {
                                Console.WriteLine("\nSet the length value greater than or equal to 1.");
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\nEnter the length value in int format only.");
                        }
                        break;

                    case 3:
                        var width = rectangle.GetWidth();
                        Console.WriteLine("Width of the rectangle is : " + rectangle.GetWidth() + "\n");
                        break;

                    case 4:
                        Console.WriteLine("### Enter the new Rectangle Width ###");

                        try
                        {
                            width = Convert.ToInt32(Console.ReadLine());
                            if (width >= 1)
                            {
                                rectangle.SetWidth(width);
                                Console.WriteLine("### Width Value Set ###\n");
                            }
                            else
                            {
                                Console.WriteLine("Set the width value greater than or equal to 1.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Enter the width value in Int format only");
                        }

                        break;

                    case 5:
                        Console.WriteLine("### Perimeter of the Rectangle is : " + rectangle.GetPerimeter() + " ###\n");
                        break;

                    case 6:
                        Console.WriteLine("### Area of the Rectangle is : " + rectangle.GetArea() + " ###\n");
                        break;
                    case 7:
                        Console.WriteLine("### Exiting ###");
                        checkStatus = false;
                        break;
                    default:
                        Console.WriteLine("Enter the number from the mentioned options above.");
                        break;
                }

            }
            while (checkStatus);
        }
    }
}
