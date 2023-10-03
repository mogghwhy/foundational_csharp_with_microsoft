Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
// Your code goes here
string message = "";
if (daysUntilExpiration == 0)
{
    message = "Your subscription has expired.";
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    message = "Your subscription expires within a day!";
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    message = $"Your subscription expires in {daysUntilExpiration} days.";
}
else if (daysUntilExpiration < 10)
{
    message = "Your subscription will expire soon. Renew now!";
}

if (discountPercentage > 0)
{
    message += Environment.NewLine + $"Renew now and save {discountPercentage}%!";
}
Console.WriteLine(message);