using LemerAlgorithm;

namespace Distributions
{
    public class SimpsonsDistribution : Distribution
    {
        public double A { get; set; }
        public double B { get; set; }

        private UniformDistribution uniformDistribution;
        public SimpsonsDistribution(Generator generator, double a, double b) : base(generator)
        {
            A = a;
            B = b;
            uniformDistribution = new UniformDistribution(Generator, A / 2, B / 2);
        }

        public override double GetNext() => uniformDistribution.GetNext() + uniformDistribution.GetNext();
    }
}
