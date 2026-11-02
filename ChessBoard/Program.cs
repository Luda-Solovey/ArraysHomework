using System.Text;

namespace ChessBoard_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            string[,] chessBoard1 =  ChessBoard.CreateChessBoardAndFillFigures();
            ChessBoard.DisplayFigures(chessBoard1);
            ChessBoard.DisplayChessBoard(chessBoard1);


            //Домашнє завдання 3 
            //Створіть шахову дошку 
            //розташуйте на доштці всі фігури як початковий розкелад в шахи. Тобто заповніть 4 лінії фігурами. перші дві і останні дві.ПРосто доробіть той приклад що в репозиторії. 
            //1 - Заповнити тсартовіий розклад. 
            //2 вивести кожну фігуру відділити палочкою чикл в циклі

            //1рядок -| Тура | Ферзь... 
            //2 рядок | Пішак | Пішак... 

            //пустота

            //7 - рядок | Пішак | Пішак... 
            //8 - рядок | Тура | Ферзь

            //Пішаки заповніть 2 циклами
            //Створіть метод по виводу всієї дошки просто клітика E4 -Пішак, як немає пишете Пусто



            ////1.1 Заповнюємо шахову дошку порожніми клітинами
            //string[,] chessBoard = new string[8, 8];
            //for (int row = 0; row < chessBoard.GetLength(0); row++)
            //{
            //    for (int column = 0; column < chessBoard.GetLength(1); column++)
            //    {
            //        chessBoard[row, column] = "Пусто";
            //    }
            //}

            ////1.2 заповнюємо пішаки
            //for (int column = 0; column < chessBoard.GetLength(1); column++)
            //{
            //    chessBoard[1, column] = "Пішак";
            //    chessBoard[6, column] = "Пішак";
            //}

            ////1.3 заповнюємо основні фігури
            //string[] mainFigures = ["Тура", "Кінь", "Слон", "Королева", "Король", "Слон", "Кінь", "Тура"];

            //for (int i = 0; i < chessBoard.GetLength(0); i++)
            //{
            //    chessBoard[0, i] = mainFigures[i];
            //    chessBoard[7, i] = mainFigures[i];
            //}

            ////1.4 вивід шахової дошки на екран
            //for (int row = 0; row < chessBoard.GetLength(0); row++)
            //{
            //    for (int column = 0; column < chessBoard.GetLength(1); column++)
            //    {
            //        Console.Write("{0} | ", chessBoard[row, column]);
            //    }
            //    Console.WriteLine();
            //}

            ////1.5 Створіть метод по виводу всієї дошки просто клітика E4 -Пішак, як немає пишете Пусто
            //for (int i = 0; i < chessBoard.GetLength(0); i++)//рядок
            //{
            //    for (int j = 0; j < chessBoard.GetLength(1); j++)//стовпчик
            //    {
            //        char columnLetter = (char)('A' + j); // Перетворюємо індекс стовпчика на букву A-H (символ А має код 65 в ASCII)
            //        int rowNumber = 8 - i; // Перетворюємо індекс рядка на номер (1-8)
            //        Console.WriteLine($" {columnLetter}{rowNumber} - {chessBoard[i, j]}");
            //    }
            //}
        }
    }
}
