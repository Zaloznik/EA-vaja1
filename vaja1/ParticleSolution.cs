using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1
{
    public class ParticleSolution : Solution
    {
        #region Properties

        #region Public
        public ParticleSolution pBest;
        public double[] velocity;
        #endregion

        #endregion

        #region Constructor
        public ParticleSolution(double[] x, double fitness)
        {
            this.X = x.Clone() as double[];
            this.Fitness = fitness;
        }
        public ParticleSolution(Problem p)
        {
            this.Problem = p;
            velocity = new double[p.NumberOfDimension];
            double l, r;
            for(int i=0; i< p.NumberOfDimension; i++)
            {
                l = Math.Abs(p.UpperLimit[i] - p.LowerLimit[i]) * (-1);
                r = Math.Abs(p.UpperLimit[i] - p.LowerLimit[i]);
                velocity[i] = GetRandomNumber(l, r);
            }
            double[] x = p.GenerateRandomSolution();
            this.X = x.Clone() as double[];
            this.Fitness = p.Evaluate(x);
            this.pBest = new ParticleSolution(this.X, this.Fitness);
        }
        #endregion

        #region GetRandomNumber
        private double GetRandomNumber(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }
        #endregion

        #region UpdatePosition
        public void updatePosition(double[] velocity)
        {
            for(int i=0;i<velocity.Length;i++)
            {
                this.X[i] += velocity[i];
                if (this.X[i] >= this.Problem.UpperLimit[i])
                {
                    this.X[i] = this.Problem.UpperLimit[i];
                }
                if (this.X[i] <= this.Problem.LowerLimit[i])
                {
                    this.X[i] = this.Problem.LowerLimit[i];
                }
            }
            this.velocity = velocity;
        }
        #endregion
    }
}
