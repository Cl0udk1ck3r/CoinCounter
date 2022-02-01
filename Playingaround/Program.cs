using System;
class CentConverter
{
    static void Main()
    {
        //This is the big number you're going to work with.
        decimal dollarsNcents;
        //These are the currency subdivisions.
        int halfdollars, dollars, quarters, dimes, nickels, pennies;
        //This is going to be the input variable
        string dollarsNcentsstring;
        Console.WriteLine($"How much money do you have?");
        dollarsNcentsstring = Console.ReadLine();
        //From here, you're going to convert the string into a decimal, b/c you need dollars and cents.
        dollarsNcents = decimal.Parse(dollarsNcentsstring);

        //Now the conversion begins. First, you have dollars.
        Console.WriteLine($"You have {dollars = (int)dollarsNcents:c} dollars");

        //Next, you're going to make the remaining value into something you can work with
        int moneydough = (int)((dollarsNcents * 100m) - (dollars * 100m));
        Console.WriteLine($"{moneydough}");
        quarters = (moneydough / 25);
        dimes = (moneydough - (25 * quarters)) / 10;
        nickels = (moneydough - (25 * quarters) - (dimes * 10))/5;
        pennies = (moneydough - (25 * quarters) - (dimes * 10) - (nickels * 5));
        //This is how I decided to calculate half-dollars.
        if ((quarters - 2) < 0)
        {
            halfdollars = 0;
        }
        else
        {
            halfdollars = (quarters - 2);
            quarters -= 2;
        }
        Console.WriteLine($"You have: \n {halfdollars} halfdollars \n {quarters} quarters \n {dimes} dimes \n {nickels} nickels \n {pennies} pennies");
    }
}