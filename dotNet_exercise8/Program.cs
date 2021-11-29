// exercise1
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");

//exercise2 - to add comments

int widgetsPurchased = 7;
// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

//exercise3 - multiline comment work
/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

//exercise4
Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, padd with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine("the order id is:"+orderID);
}

//exercise5 - the comments are removed
Random random1 = new Random();
string[] orderIDs1 = new string[5];

for (int i = 0; i < orderIDs1.Length; i++)
{
    int prefixValue = random1.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random1.Next(1, 1000).ToString("000");

    orderIDs1[i] = prefix + suffix;
}

foreach (var orderID in orderIDs1)
{
    Console.WriteLine(orderID);
}

//exercise6
/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random2 = new Random();
string[] orderIDs2 = new string[5];

for (int i = 0; i < orderIDs2.Length; i++)
{
    int prefixValue = random2.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random2.Next(1, 1000).ToString("000");

    orderIDs2[i] = prefix + suffix;
}
Console.WriteLine("---------");
foreach (var orderID in orderIDs2)
{
   
    Console.WriteLine(orderID);
}

//exercise7 - use of white space
// Example 1:
Console
.
WriteLine
(
"Hello World!"
)
;

// Example 2:
string firstWord = "Hello"; string lastWord = "World"; Console.WriteLine(firstWord + " " + lastWord + "!");

//exercise8
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

//exercise9 - adding curly braces to their own line to improve spacing
Random dice1 = new Random();

int roll11 = dice.Next(1, 7);
int roll22 = dice.Next(1, 7);
int roll33 = dice.Next(1, 7);

int total1 = roll11 + roll22 + roll33;
Console.WriteLine($"Dice roll: {roll11} + {roll22} + {roll33} = {total1}");

if ((roll11 == roll22) || (roll22 == roll33) || (roll11 == roll33))
{
    if ((roll11 == roll22) && (roll22 == roll33))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

//exercise10 - clearly readable code
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");

