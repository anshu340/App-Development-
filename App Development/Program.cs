namespace App_Development
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userName = "Anshu Karki";
            int luckyNumber = 28;
            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");


            Console.WriteLine($"PI value: {Circle.PI}");

            byte byteVar = 255;
            short shortVar = -32000;
            int intVar = 42;
            long longVar = 1234567L;
            float floatVar = 3.14f;
            double doubleVar = 3.141599;
            decimal decimalVar = 99.99m;
            char charVar = 'A';
            bool boolVar = true;
            string intToString = intVar.ToString();
            string numberString = "3.14";
            double stringToDouble = double.Parse(numberString);

            Console.WriteLine("=== Original Variables ===");
            Console.WriteLine($"byte: {byteVar} ");
            Console.WriteLine($"short: {shortVar} ");
            Console.WriteLine($"int: {intVar} ");
            Console.WriteLine($"long: {longVar} ");
            Console.WriteLine($"float: {floatVar} ");
            Console.WriteLine($"double: {doubleVar} ");
            Console.WriteLine($"decimal: {decimalVar} ");
            Console.WriteLine($"char: {charVar} ");
            Console.WriteLine($"bool: {boolVar} ");

            Console.WriteLine("\n=== Type Conversions ===");
            Console.WriteLine($"Integer 42 converted to string: \"{intToString}\"");
            Console.WriteLine($"String \"3.14\" converted to double: {stringToDouble}");

            int[] favoriteNumbers = { 42, 7, 13, 99, 21 };

            Console.WriteLine("\nOriginal Array:");
            for (int i = 0; i < favoriteNumbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {favoriteNumbers[i]}");
            }

            Array.Sort(favoriteNumbers);

            Console.WriteLine("\nSorted Array (Ascending):");
            for (int i = 0; i < favoriteNumbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {favoriteNumbers[i]}");
            }

            Array.Reverse(favoriteNumbers);

            Console.WriteLine("\nReversed Array:");
            for (int i = 0; i < favoriteNumbers.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {favoriteNumbers[i]}");
            }

            int searchNumber = 42;
            int position = Array.IndexOf(favoriteNumbers, searchNumber);

            Console.WriteLine($"\nSearching for number {searchNumber}:");
            if (position >= 0)
            {
                Console.WriteLine($"Found at index: {position}");
            }
            else
            {
                Console.WriteLine("Number not found in the array");
            }


        }
    }
}
