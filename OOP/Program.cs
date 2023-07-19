// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");

static int Armstrong(int number)
{
    int sum = 0;
    int a = number;
    int d = number.ToString().Length;
    while(a > 0)
    {
        int temp = a % 10;
        sum += (int)Math.Pow(temp, d);
        a /= 10;
    }
    if(sum == number)
    {
        Console.WriteLine(number);
    }
    else
    {
        Console.WriteLine(-1);
    }
    if (sum == number)
    {
        return number;
    }
    else
    {
        return -1;
    }
}
int b = Armstrong(1532);
if(b != -1)
{
    Console.WriteLine("dung");
}
else
{
    Console.WriteLine("sai");
}



