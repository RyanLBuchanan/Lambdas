namespace Lambdas
{
    internal class Program
    {
        // Delegate for a function that receives an int and returns a bool
        public delegate bool NumberPredicate(int number);
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Create an instance of the NumberPredicate delegate type
            NumberPredicate evenPredicate = number => number % 2 == 0;

            // Call IsEven using a delegate variable
            Console.WriteLine($"Use a lambda expression variable: {evenPredicate(4)}");

            // Filter the even numbers using method IsEven
            List<int> evenNumbers = FilterArray(numbers, evenPredicate);

            // Display
            DisplayList("Use a lambda expression to filter even numbers: ", evenNumbers);

            // Filter odd numbers using metho IsOdd
            List<int> oddNumbers = FilterArray(numbers, (int number) => number % 2 == 1);

            // Display
            DisplayList("Use a lambda expression to filter odd numbers: ", oddNumbers);

            // Filter numbers greater than 5 using method IsOver5
            List<int> numbersOver5 = FilterArray(numbers, number => {return number > 5;});

            // Display 
            DisplayList("Use a lambda expression to filter numbers over 5: ", numbersOver5);
        }

        private static List<int> FilterArray(int[] intArray, NumberPredicate predicate)
        {
            // Hold the selected elements
            var result = new List<int>();

            // Iterate over each element in the array
            foreach (var item in intArray)
            {
                // If element satisfies the predicate
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        // Display
        private static void DisplayList(string description, List<int> list)
        {
            Console.Write(description);

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}