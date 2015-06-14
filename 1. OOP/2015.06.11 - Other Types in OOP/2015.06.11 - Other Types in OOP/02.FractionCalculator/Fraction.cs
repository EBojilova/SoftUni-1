namespace FractionCalculator
{
    using System;

    struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long a, long b) : this()
        {
            this.Numerator = a;
            this.Denominator = b;
        }

        public long Numerator 
        {
            get
            {
                return this.numerator;
            }
            set
            {
                if (value < long.MinValue || value > long.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Numerator is out of range [-9223372036854775808 … 9223372036854775807].");
                }
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value < long.MinValue || value > long.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Denominator is out of range [-9223372036854775808 … 9223372036854775807].");
                }
                else if (value == 0)
                {
                    throw new InvalidOperationException("Denominator cannot be 0.");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator, f1.Denominator * f2.Denominator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator, f1.Denominator * f2.Denominator);
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal)this.Numerator / this.Denominator);
        }
    }
}
