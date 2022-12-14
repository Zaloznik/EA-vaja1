using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1
{
    public class Solution
    {
        #region Constructor
        public Solution() { }
        public Solution(Problem p)
        {
            this.Problem = p;
        }
        #endregion

        #region Properties
        public double[] X { get; set; }
        public double Fitness { get; set; }
        public Problem Problem { get; set; }
        #endregion
    }
}
