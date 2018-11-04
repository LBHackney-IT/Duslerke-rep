using System;
using DataTypes;

namespace DataTypes
{

    struct PersonWithDebt //Let's assume there are loads of people who owe me money. I want my data organised so, I create a new type of variable.
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
            int numbOfDebtors = 10;
            PersonWithDebt[] debtorsList = new PersonWithDebt[numbOfDebtors]; //want initialise empty array of the PersonWithDebt variable type.

            for (int i = 0; i < numbOfDebtors; i++) //fill in my array with Debtors.
            {
                debtorsList[i] = GenerateDebtors(); //put the debtor into debtor array
            }

            //So let's assume my 7th debtor repayed 100 pounds and 60 pence, and I want to update it.
            Console.WriteLine("ID: {0} ; Debt: {1}", debtorsList[7].personID, debtorsList[7].debt); //Want to see his debt prior to payment on screen
            ChangeDebt(debtorsList[7], 100.60f); //I update his debt
            Console.WriteLine("ID: {0} ; Debt: {1}", debtorsList[7].personID, debtorsList[7].debt); //Should show his updated debt..Oh no! What happened?! More info on ChangeDebt() method comments.
            //Why not use class and create Objects? Well I read that there is somekind of performance difference because you 1) you don't have to allocate memory on heap. 2) you already have your entire unit of data on stack, which is faster..but not really sure is the performance worth it. To be honest.. I would want to get the answer from you on this question. 


            Console.ReadKey(); //Just pause the program, so I could read text 
        }

        static PersonWithDebt GenerateDebtors() //Thought that it might be a good idea to have a method randomise my Debtor.
        {
            Random random = new Random();
            int randomID = random.Next(2200000, 2990000);
            float randomDebt = random.Next(10000, 800000) / 100f;

            return new PersonWithDebt(randomID, randomDebt);
        }

        static void ChangeDebt(PersonWithDebt person, float payment) //this won't work because structs are value types. Meaning rather than inputing a specific PersonWithDebt, I input it's copy because pass by copy applies.
        {
            person.debt -= payment; //So I'm changing the debt attribute of the copy of the actual debtor, not the debtor itself. On the other hand, if instead of struct I wrote class. I would have had a class after which I would have made objects. And in my debtorsList array, I would have had references (addresses) to a location in heap memory, where those objects reside...instead of having actual objects sitting on the stack memory.
        } //So continuing on that hypothetical scenario, I would have passed a reference of Debtor object into a ChangeDebt methods "person" parameter. So following that there would be a "person" variable created on the stack, that would point to the Debtor object. This way this method would access a real debtor rather than it's copy.

        //Well the debt can be updated, but it would have to be a more direct way: debtList[7].debt -= payment;
        // So If I understand this correctly, you use struts mostly for the data that doesn't change. Like having students in database, where attributes are: name, age, gender, degree ... or something among those lines.


        // Of course I went all fancy with structs on this task, but to cover the rest:

        //Value types: So that's mostly primitives like int,float,boolean and etc. that get stored on Stack memory, which is smaller than heap, but quicker access. New data types created by struct also go here. These values can only be changed by reasigning them. Also when they are being worked with, in actuality, it's their value copies that are being worked on.
        //Reference types: These variables hold only the reference to an actual Object or String that is sitting somewhere on the heap memory. Since the reference is something like 4bytes, it doesn't eat up much memory on stack. When you pass this variable, you're only passing the address of memory cell, where and actual Object or String is defined. 
        //Pointer types. From what I've read pointers and references are almost the same thing in C#. So I'm not really sure, what answer you're expecting. But I did read that when you create an Object instance, apart from it's attributes and methods, you get a: 1) Sync Block Index pointer - (no idea what this is, yet) 2) Type Object pointer, which allows us to know about the type of actual object.
        //well, if you create a link list or something, there would be a struct with a value and pointer attribute. The pointer would give location of next element in the list. You could also have pointer that's reading this linked list - the pointer would always point to currently selected cell. If that's not the answer, then I don't know what is.
    }
}
