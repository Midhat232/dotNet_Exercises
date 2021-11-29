// exercise1
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

//exercise2
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

//exercise3
string firstName1 = "Bob";
int widgetsSold1= 7;
Console.WriteLine(firstName1 + " sold " + widgetsSold1 + 7 + " widgets.");

//exercise4
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

//exercise5
int first = 7;
int second = 5;
decimal quotient1 = (decimal)first / (decimal)second;
Console.WriteLine(quotient1);

//exercise6
Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
Console.WriteLine("Modulus of 7 / 5: " + (7 % 5));

//exercise7
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

//exercise8
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

//exercise9
int value11 = 1;
value++;
Console.WriteLine("First: " + value11);
Console.WriteLine("Second: " + value11++);
Console.WriteLine("Third: " + value11);
Console.WriteLine("Fourth: " + (++value11));

//exercise10
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");
