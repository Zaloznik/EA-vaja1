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
                returnArray[i] = random.NextDouble() * (UpperLimit[i] - LowerLimit[i]) + LowerLimit[i];
            }
            return returnArray;
        }
        #endregion

        #region GenerateVelocity
        public double[] GenerateVelocity()
        {
            double[] returnArray = new double[NumberOfDimension];
            double[] max = ArrayMinosArray(UpperLimit, LowerLimit);
            double[] min = new double[NumberOfDimension];
            for(int i = 0; i < NumberOfDimension; i++)
            {
                min[i] = max[i] * (-1);
            }
            for (int i = 0; i < NumberOfDimension; i++)
            {
                returnArray[i] = random.NextDouble() * (max[i] - min[i]) + min[i];
            }
            return returnArray;
        }
        #endregion

        #region ArrayMinosArray
        public double[] ArrayMinosArray(double[] a, double[] b)
        {
            double[] newArray = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                newArray[i] = Math.Abs(a[i] - b[i]);
            }
            return newArray;
        }
        #endregion

        #region IsFeasible
        public bool isFeasible(Solution s)
        {
            for(int i=0;i<s.X.Length;i++)
            {
                if (s.X[i] > UpperLimit[0] && s.X[i] < LowerLimit[0])
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #endregion
    }
}
