Random random = new Random();
var flip = random.Next(2);
Console.WriteLine($"{(flip == 0 ? "heads" : "tails" )}");