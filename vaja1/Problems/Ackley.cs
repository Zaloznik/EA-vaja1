using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1.Problems
{
    public class Ackley : Problem
    {
        #region Constructor
        public Ackley(int numberOfDimension, int maxFes) : base("Ackley", numberOfDimension, maxFes)
        {
            LowerLimit = new double[numberOfDimension];
            UpperLimit = new double[numberOfDimension];
            for (int i = 0;i < numberOfDimension;i++)
            {
                LowerLimit[i] = -32.768;
                UpperLimit[i] = 32.768;
            }
            
            A = 20;
            B = 0.2;
            C = 2 * Math.PI;
        }
        #endregion

        #region Properties
        public double A
        {
            get;
            set;
        }
        public double B
        {
            get;
            set;
        }
        public double C
        {
            get;
            set;
        }
        #endregion

        #region Methods

        #region Evaluate
        public override double Evaluate(double[] x)
        {
            double result1 = 0.0;
            double result2 = 0.0;
            if (x.Length != NumberOfDimension || CurrentFes > MaxFes)
            {
                return double.MaxValue;
            }
            for (int i = 0; i < NumberOfDimension; i++)
            {
                result1 += x[i] * x[i];
                result2 += Math.Cos(C * x[i]);
            }
            double result = -A * Math.Exp(-B * Math.Sqrt((1 / (double)NumberOfDimension) * result1)) - Math.Exp((1 / (double)NumberOfDimension) * result2) + A + Math.Exp(1);
            CurrentFes++;
            return result;
        }
        #endregion

        #endregion
    }
}
