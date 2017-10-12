using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemerAlgorithm;
using LemerAlgorithm.Exceptions;

namespace Distributions
{
    public class GammaDistribution : Distribution
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

        public int Eta
        {
            get { return _eta; }
            set
            {
                if (!IsPositive(value))
                    throw new NegativeOrZeroNumberException($"Value {value} is not positive");

                _eta = value;
            }
        }

        private double _lambda;
        private int _eta;

        public GammaDistribution(Generator generator, int eta, double lambda) : base(generator)
        {
            Lambda = lambda;
            Eta = eta;
        }

        public override double GetNext()
        {
            double mul = 1;

            for (int i = 0; i < Eta; i++)
            {
                mul *= Generator.GetNext();
            }

            return (-1 / Lambda) * Math.Log(mul);
        }
    }
}
