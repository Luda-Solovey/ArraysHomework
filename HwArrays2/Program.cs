namespace HwArrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = [89, 56, 12, 36];


            //1 Min value
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"Min value is: {min}");

            //2 Max value
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine($"Max value is: {max}");

            // 3 Min index
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            Console.WriteLine($"Index of minValue: {minIndex}");

            //4 Sums of all elements

            int summ = 0;

            for (int i = 0; i < array.Length; i++)
            {
                summ = summ + array[i];
            }

            Console.WriteLine($"Sum of all elements is {summ}");

            // 5 середнє арифметичне всіх чисел

            int summOfAllElements = 0;
            int countOfAllElements = array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                summOfAllElements = summOfAllElements + array[i];
            }

            decimal arithm = (decimal)summOfAllElements / countOfAllElements;
            Console.WriteLine($"The arithmetic mean of all the numbers is: {arithm}");

            //odd elements (непарні значнення)
            List<int> oddList = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    oddList.Add(array[i]);
            }

            int[] oddArray = oddList.ToArray();

            for (int i = 0; i < oddArray.Length; i++)
            {
                   Console.WriteLine($"Odd values are: {oddArray[i]}");
            }
        }
    }
}
