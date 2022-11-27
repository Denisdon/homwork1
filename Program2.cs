// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter three numbers: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
int numberSecond = Convert.ToInt32(Console.ReadLine());
int numberThird = Convert.ToInt32(Console.ReadLine());

if (numberFirst>numberSecond)
 {
    if (numberFirst>numberThird)
    {
        Console.WriteLine($"Number {numberFirst} is the biggest");
    } 
    else 
    {
        Console.WriteLine($"Number {numberThird} is the biggest");
    }
 }
 else 
 {
    if (numberSecond>numberThird)
    {
        Console.WriteLine($"Number {numberSecond} is the biggest");
    } 
    else 
    {
        Console.WriteLine($"Number {numberThird} is the biggest");
    }
    
 }