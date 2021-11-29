//exercise1 -  code uses escape character sequences to add whitespace
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

//exercise2 - use the \" escape sequence
Console.WriteLine("Hello \"World\"!");
//Console.WriteLine("c:\source\repos"); - will give error
Console.WriteLine("c:\\source\\repos");


//exercise3
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

//exercise4
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

//exercise5
string firstName1 = "Bob";
string greeting1 = "Hello";
string message1 = greeting1 + " " + firstName1 + "!";
Console.WriteLine(message1);

//exercise6 - Use string interpolation
string firstName2 = "Bob";
string message2 = $"Hello {firstName2}!";
Console.WriteLine(message2);

//exercise7 
string firstName3 = "Bob";
string greeting = "Hello";
Console.WriteLine($"{greeting} {firstName3}!");

//exercise8
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

//exercise9
string projectName1 = "ACME";
string englishLocation = $@"c:\Exercise\{projectName1}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName1}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

