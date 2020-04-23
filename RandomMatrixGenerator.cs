using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3
{
    class RandomMatrixGenerator
    {
        private static RandomMatrixGenerator instance;

        public static RandomMatrixGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new RandomMatrixGenerator();
            }

            return instance;
        }

        public double[][] GenerateMatrix(int rows, int columns)
        {
            double[][] new_matrix = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                new_matrix[i] = new double[columns];

                for (int j = 0; j < columns; j++)
                {
                    new_matrix[i][j] = RandomGenerator.GetInstance().NextDouble();
                }
            }

            return new_matrix;
        }
    }
}

//metoda ima dvije odgovornosti