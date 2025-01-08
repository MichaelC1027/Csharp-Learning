Console.WriteLine("Addition calculator");
Console.WriteLine("please enter the first number");

//datatype variableName = initial value;
double number1 = double.Parse(Console.ReadLine());
if (number1 == null)
{
    number1 = 0;
}
Console.WriteLine("please enter the second number");
double number2 = double.Parse(Console.ReadLine());
if (number2 == null)
{
    number2 = 0;
}
double sum = number1 + number2;
sum = Math.Round(sum,2); 
//string concatination -- what that means is this takes multiple strings and makes it into a single string
Console.WriteLine(number1 + "+" + number2 + " = " + sum);

//string interpoliation -- this was introducted in C# 6.0, your variables need to be put inside { } and it will read that variable perfectly fine
//this is a cleaner way to write console prints if we need to but the old way is fine as well
Console.WriteLine($"{number1} + {number2} = {sum}");
Console.ReadKey();