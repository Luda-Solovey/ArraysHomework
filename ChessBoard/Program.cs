using System.Text;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            string[,] chessBoard = new string[8, 8];


            // 1 Заповнюємо шахову дошку

            //1.1 порожні клітини
            for (int row = 2; row < 6; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    chessBoard[row, column] = "Пустота";
                }
            }

            //1.2 заповнюємо пішаки
            for (int column = 0; column < 8; column++)
            {
                chessBoard[1, column] = "Пішак";
                chessBoard[6, column] = "Пішак";
            }

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    Console.Write("{0} | ", chessBoard[row, column]);
                }
                Console.WriteLine();
            }

            //1.3 заповнюємо основні фігури

            string[] mainFigures = ["Тура", "Кінь", "Слон", "Ферзь", "Король", "Слон", "Кінь", "Тура"];

            for (int i = 0; i < chessBoard.Length; i++)
            {
                chessBoard[0, i] = mainFigures[i];

                chessBoard[7, i] = mainFigures[i];
            }

            Console.WriteLine("Введіть розташування фігури");

            string enteredValue = Console.ReadLine();

            //string position = "E2";

            //int col = position[0] - 'A'; // E - A = 4
            //int row = position[1] - '1'; // 2 - 1 = 1

            //Console.WriteLine($"row = {row}, col = {col}");



        }
    }
}
