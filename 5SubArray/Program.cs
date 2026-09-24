namespace _5SubArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Використовуючи Visual Studio, створіть проєкт за шаблоном ConsoleApplication. Потрібно:
            //2) Створіть метод int[] SubArray(int[] array, int index, int count).
            //Метод повертає частину отриманого як аргумент масиву, починаючи з позиції зазначеної в аргументі index, розмірністю, яка відповідає значенню аргументу count.
            //Якщо аргумент count містить значення більше, ніж кількість елементів, які входять до частини вихідного масиву(від зазначеного індексу index, до індексу останнього елемента),
            //то при формуванні нового масиву розмірністю в count, заповніть одиницями ті елементи, які не були скопійовані з вихідного масиву.

            //ToDo : доробити частину: Якщо аргумент count містить значення більше, ніж кількість елементів, які входять до частини вихідного масиву(від зазначеного індексу index, до індексу останнього елемента),
            
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
