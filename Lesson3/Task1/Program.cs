// int a = 3, b = 2, c = 5, d = 7;


double CalculateFormula(int a, int b, int c, int d)
{
    double numetator = a * b;
    int denomenator = c + d;
    double result = numetator / denomenator;
    return result;
}



double result = CalculateFormula(1, 2, 3, 4);
System.Console.WriteLine(result);