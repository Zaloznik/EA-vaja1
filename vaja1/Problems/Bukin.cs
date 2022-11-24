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
            UpperLimit = new double[] { -15, -5 };
            LowerLimit = new double[] { -3, 3 };
        }
        #endregion

        #region Methods

        #region Evaluate
        public override double Evaluate(double[] x)
        {
            if (x.Length != NumberOfDimension)
            {
                return -1;
            }
            double result = 100 * Math.Sqrt(Math.Abs(x[1] - 0.01 * Math.Pow(x[0], 2))) + 0.01 * Math.Abs(x[0] + 10);
            return result;
        }
        #endregion

        #endregion
    }
}
