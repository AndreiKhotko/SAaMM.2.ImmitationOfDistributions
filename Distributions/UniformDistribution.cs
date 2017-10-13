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
            if (a > b)
            {
                var tmp = a;
                a = b;
                b = tmp;
            }
            A = a;
            B = b;
        }

        public override double GetNext() => A + (B - A) * Generator.GetNext();
    }
}
