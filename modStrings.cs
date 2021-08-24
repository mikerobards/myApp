using System;

namespace myApp
{
    class ModStrings
    {
        static void Arrays(string[] args)
        {
            //my answer
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here

            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int openingPosition = input.IndexOf(openSpan);
            int closingPosition = input.IndexOf(closeSpan);

            openingPosition += openSpan.Length;
            int length = closingPosition - openingPosition;

            quantity += String.Format($"Quantity: {input.Substring(openingPosition, length)}");

            output = input.Remove(0, 5);
            output = output.Replace("</div>", "");
            output = output.Replace("&trade", "&reg");
            output = $"Output: {output}";

            Console.WriteLine(quantity);
            Console.WriteLine(output);

            //MS answer
            string input = "<div class='product'><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here

            const string spanTag = "<span>";

            // Extract the quantity
            int quantityStart = input.IndexOf(spanTag);
            int quantityEnd = input.IndexOf("</span>");
            quantityStart += spanTag.Length;
            int quantityLength = quantityEnd - quantityStart;
            quantity = input.Substring(quantityStart, quantityLength);

            // Set output to input, replacing the trademark symbol with the registered trademark symbol
            output = input.Replace("&trade;", "&reg;");

            // Remove the opening <div> tag
            int divStart = input.IndexOf("<div");
            int divEnd = input.IndexOf(">");
            int divLength = divEnd - divStart;
            divLength += 1;
            output = output.Remove(divStart, divLength);

            // Remove the closing <div> tag
            int divCloseStart = output.IndexOf("</div");
            int divCloseEnd = output.IndexOf(">", divCloseStart);
            int divCloseLength = divCloseEnd - divCloseStart;
            divCloseLength += 1;
            output = output.Remove(divCloseStart, divCloseLength);

            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Output: {output}");

        }


    }
}
