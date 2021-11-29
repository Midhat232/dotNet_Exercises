// See https://aka.ms/new-console-template for more information
//example1
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

//example2
int number = 7;
string text = "seven";
Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

//example3
Random dice1 = new Random();
int roll1 = dice1.Next();
int roll2 = dice1.Next(101);
int roll3 = dice1.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

//example4
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);