using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NA_laba4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] A1 = Getmatrix(3, 3, 0.01, 6);
            double[] x = new double[] { 1, 1, 1, 1, 1, 1 };
        }

        static double norma_vector(double[] x)
        {
            double norma = 0;
            foreach (double xi in x) norma += xi * xi;
            return norma;
        }

        static double lambda(double[] x_k_1, double[,] A)
        {
            double[] e1 = new double[x_k_1.Length];
            double lambda = 0;
            double norma = norma_vector(x_k_1);
            for (int i = 0; i < x_k_1.Length; i++)
                e1[i] = x_k_1[i] / norma;
            double[] x_k = Matrix.MulMatrix(A, e1, e1.Length, e1.Length);
            double[] lambd;// хз как ее правильно обозначить, вроде это число должно быть
            for (int i = 0; i < x_k_1.Length; i++) ;

            return lambda;
        }

        static double[,] Getmatrix(int p, int q, double b, int n)
        {
            double[,] m = new double[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (i != j)
                        m[i, j] = b * Math.Pow(Math.Pow(i, p / 2) + Math.Pow(j, p / 2), 1 / q);
                m[i, i] = 5 * Math.Pow(i, p / 2);
            }
            return m;
        }
    }
}
