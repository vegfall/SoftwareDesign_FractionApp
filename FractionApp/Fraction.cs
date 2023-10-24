namespace FractionApp
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator *(Fraction frac1, Fraction frac2)
        {
            Fraction newFraction = new(frac1.Numerator * frac2.Numerator, frac1.Denominator * frac2.Denominator);

            return newFraction;
        }

        public static Fraction operator /(Fraction frac1, Fraction frac2)
        {
            Fraction newFraction = new(frac1.Numerator * frac2.Denominator, frac1.Denominator * frac2.Numerator);

            return newFraction;
        }

        public static Fraction operator +(Fraction frac1, Fraction frac2)
        {
            Fraction newFraction;

            if (frac1.Denominator == frac2.Denominator)
            {
                newFraction = new(frac1.Numerator + frac2.Numerator, frac1.Denominator);
            }
            else
            {
                newFraction = new(frac1.Numerator * frac2.Denominator + frac1.Denominator * frac2.Numerator, frac1.Denominator * frac2.Denominator);
            }

            return newFraction;
        }

        public static Fraction operator -(Fraction frac1, Fraction frac2)
        {
            Fraction newFraction;

            if (frac1.Denominator == frac2.Denominator)
            {
                newFraction = new(frac1.Numerator - frac2.Numerator, frac1.Denominator);
            }
            else
            {
                newFraction = new(frac1.Numerator * frac2.Denominator - frac1.Denominator * frac2.Numerator, frac1.Denominator * frac2.Denominator);
            }

            return newFraction;
        }

        public override string ToString()
        {
            return $"{Numerator}|{Denominator}";
        }


        public override bool Equals(object? obj)
        {
            if (obj is Fraction fraction)
            {
                return Equals(fraction);
            }
            else
            {
                return false;
            }
        }

        public bool Equals(Fraction fraction)
        {
            return (Numerator == fraction.Numerator && Denominator == fraction.Denominator);
        }

        public override int GetHashCode()
        {
            return Numerator ^ Denominator;
        }

    }
}
