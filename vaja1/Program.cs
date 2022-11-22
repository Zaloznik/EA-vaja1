using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using vaja1.Problems;

namespace vaja1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 3)
            {
                Console.WriteLine("Premalo argumentov.");
                return;
            }

            int problem = Convert.ToInt32(args[0]);
            int dimension = Convert.ToInt32(args[1]);
            int maxFes = Convert.ToInt32(args[2]);

            double[] bestSolutionX = new double[dimension];
            double bestSolution = 0;

            #region Declarations
            Solution ackleyS, bukingS, easomS, penHolderS, rosenBrockS, schwefel26S, spehreS, tridS;
            HillClimbing hc = new HillClimbing();
            List<Solution> ackleySL = new List<Solution>();
            List<Solution> bukingSL = new List<Solution>();
            List<Solution> easomSL = new List<Solution>();
            List<Solution> penHolderSL = new List<Solution>();
            List<Solution> rosenBrockSL = new List<Solution>();
            List<Solution> schwefel26SL = new List<Solution>();
            List<Solution> spehreSL = new List<Solution>();
            List<Solution> tridSL = new List<Solution>();
            #endregion

            switch (problem)
            {
                #region Sphere
                //Sphere
                case 1:
                    Console.WriteLine("---------- Sphere ----------");
                    Problem p = new Problems.Sphere(dimension, maxFes);
                    double bestSolutionSphere = double.MaxValue;
                    for (int i = 0; i < p.MaxFes; i++)
                    {
                        double[] x = p.GenerateRandomSolution();
                        if (p.CurrentFes < p.MaxFes)
                        {
                            double fitness = p.Evaluate(x);
                            if (fitness < bestSolutionSphere)
                            {
                                bestSolutionSphere = fitness;
                                bestSolution = fitness;
                                bestSolutionX = x;
                                Console.WriteLine(i + ": x: [{0}]: {1}", string.Join(", ", x), fitness);
                            }
                        }
                    }
                    break;
                #endregion

                #region Ackley
                //Ackley
                case 2:
                    Console.WriteLine("---------- Ackley ----------");
                    Problem a = new Problems.Ackley(dimension, maxFes);
                    double bestSolutionAckley = double.MaxValue;
                    for (int i = 0; i < a.MaxFes; i++)
                    {
                        double[] x = a.GenerateRandomSolution();
                        if (a.CurrentFes < a.MaxFes)
                        {
                            double fitness = a.Evaluate(x);
                            if (fitness < bestSolutionAckley)
                            {
                                bestSolutionAckley = fitness;
                                bestSolution = fitness;
                                bestSolutionX = x;
                                Console.WriteLine(i+ ": x: [{0}]: {1}", string.Join(", ", x), fitness);
                            }
                        }
                    }
                    break;
                #endregion

                #region Schwefel26
                //Schwefel26
                case 3:
                    Console.WriteLine("---------- Schwefel26 ----------");
                    Problem s = new Problems.Schwefel26(dimension, maxFes);
                    double bestSolutionSchwefel26 = double.MaxValue;
                    for(int i=0;i<s.MaxFes;i++)
                    {
                        double[] x = s.GenerateRandomSolution();
                        if(s.CurrentFes < s.MaxFes)
                        {
                            double fitness = s.Evaluate(x);
                            if(fitness < bestSolutionSchwefel26)
                            {
                                bestSolutionSchwefel26 = fitness;
                                bestSolution = fitness;
                                bestSolutionX = x;
                                Console.WriteLine(i + ": x: [{0}]: {1}", string.Join(", ", x), fitness);
                            }
                        }
                    }
                    break;
                #endregion

                #region RosenBrock
                //RosenBrock
                case 4:
                    Console.WriteLine("---------- RosenBrock ----------");
                    Problem r = new Problems.Rosenbrock(dimension, maxFes);
                    double bestSolutionRosenBrock = double.MaxValue;
                    for(int i=0;i<r.MaxFes;i++)
                    {
                        double[] x = r.GenerateRandomSolution();
                        if(r.CurrentFes < r.MaxFes)
                        {
                            double fitness = r.Evaluate(x);
                            if(fitness < bestSolutionRosenBrock)
                            {
                                bestSolutionRosenBrock = fitness;
                                bestSolution = fitness;
                                bestSolutionX = x;
                                Console.WriteLine(i + ": x: [{0}]: {1}", string.Join(", ", x), fitness);
                            }
                        }
                    }
                    break;
                #endregion

                #region Bukin
                //Bukin
                case 5:
                    Console.WriteLine("---------- Bukin ----------");
                    Problem b = new Problems.Bukin(maxFes);
                    double bestSolutionBukin = double.MaxValue;
                    for(int i = 0; i < maxFes; i++)
                    {
                        double[] x = b.GenerateRandomSolution();
                        if(b.CurrentFes < b.MaxFes)
                        {
                            double fitness = b.Evaluate(x);
                            if(fitness<bestSolutionBukin)
                            {
                                bestSolutionBukin = fitness;
                                bestSolution = fitness;
                                bestSolutionX = x;
                                Console.WriteLine(i + ": x: [{0}]: {1}", string.Join(", ", x), fitness);
                            }
                        }
                    }
                    break;
                #endregion

                #region Penholder
                //Penholder
                case 6:
                    Console.WriteLine("---------- PenHolder ----------");
                    Problem pH = new Problems.PenHolder(maxFes);
                    double bestSolutionPenHolder = double.MaxValue;
                    for(int i = 0; i < maxFes; i++)
                    {
                        double[] x = pH.GenerateRandomSolution();
                        if(pH.CurrentFes < pH.MaxFes)
                        {
                            double fitness = pH.Evaluate(x);
                            if(fitness < bestSolutionPenHolder)
                            {
                                bestSolutionPenHolder = fitness;
                                bestSolution = fitness;
                                bestSolutionX = x;
                                Console.WriteLine(i + ": x: [{0}]: {1}", string.Join(", ", x), fitness);
                            }
                        }
                    }
                    break;
                #endregion

                #region Easom
                //Easom
                case 7:
                    Console.WriteLine("---------- Easom ----------");
                    Problem e = new Problems.Easom(maxFes);
                    double bestSolutionEasom = double.MaxValue;
                    for(int i=0; i < e.MaxFes; i++)
                    {
                        double[] x = e.GenerateRandomSolution();
                        if(e.CurrentFes < e.MaxFes)
                        {
                            double fitness = e.Evaluate(x);
                            if(fitness < bestSolutionEasom)
                            {
                                bestSolutionEasom = fitness;
                                bestSolution = fitness;
                                bestSolutionX = x;
                                Console.WriteLine(i + ": x: [{0}]: {1}", string.Join(", ", x), fitness);
                            }
                        }
                    }
                    break;
                #endregion

                #region Trid
                //Trid
                case 8:
                    Console.WriteLine("---------- Trid ----------");
                    Problem t = new Problems.Trid(dimension, maxFes);
                    double bestSolutionTrid = double.MaxValue;
                    for(int i=0;i<t.MaxFes;i++)
                    {
                        double[] x = t.GenerateRandomSolution();
                        if(t.CurrentFes < t.MaxFes)
                        {
                            double fitness = t.Evaluate(x);
                            if( fitness < bestSolutionTrid)
                            {
                                bestSolutionTrid = fitness;
                                bestSolution = fitness;
                                bestSolutionX = x;
                                Console.WriteLine(i + ": x: [{0}]: {1}", string.Join(", ", x), fitness);
                            }
                        }
                    }
                    break;
                #endregion

                #region HillClimbing
                case 9:
                    Console.WriteLine("---------- HillClimbing ----------");

                    for (int i = 0; i < 100; i++)
                    {
                        ackleyS = hc.Execute(new Ackley(dimension,maxFes));
                        bukingS = hc.Execute(new Bukin(maxFes));
                        easomS = hc.Execute(new Easom(maxFes));
                        penHolderS = hc.Execute(new PenHolder(maxFes));
                        rosenBrockS = hc.Execute(new Rosenbrock(dimension,maxFes));
                        schwefel26S = hc.Execute(new Schwefel26(dimension,maxFes));
                        spehreS = hc.Execute(new Sphere(dimension,maxFes));
                        tridS = hc.Execute(new Trid(dimension,maxFes));

                        ackleySL.Add(ackleyS);
                        bukingSL.Add(bukingS);
                        easomSL.Add(easomS);
                        penHolderSL.Add(penHolderS);
                        rosenBrockSL.Add(rosenBrockS);
                        schwefel26SL.Add(schwefel26S);
                        spehreSL.Add(spehreS);
                        tridSL.Add(tridS);
                    }
                    break;
                #endregion
            }

            if(!problem.Equals(9))
            {
                Console.WriteLine("\nBest solution --> x: [{0}] = {1} :)", string.Join(", ", bestSolutionX), bestSolution);
            }
            else
            {
                double[] resitva = smallestFitness(ackleySL);
                Console.WriteLine("Ackley min: " + resitva[0] + " avg: " + resitva[2] + " std: " + resitva[3]);
                resitva = smallestFitness(bukingSL);
                Console.WriteLine("Bukin min: " + resitva[0] + " avg: " + resitva[2] + " std: " + resitva[3]);
                resitva = smallestFitness(easomSL);
                Console.WriteLine("Easom min: " + resitva[0] + " avg: " + resitva[2] + " std: " + resitva[3]);
                resitva = smallestFitness(penHolderSL);
                Console.WriteLine("PenHolder min: " + resitva[0] + " avg: " + resitva[2] + " std: " + resitva[3]);
                resitva = smallestFitness(rosenBrockSL);
                Console.WriteLine("RosenBrock min: " + resitva[0] + " avg: " + resitva[2] + " std: " + resitva[3]);
                resitva = smallestFitness(schwefel26SL);
                Console.WriteLine("Schwefel26 min: " + resitva[0] + " avg: " + resitva[2] + " std: " + resitva[3]);
                resitva = smallestFitness(spehreSL);
                Console.WriteLine("Sphere min: " + resitva[0] + " avg: " + resitva[2] + " std: " + resitva[3]);
                resitva = smallestFitness(tridSL);
                Console.WriteLine("Trid min: " + resitva[0] + " avg: " + resitva[2] + " std: " + resitva[3]);

            }
            Console.ReadLine();
        }

        #region SmallestFitness
        // 0 - smallest fitness
        // 1 - array X
        // 2 - average
        // 3 - standardni odklon
        public static double[] smallestFitness(List<Solution> solutionA)
        {
            double[] returnValue = new double[4];
            returnValue[0] = solutionA[0].Fitness;
            returnValue[1] = 0;
            double sum = solutionA[0].Fitness;
            for(int i=1;i<solutionA.Count;i++)
            {
                sum+= solutionA[i].Fitness;
                if (solutionA[i].Fitness < returnValue[0])
                {
                    returnValue[0] = solutionA[i].Fitness;
                    returnValue[1] = i;
                }
            }
            returnValue[2] = sum / 100;

            for(int i=0;i<solutionA.Count;i++)
            {
                returnValue[3] += Math.Pow(solutionA[i].Fitness - returnValue[2], 2)/100;
            }
            returnValue[3] = Math.Sqrt(returnValue[3]);
            return returnValue;
        }
        #endregion
    }
}
