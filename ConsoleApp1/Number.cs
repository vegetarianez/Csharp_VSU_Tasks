class Number : IEquatable<Number>
{
    private int numerator;
    private int denominator;

    public int GetNumerator()
    {
        return numerator;
    }

    public int GetDenominator()
    {
        return denominator;
    }

    public Number(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public override string ToString()
    {
        return ToDec().ToString();
    }

    public void Normalize()
    {
        if (denominator < 0)
        {
            denominator *= -1;
            numerator *= -1;
        }

        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    } 

    public static Number operator +(Number n1, Number n2)
    {

        Number number = new(n1.numerator * n2.denominator + n2.numerator * n1.denominator, n1.denominator * n2.denominator);
        number.Normalize();
        return number;
    }

    public static Number operator -(Number n1, Number n2)
    {
        Number number = new(n1.numerator * n2.denominator - n2.numerator * n1.denominator, n1.denominator * n2.denominator);
        number.Normalize();
        return number;
    }

    public static Number operator *(Number n1, Number n2)
    {
        Number number = new(n1.numerator * n2.numerator, n1.denominator * n2.denominator);
        number.Normalize();
        return number;
    }

    public static Number operator /(Number n1, Number n2)
    {
        Number number = new(n1.numerator * n2.denominator, n1.denominator * n2.numerator);
        number.Normalize();
        return number;
    }

    public static bool operator ==(Number n1, Number n2)
    {
        return n1.Equals(n2);
    }

    public static bool operator !=(Number n1, Number n2)
    {
        return !n1.Equals(n2);
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Number);
    }

    public bool Equals(Number? other)
    {
        if (other is null)
            return false;
        if (ReferenceEquals(this, other))
            return true;
        return numerator * other.denominator == other.numerator * denominator;
    }

    public double ToDec()
    {
        return (Double)numerator/denominator;
    }

    public static Number FromDouble(double dec)
    {
        Number number = new((int)(dec * Math.Pow(10, dec.ToString().Length - 2)), (int)Math.Pow(10, dec.ToString().Length - 2));
        number.Normalize();
        return number;
    }


    static int GCD(int a, int b)
    {
        if (a == 0)
        {
            return b;
        }
        else
        {
            while (b != 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(numerator, denominator);
    }
}