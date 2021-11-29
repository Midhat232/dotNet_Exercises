//exercise1

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//exercise2
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");



string[] fraudulentOrderIDss = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDss[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDss[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDss[2]}");

fraudulentOrderIDss[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDss[0]}");

//exercise3

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//exercise4
string[] names = { "Bob", "Conrad", "Grant" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

//exercise5
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");

//exercise6
int[] inventory1 = { 200, 450, 700, 175, 250 };
int sum1 = 0;
int bin = 0;
foreach (int items in inventory1)
{
    sum1 += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum1})");
}
Console.WriteLine($"We have {sum1} items in inventory.");

//exercise7

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}
