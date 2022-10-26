using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1.Problems
{
    public class Bukin : Problem
    {
        #region Constructor
        public Bukin(int maxFes) : base("Bukin", 2, maxFes)
        {
            UpperLimit = new double[] { -15, -15 };
            LowerLimit = new double[] { -5, -5 };
        }
        #endregion

        #region Methods

        #region Evaluate
        public override double Evaluate(double[] x)
        {
            double result = 0.0;
            if (x.Length != NumberOfDimension || CurrentFes > MaxFes)
            {
                return -1;
            }
            result = 100 * Math.Sqrt(Math.Abs(x[1] - 0.01 * Math.Pow(x[0], 2))) + 0.01 * Math.Abs(x[0] + 10);
            return result;
        }
        #endregion

        #endregion
    }
}
