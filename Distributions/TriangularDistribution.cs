using System;
using LemerAlgorithm;

namespace Distributions
{
    public class TriangularDistribution : Distribution
    {
        public double A { get; set; }
        public double B { get; set; }

        public bool IsFirstVariant { get; set; }
        public TriangularDistribution(Generator generator, double a, double b, bool isFirstVariant) : base(generator)
        {
            if (a > b)
            {
                var tmp = a;
                a = b;
                b = tmp;
            }
            A = a;
            B = b;
            IsFirstVariant = isFirstVariant;
        }

        public override double GetNext()
        {
            var r1 = Generator.GetNext();
            var r2 = Generator.GetNext();

            if (IsFirstVariant)
                return A + (B - A) * Math.Max(r1, r2);
            else
                return A + (B - A) * Math.Min(r1, r2);
        }
    }
}
