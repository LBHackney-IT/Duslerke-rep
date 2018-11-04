using System;

namespace DataTypes
{

    struct PersonWithDebt //Let's assume there are loads of people who owe me money
    {
        public int personID; //need to have a way to track them down
        public Int16 debt; // I don't really lend sums larger than 65k pounds.

        public PersonWithDebt(int apersonID, int adebt) //constructor, so I wouldn't have to bother writing separate lines to initialise
        {
            this.personID = apersonID;
            this.debt = adebt;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            


            Console.ReadKey();
        }
    }
}
