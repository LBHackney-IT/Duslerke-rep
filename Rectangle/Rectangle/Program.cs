using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args) //there's a better way of doing this entire task, but it conflicts with specs given.
        {
            Console.WriteLine("Hello World!");
            RectangleApplication temporary = new RectangleApplication();
            temporary.AcceptDetails();

        }
    }

    class RectangleApplication  //The way the task requires it. Judged by the task list, I'm not supposed to create a constructor method.
    {
        private double width;
        private double height;
        private double area;

        public void AcceptDetails() 
        {
            Console.Write("Enter rectangle width: ");
            while (true)
            {
                double awidth = Convert.ToDouble(Console.ReadLine());
                if (awidth >= 0)
                {
                    this.width = awidth;
                    break;
                }
                else
                {
                    Console.WriteLine("Width can't be negative! Try again: ");
                }
            }

            Console.Write("Enter rectangle height: ");
            while (true)
            {
                double aheight = Convert.ToDouble(Console.ReadLine());
                if(aheight >= 0)
                {
                    this.height = aheight;
                } else
                {
                    Console.WriteLine("Heigth can't be negative! Try again: ");
                }
            }
        }

        public void getArea()
        {

        }

        public void Display()
        {

        }
    }
}

