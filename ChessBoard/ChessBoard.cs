namespace ChessBoard_App
{
    public static class ChessBoard
    {
        public static string[,] CreateChessBoardAndFillFigures()
        {
            //1.1 Заповнюємо шахову дошку порожніми клітинами
            string[,] chessBoard = new string[8, 8];
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                for (int column = 0; column < chessBoard.GetLength(1); column++)
                {
                    chessBoard[row, column] = "Пусто";
                }
            }
            //1.2 заповнюємо пішаки
            for (int column = 0; column < chessBoard.GetLength(1); column++)
            {
                chessBoard[1, column] = "Пішак";
                chessBoard[6, column] = "Пішак";
            }
            //1.3 заповнюємо основні фігури
            string[] mainFigures = { "Тура", "Кінь", "Слон", "Королева", "Король", "Слон", "Кінь", "Тура" };
            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                chessBoard[0, i] = mainFigures[i];
                chessBoard[7, i] = mainFigures[i];
            }

            return chessBoard;
        }

        public static void DisplayFigures(string[,] chessBoard)
        {
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                for (int column = 0; column < chessBoard.GetLength(1); column++)
                {
                    Console.Write("{0} | ", chessBoard[row, column]);
                }
                Console.WriteLine();
            }
        }

        public static void DisplayChessBoard(string[,] chessBoard)
        {
            for (int i = 0; i < chessBoard.GetLength(0); i++)//рядок
            {
                for (int j = 0; j < chessBoard.GetLength(1); j++)//стовпчик
                {
                    char columnLetter = (char)('A' + j); // Перетворюємо індекс стовпчика на букву A-H (символ А має код 65 в ASCII)
                    int rowNumber = 8 - i; // Перетворюємо індекс рядка на номер (1-8)
                    Console.WriteLine($" {columnLetter}{rowNumber} - {chessBoard[i, j]}");
                }
            }
        }
    }
}
