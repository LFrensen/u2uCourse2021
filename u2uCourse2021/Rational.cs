namespace u2uCourse2021
{
    public struct Rational
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public void MultiplyWith(Rational other)
        {
            this.Numerator *= other.Numerator;
            this.Denominator *= other.Denominator;
        }

        public Rational Multiply(Rational first, Rational second)
        {
            return new Rational() { Numerator = first.Numerator * second.Numerator, Denominator = first.Denominator * second.Denominator };
        }
    }
}
