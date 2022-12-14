using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace vaja1
{
    public class PSO : Algorithm
    {

        #region Constructor
        public PSO()
        {
            populationSize = 20;
            omega = 0.7;
            c1 = 2;
            c2 = 2;
        }
        #endregion

        #region Properties

        #region Private
        private int populationSize;
        private double omega;
        private double c1;
        private double c2;

        private List<ParticleSolution> population = new List<ParticleSolution>();
        private Solution gBest;

        #endregion

        #endregion

        #region Execute
        public override Solution Execute(Problem pr)
        {
            Populate(pr);
            double[] velocity;
            int maxFes = pr.MaxFes;
            while (maxFes > 0)
            {
                for(int i = 0; i < populationSize; i++)
                {
                    velocity = new double[pr.NumberOfDimension];
                    for(int d = 0; d < pr.NumberOfDimension; d++)
                    {
                        velocity[d] = omega * (population[i].velocity[d]) + c1 * GetRandomNumber(0, 1) * (population[i].pBest.X[d] - population[i].X[d]) + c2 * GetRandomNumber(0, 1) * (gBest.X[d] - population[i].X[d]);
                    }
                    population[i].updatePosition(velocity);
                    population[i].Fitness = pr.Evaluate(population[i].X);
                    maxFes--;
                    if (population[i].Fitness < population[i].pBest.Fitness)
                    {
                        population[i].pBest = new ParticleSolution(pr);
                        population[i].pBest.X = population[i].X.Clone() as double[];
                        population[i].pBest.Fitness = population[i].Fitness;
                    }
                    if (population[i].Fitness < gBest.Fitness)
                    {
                        gBest = new ParticleSolution(pr);
                        gBest.X = population[i].X.Clone() as double[];
                        gBest.Fitness = population[i].Fitness;
                    }
                }     
            }
            return gBest;
        }
        #endregion

        #region Populate
        public void Populate(Problem pr)
        {
            for(int i=0;i<populationSize;i++)
            {
                ParticleSolution particleSol = new ParticleSolution(pr);
                population.Add(particleSol);
                if(population.Count == 1)
                {
                    gBest = population[0];
                }
                if (population[i].Fitness < gBest.Fitness)
                {
                    gBest = new ParticleSolution(pr);
                    gBest.X = population[i].X.Clone() as double[];
                    gBest.Fitness = population[i].Fitness;
                }
            }
        }
        #endregion

        #region GetRandomNumber
        private double GetRandomNumber(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }
        #endregion

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
