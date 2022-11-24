using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1.Problems
{
    public class Trid : Problem
    {
        #region Constructor
        public Trid(int numberOfDimension, int maxFes) : base("Trid", numberOfDimension, maxFes)
        {
            LowerLimit = new double[numberOfDimension];
            UpperLimit = new double[numberOfDimension];
            for(int i=0; i < numberOfDimension; i++)
            {
                LowerLimit[i] = -Math.Pow(numberOfDimension, 2);
                UpperLimit[i] = Math.Pow(numberOfDimension, 2);
            }
        }
        #endregion

        #region Methods

        #region Evaluate
        public override double Evaluate(double[] x)
        {
            double result1 = 0.0, result2 = 0.0;
            if (x.Length != NumberOfDimension)
            {
                return -1;
            }
            for (int i = 0; i < NumberOfDimension; i++)
            {
                result1 += Math.Pow((x[i] - 1), 2);
                if(i>0)
                {
                    result2 += x[i] * x[i - 1];
                }
            }
            CurrentFes++;
            double result = result1 - result2;
            return result;
        }
        #endregion

        #endregion
    }
}
