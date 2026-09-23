namespace _5SubArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //не зроблений приклад
            int[] array = [1, 2, 3, 4, 5, 6, 7];

            static int[] SubArray(int[] array, int index, int count)
            {
                int[] subArray = new int[count];

                int[] outSubArr = array[index..];
                int countOfSubArray = outSubArr.Length;

                Array.Fill(subArray, 1);

                //if (countOfSubArray < count)
                //{
                //    for (int i = 0; i < countOfSubArray; i++)
                //    {
                //        subArray[i] = outSubArr[i];
                //    }
                //}

                // Копіюємо доступні елементи
                for (int i = 0; i < count && index + i < array.Length; i++)
                {
                    subArray[i] = array[index + i];
                }

                return subArray;
            }


            int[] subArray = SubArray(array, 2, 7);

            Console.WriteLine($"Sub array: ");
            for (int i = 0; i < subArray.Length; i++)
            {
                Console.WriteLine(subArray[i]);
            }
        }
    }
}
