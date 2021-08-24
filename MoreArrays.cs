using System;

namespace myApp
{
    class MoreArrays
    {
        static void Arrays(string[] args)
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("");

            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            int counter = 0;
            for (int i = 0; i < pallets.Length; i++)
            {
                if (pallets[i] != null)
                    counter++;
            }
            string[] newPallets = new string[counter];

            int x = 0;
            foreach (var pallet in pallets)
            {
                if (pallet != null)
                {
                    newPallets[x] = pallet;
                    x++;
                }
            }

            Array.Sort(newPallets);

            Console.WriteLine("New Pallet");
            foreach (var pallet in newPallets)
                Console.WriteLine($"-- {pallet}");


            Console.WriteLine("");
            Array.Resize(ref pallets, 3);
            Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }



            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            // string result = new string(valueArray);
            string result = String.Join(",", valueArray);
            Console.WriteLine(result);

            string[] items = result.Split(',');
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            //my solution
            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] pangramArray = pangram.Split(' ');
            string[] finalArr = new string[pangramArray.Length];

            for (int i = 0; i < pangramArray.Length; i++)
            {
                char[] tempArr = pangramArray[i].ToCharArray();
                Array.Reverse(tempArr);
                string tempResult = new string(tempArr);
                finalArr[i] = tempResult;
            }

            string result = String.Join(" ", finalArr);

            Console.WriteLine(result);

            //MS answer
            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] message = pangram.Split(' ');
            string[] newMessage = new string[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            string result = String.Join(" ", newMessage);
            Console.WriteLine(result);

            //Challenge 2
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            // Your code here
            string[] osArr = orderStream.Split(',');

            for (int i = 0; i < osArr.Length; i++)
            {
                if (osArr[i].ToString().Contains("B"))
                {
                    Console.WriteLine(osArr[i]);
                }
            }

            //MS answer
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] items = orderStream.Split(',');

            foreach (var item in items)
            {
                if (item.StartsWith("B"))
                {
                    Console.WriteLine(item);
                }
            }




        }


    }
}
