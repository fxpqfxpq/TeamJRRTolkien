using System;
namespace CrystallBallGame.UI
{
    public abstract class Logo
    {
       
        protected const int DefaultRow = 30;
        protected const int DefaultCol = 5;

        protected int positionCol;
        protected int positionRow;
        protected char[,] matrix;

        public Logo(int matrixRows, int matrixCols)
        {
            this.matrix = new char[matrixRows, matrixCols];
        }

        public bool Selected { get; set; }
        protected void ResetDefaultPosition()
        {
            this.positionRow = DefaultRow;
            this.positionCol = DefaultCol;
        }
        public void Print(int startX, int startY)
        {
            Console.SetCursorPosition(startX, startY);

            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    char currSymbol = this.matrix[row, col];
                    Console.SetCursorPosition(startX + col, startY + row);
                    Console.Write(currSymbol);
                }
            }
        }
    }
}
