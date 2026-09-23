namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void ReturnMinMaxAvg(out int min, out int max, out decimal avg, params int[] input)
            {
                if (input.Length == 0)
                {
                    min = 0;
                    max = 0;
                    avg = 0;
                    return;
                }

                min = input[0];
                max = input[0];
                int summ = input[0];
                avg = 0;

                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i] < min)
                        min = input[i];
                    if (input[i] > max)
                        max = input[i];

                    summ += input[i];
                }
                avg = (decimal)summ / input.Length;
                for (int i = 0; i < input.Length; i++)
                {
                    Console.WriteLine(input[i]);
                }
            }

            ReturnMinMaxAvg(out int min, out int max, out decimal avg, 1, 2, 3, 4, 5, 6);

            Console.WriteLine($"Min: {min}, Max: {max}, Avg: {avg}");
        }
    }
}
