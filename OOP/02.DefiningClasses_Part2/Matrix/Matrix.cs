using System;
namespace Matrix
{
    public class Matrix<T> where T : struct
    {
        private T[,] matrix;
        private readonly int rows;
        private readonly int cols;

        // Constructor
        public Matrix(int rows, int cols)
        {
            T type = default(T);
            if (!((type is double) || (type is int) || (type is decimal)))
            {
                throw new ApplicationException("T must be (double, int or decimal)");
            }
            else
            {
                this.rows = rows;
                this.cols = cols;
                this.matrix = new T[rows, cols];
            }
        }

        // Indexer
        public T this[int row, int col]
        {
            get
            {
                if (isInRange(row, col))
                {
                    return this.matrix[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }
            }
            set
            {
                if (isInRange(row, col))
                {
                    this.matrix[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }
            }
        }

        private bool isInRange(int row, int col)
        {
            if ((row < 0) || (row >= this.rows) || (col < 0) || (col >= this.cols))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if ((first.rows != second.rows) || (first.cols != second.cols))
            {
                throw new ApplicationException("The matrices must have the same size!");
            }
            var resultMatrix = new Matrix<T>(first.rows, first.cols);
            for (int i = 0; i < first.rows; i++)
            {
                for (int j = 0; j < first.cols; j++)
                {
                    resultMatrix[i, j] = (dynamic)first[i, j] + second[i, j];
                }
            }
            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if ((first.rows != second.rows) || (first.cols != second.cols))
            {
                throw new ApplicationException("The matrices must have the same size!");
            }
            var resultMatrix = new Matrix<T>(first.rows, first.cols);
            for (int i = 0; i < first.rows; i++)
            {
                for (int j = 0; j < first.cols; j++)
                {
                    resultMatrix[i, j] = (dynamic)first[i, j] - second[i, j];
                }
            }
            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            var resultMatrix = new Matrix<T>(first.rows, first.cols);



            return resultMatrix;
        }
    }
}
