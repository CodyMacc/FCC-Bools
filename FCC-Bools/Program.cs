Random coin = new Random();
int coinNum = coin.Next(100);
string result = coinNum > 50 ? "heads" : "tails";
Console.WriteLine(result);