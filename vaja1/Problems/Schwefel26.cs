using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1.Problems
{
    public class Schwefel26 : Problem
    {
        #region Constructor
        public Schwefel26(int numberOfDimension, int maxFes) : base("Schwefel26", numberOfDimension, maxFes)
        {
            LowerLimit = new double[numberOfDimension];
            UpperLimit = new double[numberOfDimension];
            for(int i=0;i<numberOfDimension;i++)
            {
                LowerLimit[i] = -500;
                UpperLimit[i] = 500;
            }
        }
        #endregion

        #region Methods

        #region Evaluate
        public override double Evaluate(double[] x)
        {
            double result = 0;
            if (x.Length != NumberOfDimension)
            {
                return -1;
            }
            for (int i = 0; i < NumberOfDimension; i++)
            {
                result += Math.Abs(x[i] * Math.Sin(Math.Sqrt(Math.Abs(x[i]))));
            }
            CurrentFes++;
            return -result;
        }
        #endregion

        #endregion
    }
}
