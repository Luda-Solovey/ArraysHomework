internal class Program
{
    static void Main(string[] args)
    {

        //Задание 3
        //Використовуючи Visual Studio, створіть проєкт за шаблоном ConsoleApplication.Потрібно:
        //1) Створити метод MyReverse(int[ ] array), який приймає як аргумент масив цілих чисел і повертає інвертований масив(елементи масиву у зворотному порядку).

        int[] arr = { 1, 25, 48, 7 };

        //1й спосіб. Змінює вихідний масив
        Array.Reverse(arr);

        Console.WriteLine($"Reversed arr: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        //2й спосіб

        int[] arr2 = { 1, 25, 48, 7 };
        int[] reversed2 = arr2.Reverse().ToArray();

        Console.WriteLine($"Reversed arr2: ");
        for (int i = 0; i < reversed2.Length; i++)
        {
            Console.WriteLine(reversed2[i]);
        }
        //3й спосіб. Створює новий масив, не змінюючи вихідний

        int[] array = { 1, 25, 48, 7 };
        int[] reversed3 = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reversed3[i] = array[array.Length - 1 - i];
        }

        Console.WriteLine($"Reversed array: ");
        for (int i = 0; i < reversed3.Length; i++)
        {
            Console.WriteLine(reversed3[i]);
        }
    }
}
