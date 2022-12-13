using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja1
{
    public class ParticleSolution : Solution
    {
        public double[] velocity { get; set; }
        public ParticleSolution(Problem pr)
        {
            X = pr.GenerateRandomSolution();
            velocity = pr.GenerateRandomSolution();
            Fitness = pr.Evaluate(X);
        }
    }
}
