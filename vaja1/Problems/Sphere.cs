using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1.Problems
{
    public class Sphere : Problem
    {

        #region Constructor
        public Sphere(int numberOfDimension, int maxFes) : base("Sphere", numberOfDimension, maxFes)
        {
            UpperLimit = new double[numberOfDimension];
            LowerLimit = new double[numberOfDimension];
            for(int i = 0; i < numberOfDimension; i++)
            {
                LowerLimit[i] = -5.12;
                UpperLimit[i] = 5.12;
            }

        }
        #endregion

        #region Methods

        #region Evaluate
        public override double Evaluate(double[] x)
        {
            double fitness = 0.0;
            if(x.Length != NumberOfDimension || CurrentFes > MaxFes)
            {
                return -1;
            }
            for(int i = 0; i < NumberOfDimension; i++)
            {
                fitness += x[i] * x[i];
            }
            CurrentFes++;
            return fitness;
        }
        #endregion

        #endregion
    }
}
