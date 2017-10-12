using System;
using LemerAlgorithm;

namespace Distributions
{
    public abstract class Distribution
    {
        private Generator _generator;
        public Generator Generator
        {
            get { return _generator; }
            private set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("Generator should not be null, but it is");

                _generator = value;
            }
        }
        protected Distribution(Generator generator)
        {
            Generator = generator;
        }

        public void Reset()
        {
            Generator = new Generator(Generator.A, Generator.R0, Generator.M);
        } 

        public abstract double GetNext();

        protected static bool IsPositive(double number) => number > 0;
    }
}
