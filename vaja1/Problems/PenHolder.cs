using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1.Problems
{
    public class PenHolder : Problem
    {
        #region Constructor
        public PenHolder(int maxFes) : base("PenHolder", 2, maxFes)
        {
            LowerLimit = new double[] { -11, -11 };
            UpperLimit = new double[] { 11, 11 };
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
            result = -Math.E * Math.Pow(Math.Abs(Math.E * Math.Abs(-(Math.Sqrt(Math.Pow(x[0], 2) + Math.Pow(x[1],2))/Math.PI+1 * Math.Cos(x[0]) * Math.Cos(x[1])))),-1);
            CurrentFes++;
            return result;
        }
        #endregion

        #endregion
    }
}
