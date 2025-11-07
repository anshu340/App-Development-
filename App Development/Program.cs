using System;

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

            // Create a DateTime variable for birthdate
            DateTime birthdate = new DateTime(2004, 11, 13); 

            // Create a DateTime variable for current date and time
            DateTime currentDate = DateTime.Now;

            // Calculate age using TimeSpan
            TimeSpan ageTimeSpan = currentDate - birthdate;
            int ageInYears = (int)(ageTimeSpan.TotalDays / 365.25); // Using 365.25 to account for leap years

            // Print birthdate, current date, and age
            Console.WriteLine("\n=== Date and Time Information ===");
            Console.WriteLine($"Your Birthdate: {birthdate.ToShortDateString()}");
            Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Current Date and Time: {currentDate}");
            Console.WriteLine($"Your Age: {ageInYears} years");

            // Add 10 days to birthdate
            DateTime birthdatePlus10Days = birthdate.AddDays(10);
            Console.WriteLine($"\nBirthdate + 10 days: {birthdatePlus10Days.ToShortDateString()}");

            // Additional information about the TimeSpan
            Console.WriteLine($"\nTotal days lived: {(int)ageTimeSpan.TotalDays} days");


            List<string> fruits = new List<string> { "Apple", "Mango", "WaterMelon" };
            Console.WriteLine("\n=== List<string> ===");
            Console.WriteLine("Initial fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }

            // Add a new fruit to the list
            fruits.Add("Orange");
            Console.WriteLine("\nAfter adding 'Orange':");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }

            // Remove one fruit from the list
            fruits.Remove("WaterMelon"); 
            Console.WriteLine("\nAfter removing 'WaterMelon':");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }

            // Create a Dictionary<int, string> with fruit IDs and names
            Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
            {
                { 1, "Apple" },
                { 2, "Mango" },
                { 3, "WaterMelon" }
            };

            Console.WriteLine("\n=== Dictionary<int, string> ===");
            Console.WriteLine("Initial dictionary:");
            foreach (KeyValuePair<int, string> entry in fruitDictionary)
            {
                Console.WriteLine($"ID {entry.Key}: {entry.Value}");
            }

            // Add a new entry to the dictionary
            fruitDictionary.Add(4, "Orange");
            Console.WriteLine("\nAfter adding ID 4: Orange:");
            foreach (KeyValuePair<int, string> entry in fruitDictionary)
            {
                Console.WriteLine($"ID {entry.Key}: {entry.Value}");
            }

            // Display total count
            Console.WriteLine($"\nTotal fruits in list: {fruits.Count}");
            Console.WriteLine($"Total entries in dictionary: {fruitDictionary.Count}");

        }
    }
}
