using System;


namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Task A: Input & Output */
            Console.WriteLine("Please Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("\n -Hello, " + name + "!\n");

            /* Task B: Numeric Types */
            Console.WriteLine("Enter Width of the Rectangle:");
            string width = Console.ReadLine();
            Console.WriteLine("Enter Length of the Rectangle:");
            string length = Console.ReadLine();
            int area = Int32.Parse(width) * Int32.Parse(length);
            Console.WriteLine(" -Area of the Rectangle is " + area);

            /* Task C: Numeric Types */
            Console.WriteLine("\nEnter The Number of Miles You Have Driven:");
            string milesDriven = Console.ReadLine();
            Console.WriteLine("Enter # of Gallons of Gas You've Consumed:");
            string gasConsumed = Console.ReadLine();
            double mpg = Convert.ToDouble(milesDriven) / Convert.ToDouble(gasConsumed);
            Console.WriteLine("  " + mpg + " MPG");
            
            /* Task D: Strings */
            string alicesSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("\nEnter Phrase to Search for:");
            string searchPhrase = Console.ReadLine();
            string lowercaseSentence = alicesSentence.ToLower();
            string lowercasePhrase = searchPhrase.ToLower();
            if(lowercaseSentence.Contains(lowercasePhrase))
            {
                Console.WriteLine(" -Found It!");
            }
            else
            {
                Console.WriteLine(" -That Phrase Doesn't Exist!");
            }
        
        }
    }
}
