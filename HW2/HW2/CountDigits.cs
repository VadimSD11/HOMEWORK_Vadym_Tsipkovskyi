using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class CountDigits
    {
        public static int SumOfDigitsInString(string str) {
            
            int sum = 0;

            foreach (char c in str)
            {
                if (char.IsDigit(c))//поиск цифр
                {
                    int digit; 
                    int.TryParse(c.ToString(), out digit);

                    sum += digit; 

                }
            }
            return sum;
        }
        public static int FindMaxDigit(string str)
        {
            int maxDigit = -1;

            foreach (char c in str)
            {
                if (char.IsDigit(c))//поиск цифр
                {
                    int digit; 
                    int.TryParse(c.ToString(), out digit);

                    if (digit > maxDigit) 
                    {
                        maxDigit = digit;
                    }
                }
            }
            return maxDigit;
        }
        public static int FindMaxDigitIndex(string str) { 
            
            int maxDigitIndex = -1;
            int currentIndex = 0;
            int maxDigit = -1;
            str = str.TrimStart(); // удаляем пробелы в начале строки

            foreach (char c in str)
            {
                if (char.IsDigit(c))//поиск цифр
                {
                 
                    int digit; // получаем найденную цифру
                    int.TryParse(c.ToString(), out digit);
                    if (digit > maxDigit) // находим максимальную цифру
                    {
                        maxDigit = digit;
                        
                    }
                }


            }
            foreach (char c in str)
            {
                if (char.IsDigit(c))//поиск цифр
                {

                    int digit; // получаем найденную цифру
                    int.TryParse(c.ToString(), out digit);
                    if (digit == maxDigit) // находим максимальную цифру
                    {
                        maxDigitIndex = currentIndex;
                        break;
                    }
                }
                currentIndex++;

                
            }
            return maxDigitIndex;
            
        
    }
        public static int FindMaxPage(int[] pages) {

            int maxPages = 0; // количествo страниц в самой толстой книге

            // находим максимальное значение в массиве
            for (int i = 0; i < pages.Length; i++)
            {
                if (pages[i] > maxPages)
                {
                    maxPages = pages[i];
                }
            }
            return maxPages;
        }
        public static int FindMaxPagev2(int[] pages) {
            return pages.Max();
        }

        public static void FindMaxCarSpeedIndex(int[] carsSpeed) {
            if (carsSpeed == null || carsSpeed.Length == 0)
            {
                Console.WriteLine("Array doesn't fit the description");
            }
            int maxSpeed = 0; // переменная для хранения максимальной скорости
            int count = 0;
            int index = -1;
            // находим максимальную скорость и ее индекс в массиве
            for (int i = 0; i < carsSpeed.Length; i++)
            {
                if (carsSpeed[i] > maxSpeed)
                {
                    maxSpeed = carsSpeed[i];
                    index= i;
                }
            }
            for (int i = 0; i < carsSpeed.Length; i++) { if (carsSpeed[i] == maxSpeed) { count++; } }
            if (count > 1)
            {
                int index2 = -1;
                int firstindex = -1;

                for (int i = 0; i < carsSpeed.Length; i++)
                {
                    if (carsSpeed[i] == maxSpeed)
                    {
                        firstindex = i;
                        Console.WriteLine("First car with maximum speed index is" + firstindex);
                        break;
                    }

                }
                // первая с конца машина по скорости
                for (int i = carsSpeed.Length - 1; i >= 0; i--)
                {
                    if (carsSpeed[i] == maxSpeed)
                    {
                        index2 = i;
                        Console.WriteLine("Last car with maximum speed index is " + index2);
                        break;
                    }
                }


            }
            else { Console.WriteLine("Index of car with maximum speed is "+index); }

        }
    }
}
