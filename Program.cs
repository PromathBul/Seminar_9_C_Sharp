/*
void SeriesNumsFromMToN(int m, int n)
{
    if(m < n) 
    {
        SeriesNumsFromMToN(m, n - 1);
        Console.Write(n + " ");
    }
    
    if(n < m)
    {
        Console.Write(m + " ");
        SeriesNumsFromMToN(m - 1, n); 
    }

    if(n == m) Console.Write(m + " ");
}

SeriesNumsFromMToN(5, 2);
*/

double Power(int basic, int degree)
{
    if(degree > 0) return Power(basic, degree - 1) * basic;
    else if(degree < 0) return Power(basic, degree + 1) / basic;
    else return 1;
}
Console.WriteLine(Power(2, -3));