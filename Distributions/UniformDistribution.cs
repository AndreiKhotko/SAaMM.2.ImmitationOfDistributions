using LemerAlgorithm;
using System;

namespace Distributions
{
    public class UniformDistribution : Distribution
    {
        public double A { get; set; }
        public double B { get; set; }
        public UniformDistribution(Generator generator, double a, double b) : base(generator)
        {
            A = a;
            B = b;
        }

        public override double GetNext() => A + (B - A) * Generator.GetNext();
    }
}
