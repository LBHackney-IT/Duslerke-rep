using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args) //there's a better way of doing this entire task, but it conflicts with specs given.
        {
            RectangleApplication temporary = new RectangleApplication();
            temporary.AcceptDetails();
            temporary.getArea();
            temporary.Display();
            Console.ReadKey();
        }
    }

    class RectangleApplication  //The way the task requires it. Judged by the task list, I'm not supposed to create a constructor method.
    {
        private double width;
        private double height;
        private double area;
        private double awidth;
        private double aheight;

        public void AcceptDetails() 
        {

            Console.Write("Enter rectangle width: ");
            while (true)
            {
                try
                {
                    awidth = Convert.ToDouble(Console.ReadLine());

                    if (awidth >= 0)
                    {
                        this.width = awidth;
                        break;
                    }
                    else if (awidth < 0)
                    {
                        Console.Write("Width can't be negative! Try again: ");
                    }


                } catch(FormatException e)
                {
                    Console.Write(e.Message);
                    Console.Write(" Try again: ");
                }


            }

            Console.Write("Enter rectangle height: ");
            while (true)
            {
                try
                {
                    aheight = Convert.ToDouble(Console.ReadLine());

                    if (aheight >= 0)
                    {
                        this.height = aheight;
                        break;
                    }
                    else if (aheight < 0)
                    {
                        Console.Write("Heigth can't be negative! Try again: ");
                    }

                }
                catch (FormatException e)
                {
                    Console.Write(e.Message);
                    Console.Write(" Try again: ");
                }


            }
        }

        public void getArea()
        {
            this.area = this.awidth * this.aheight;
        }

        public void Display()
        {
            Console.WriteLine("Rectangle area is: {0}", this.area);
        }
    }
}

