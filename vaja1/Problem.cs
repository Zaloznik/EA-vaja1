using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1
{
    public abstract class Problem
    {
        #region Constructor
        public Problem(string name, int numberOfDimension, int maxFes)
        {
            Name = name;
            NumberOfDimension = numberOfDimension;
            MaxFes = maxFes;
            CurrentFes = 0;
        }
        #endregion

        #region Properties

        #region Random
        Random random = new Random();
        #endregion

        #region Name
        public string Name
        {
            get;
            set;
        }
        #endregion

        #region NumberOfDimension
        public int NumberOfDimension
        {
            get;
            set;
        }
        #endregion

        #region UpperLimit
        public double[] UpperLimit
        {
            get;
            set;
        }
        #endregion

        #region LowerLimit
        public double[] LowerLimit
        {
            get;
            set;
        }
        #endregion

        #region MaxFes
        public int MaxFes
        {
            get;
            set;
        }
        #endregion

        #region CurrentFes
        public int CurrentFes
        {
            get;
            set;
        }
        #endregion

        #endregion

        #region Methods

        #region Evaluate
        public abstract double Evaluate(double[] x);
        #endregion

        #region GenerateRandomSolution
        public double[] GenerateRandomSolution()
        {
            double[] returnArray = new double[NumberOfDimension];
            for(int i = 0; i < NumberOfDimension; i++)
            {
                returnArray[i] = random.NextDouble() * (UpperLimit[0] - LowerLimit[0]) + LowerLimit[0];
            }
            return returnArray;
        }
        #endregion

        #endregion
    }
}
