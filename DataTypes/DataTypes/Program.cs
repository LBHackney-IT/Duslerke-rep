using System;
using DataTypes;

namespace DataTypes
{

    struct PersonWithDebt //Let's assume there are loads of people who owe me money
    {
        public int personID; //need to have a way to track them down
        public float debt; // I don't really lend sums larger than 65k pounds.

        public PersonWithDebt(int apersonID, float adebt) //constructor, so I wouldn't have to bother writing separate lines to initialise
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
            int numbOfDebtors = 3;
            PersonWithDebt[] debtorsList = new PersonWithDebt[numbOfDebtors];

            for (int i=0; i<numbOfDebtors; i++)
            {
                GenerateDebtors();
            }


            Console.WriteLine("[{0}]", string.Join(", ", debtorsList));
            Console.ReadKey();
        }

        static PersonWithDebt GenerateDebtors()
        {
            Random random = new Random();
            int randomID = random.Next(2200000, 2990000);
            float randomDebt = random.Next(10000, 800000) / 100f;

            return new PersonWithDebt(randomID, randomDebt);
        }

    }
}
