using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace vaja1.Problems
{
    public class Rastrigin : Problem
    {
        public Rastrigin(int numberOfDimension, int maxFes) : base("Rastrigin", numberOfDimension, maxFes)
        {
            LowerLimit = new double[numberOfDimension];
            UpperLimit = new double[numberOfDimension];
            for(int i = 0; i < numberOfDimension; i++)
            {
                LowerLimit[i] = -5.12;
                UpperLimit[i] = 5.12;
            }
        }

        public override double Evaluate(double[] x)
        {
            double fitness = -1;
            if (x.Length == NumberOfDimension && CurrentFes <= MaxFes)
            {
                fitness = 0;
                for (int i = 0; i < this.NumberOfDimension; i++)
                {
                    fitness += Math.Pow(x[i], 2) - 10 * Math.Cos(2 * Math.PI * x[i]);
                }
                CurrentFes++;
            }
            
            return fitness + 10 * this.NumberOfDimension;
        }
    }
}
