using System;

namespace myApp
{
    class Program1
    {
        static void Arrays(string[] args)
        {
            // string[] fraudulentOrderIDs = new string[3];

            // fraudulentOrderIDs[0] = "A123";
            // fraudulentOrderIDs[1] = "B456";
            // fraudulentOrderIDs[2] = "C789";

            string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            // foreach
            string[] names = { "Bob", "Mike", "Karmen", "Chloe" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //another foreach

            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;

            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }

            Console.WriteLine($"We have {sum} items in inventory.");


            // conditional Complicated Permission Challenge

            // string permission = "Admin|Manager";
            // string permission = "Admin";
            // string permission = "Manager";
            string permission1 = "Intern";
            int level1 = 19;

            if (permission1.Contains("Manager") && level1 >= 20)
            {
                Console.WriteLine("Contact an Admin for access.");
            }
            else if (permission1.Contains("Admin") && level1 <= 55)
            {
                Console.WriteLine("Welcome, Admin user.");
            }
            else if (permission1.Contains("Admin") && level1 > 55)
            {
                Console.WriteLine("Welcome, Super Admin user.");
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }

            //answer
            string permission = "Admin|Manager";
            int level = 53;

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }

        }
    }
}
