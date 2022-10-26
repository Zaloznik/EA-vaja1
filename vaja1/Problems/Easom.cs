using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1.Problems
{
    public class Easom : Problem
    {
        #region Constructor
        public Easom(int maxFes) : base("Easom", 2, maxFes)
        {
            LowerLimit = new double[] { -100, -100};
            UpperLimit = new double[] { 100, 100 };
        }
        #endregion

        #region Methods

        #region Evaluate
        public override double Evaluate(double[] x)
        {
            if(x.Length != 2 || CurrentFes > MaxFes)
            {
                return -1;
            }
            double result = -Math.Cos(x[0] * Math.Cos(x[1] * Math.Exp(-Math.Pow(x[0] + Math.PI, 2) - Math.Pow(x[1] + Math.PI, 2))));
            return result;
        }
        #endregion

        #endregion
    }
}
