using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class RandomGenerator
    {
        private static RandomGenerator instance;
        private Random generator;

        private RandomGenerator()
        {
            this.generator = new Random();
        }

        public static RandomGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new RandomGenerator();
            }
            return instance;
        }

        public double[,] NextDouble(int m, int n)
        {
            double[,] matrix = new double[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = generator.NextDouble();
                }
            }
            return matrix;
        }
    }
}
