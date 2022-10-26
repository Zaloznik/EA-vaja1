using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1.Problems
{
    public class Rosenbrock : Problem
    {
        #region Constructor
        public Rosenbrock(int numberOfDimension, int maxFes) : base("Rosenbrock", numberOfDimension, maxFes)
        {
            LowerLimit = new double[numberOfDimension];
            UpperLimit = new double[numberOfDimension];

            for(int i=0; i < numberOfDimension; i++)
            {
                LowerLimit[i] = -5;
                UpperLimit[i] = 10;
            }
        }
        #endregion

        #region Methods

        #region Evaluate
        public override double Evaluate(double[] x)
        {
            double result = 0;
            if (x.Length != NumberOfDimension || CurrentFes > MaxFes)
            {
                return -1;
            }
            for (int i = 0; i < NumberOfDimension-1; i++)
            {
                result += Math.Abs(100 * Math.Pow(x[i + 1] - Math.Pow(x[i], 2), 2) + Math.Pow(x[i]-1,2));
            }
            CurrentFes++;
            return result;
        }
        #endregion

        #endregion
    }
}
