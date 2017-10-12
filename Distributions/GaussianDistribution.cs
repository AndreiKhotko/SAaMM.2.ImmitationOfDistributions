using System;
using LemerAlgorithm;

namespace Distributions
{
    public class GaussianDistribution : Distribution
    {
        public double Mean { get; set; }
        public double StandartDeviation { get; set; }
        public GaussianDistribution(Generator generator, double mean, double standardDeviation) : base(generator)
        {
            Mean = mean;
            StandartDeviation = standardDeviation;
        }

        public override double GetNext()
        {
            double sum = 0;

            for (int i = 0; i < 6; i++)
            {
                sum += Generator.GetNext();
            }

            return Mean + StandartDeviation * Math.Sqrt(2) * (sum - 3);
        }
    }
}
