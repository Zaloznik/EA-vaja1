using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1
{
    public class HillClimbing : Algorithm
    {
        public HillClimbing() { }
        public override Solution Execute(Problem pr)
        {
            Solution solution = new Solution();
            solution.X = pr.GenerateRandomSolution();
            solution.Fitness = pr.Evaluate(solution.X);
            List<double[]> neighbours = new List<double[]>
            {
                new double[] { -0.1, -0.1 },
                new double[] { -0.1, 0 },
                new double[] { 0, -0.1 },
                new double[] { 0.1, 10.1 },
                new double[] { 0.1, 0 },
                new double[] { 0, 0.1 },
                new double[] { -0.1, 0.1 },
                new double[] { 0.1, -0.1 }
            };

            double[] tempSolution = solution.X;
            double tempFitness = solution.Fitness;
            for (int i = 0; i < pr.MaxFes; i++)
            {
                for(int j=0;j<neighbours.Count;j++)
                {
                    double[] tempSolution2 = AddArrays(solution.X, neighbours[j]);
                    double tempFitness2 = pr.Evaluate(tempSolution2);
                    if(tempFitness2 < tempFitness)
                    {
                        tempFitness = tempFitness2;
                        tempSolution = tempSolution2;
                    }
                }
                solution.X = tempSolution;
                solution.Fitness = tempFitness;
            }
            return solution;
        }

        #region AddArrays
        public double[] AddArrays(double[] a, double[] b)
        {
            double[] newArray = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                newArray[i] = a[i] + b[i];
            }
            return newArray;
        }
        #endregion
    }
}
