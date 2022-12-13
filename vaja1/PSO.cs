using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace vaja1
{
    public class PSO : Algorithm
    {
        public List<ParticleSolution> Solutions = new List<ParticleSolution>();

        #region GlobalFitness
        private double _globalFitness = double.MaxValue;
        public double GlobalFitness
        {
            get
            {
                foreach(var item in Solutions)
                {
                    if(item.Fitness < _globalFitness)
                    {
                        _globalFitness = item.Fitness;
                    }
                }
                return _globalFitness;
            }
        }
        #endregion


        public double Omega = 0.7;
        public double c1 = 2.0, c2 = 2.0;

        public override Solution Execute(Problem pr)
        {
            ParticleSolution solution;
            for(int i = 0; i < 20; i++)
            {
                solution = new ParticleSolution(pr);
                Solutions.Add(solution);
            }

            for(int i = 0; i < pr.MaxFes; i++)
            {
                foreach(var particle in Solutions)
                {
                    for(int z = 0; z < pr.NumberOfDimension; z++)
                    {
                        Random random = new Random();
                        double rp = random.NextDouble();
                        double rg = random.NextDouble();

                        particle.velocity[z] = Omega * particle.velocity[z] + c1 * rp * (particle.X[z] - particle.X[z]) + c2 * rg * (Solutions.FirstOrDefault(h=>h.Fitness == GlobalFitness).X[z] - particle.X[z]);
                    }
                    particle.X = AddArrays(particle.X, particle.velocity);
                }
            }

            return Solutions.FirstOrDefault(h=>h.Fitness == GlobalFitness);
        }

        #region AddArrays
        public double[] AddArrays(double[] a, double[] b)
        {
            double[] newArray = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                newArray[i] = a[i] + b[i];
            }
            return newArray;
        }
        #endregion
    }
}
