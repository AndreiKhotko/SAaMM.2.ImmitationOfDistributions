using System;
using LemerAlgorithm;
using LemerAlgorithm.Exceptions;

namespace Distributions
{
    public class ExponentialDistribution : Distribution
    {
        public double Lambda
        {
            get { return _lambda; }
            set
            {
                if (!IsPositive(value))
                    throw new NegativeOrZeroNumberException($"Value {value} is not positive");

                _lambda = value;
            }
        }

        private double _lambda;

        public ExponentialDistribution(Generator generator, double lambda) : base(generator)
        {
            Lambda = lambda;
        }

        public override double GetNext() => (-1 / Lambda) * Math.Log(Generator.GetNext());
    }
}
