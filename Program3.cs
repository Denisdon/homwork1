Console.WriteLine("Enter number: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
if ((numberFirst % 2) == 0)
{
    Console.WriteLine($"Number {numberFirst} is even");
}
else 
{
    Console.WriteLine($"Number {numberFirst} is odd");
}