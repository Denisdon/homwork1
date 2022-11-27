// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter numbers: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
int numberSecond = Convert.ToInt32(Console.ReadLine());
if (numberFirst < numberSecond)
 {
    Console.WriteLine($"Number {numberSecond} is bigger than {numberFirst}");
 }
else
 {
   Console.WriteLine($"Number {numberFirst} is bigger than {numberSecond}");
 }