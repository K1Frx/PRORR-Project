﻿using PRORR.Interfaces;

namespace PRORR.Implementation
{
    public class DefaultMutationController : IMutationController
    {
        private float mutationRate;
        private IRandomGenerator randomGenerator;
        private float mean;
        private float stdDev;

        public DefaultMutationController(float mutationRate, float mean, float stdDev, IRandomGenerator randomGenerator)
        {

            this.mutationRate = mutationRate;
            this.randomGenerator = randomGenerator;
            this.mean = mean;
            this.stdDev = stdDev;
        }

        public float GetMutationRate(int iteration)
        {
            return mutationRate * (1 - (float)iteration / 1000);
        }

        public void Mutate(Individual individual)
        {
            individual.Genes[randomGenerator.Next(0, individual.Genes.Length)] += randomGenerator.NextGaussian(mean, stdDev);
        }
    }
}
