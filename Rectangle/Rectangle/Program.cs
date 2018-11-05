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
        private double awidth;
        private double aheight;
        private bool errFlag = false;

        public void AcceptDetails() 
        {

            Console.Write("Enter rectangle width: ");
            while (true)
            {
                this.errFlag = false;
                try
                {
                    awidth = Convert.ToDouble(Console.ReadLine());
                } catch(FormatException e)
                {
                    Console.Write(e.Message);
                    Console.Write(" Try again: ");
                    this.errFlag = true;
                }

                if (awidth >= 0)
                {
                    this.width = awidth;
                    break;
                }
                else if (awidth < 0 && !this.errFlag)
                {
                    Console.Write("Width can't be negative! Try again: ");
                }
            }

            Console.Write("Enter rectangle height: ");
            while (true)
            {
                this.errFlag = false;
                try
                {
                    aheight = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.Write(e.Message);
                    Console.Write(" Try again: ");
                    this.errFlag = true;
                }

                if (aheight >= 0)
                {
                    this.height = aheight;
                    break;
                } else if (aheight < 0 && !this.errFlag)
                {
                    Console.Write("Heigth can't be negative! Try again: ");
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

