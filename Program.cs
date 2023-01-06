// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("******************************************************");
Console.WriteLine("Program to find the max of three numbers a, b, and c");
Console.WriteLine("******************************************************");
Console.WriteLine();

Console.WriteLine("Enter The Values for a, b, and c");
Console.WriteLine();

//Declear your variables
double a, b, c, largest;

//Enter the variables to compute
Console.Write("Value of a = ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.Write("Value of b = ");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.Write("Value of c = ");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

//Compare the variables to obtain the largest
largest = 0;

 if (a > b)
 {
    largest = a;
 }
 else if (b > a)
 {
    largest = b;
 }
 else if (a == b)
{
    largest = a;
}

if (c > largest)
{
    largest = c;
}

Console.WriteLine("The largest number = " + largest);
Console.WriteLine();
Console.WriteLine();

Console.ReadLine();
