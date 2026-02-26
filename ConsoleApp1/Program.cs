// See https://aka.ms/new-console-template for more information
Number number1 = new(42, 4);
double d = 0.7;
Number number2 = Number.FromDouble(d);
Console.WriteLine(number2.GetNumerator().ToString());
Console.WriteLine(number2.GetDenominator().ToString());
Console.WriteLine(d.ToString());
