namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
             
                Console.WriteLine("Task 1");
                Console.Write("Enter your string:");
                string str = Console.ReadLine();

                Console.WriteLine("Sum of all digits in this string: "+ CountDigits.SumOfDigitsInString(str));
                Console.WriteLine("Max Digit in this string: " + CountDigits.FindMaxDigit(str));
                Console.WriteLine();
                Console.WriteLine("Task 2");
                Console.Write("Enter your string(it must start with space):");
                string str2 = Console.ReadLine();
                if (!str2.StartsWith(' ')) { Console.WriteLine("This string doesn't fit the description"); }
                else { Console.WriteLine("Index of maximum digit: "+CountDigits.FindMaxDigitIndex(str2)); }
                Console.WriteLine();
                Console.WriteLine("Task 3 ");
                int[] pages = new int[100];
                Random random = new Random();

                for (int i = 0; i < pages.Length; i++)
                {
                    pages[i] = random.Next(1, 101);
                }
               
                Console.WriteLine("Maximum in Pages array = " + CountDigits.FindMaxPage(pages));
                Console.WriteLine("v2 = " + CountDigits.FindMaxPagev2(pages));
                Console.WriteLine();
                Console.WriteLine("Task 4 ");
                int[] cars = new int[40];
                Random random2 = new Random();

                for (int i = 0; i < cars.Length; i++)
                {
                    cars[i] = random2.Next(1, 101);
                }
                CountDigits.FindMaxCarSpeedIndex(cars);
                //для теста
                //int[] mycars = { 2, 5, 1, 3, 5, 2, 1, 5 };
                //Console.WriteLine();
                //Console.WriteLine();
                //CountDigits.FindMaxCarSpeedIndex(mycars);


            }
            catch (Exception ex) { Console.WriteLine("An error occured: "+ex.Message); }
        }
    }
}