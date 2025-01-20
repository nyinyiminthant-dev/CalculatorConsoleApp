using CalculatorConsoleApp.Services;

Console.WriteLine("Welcome To Console Calculator App.");
Console.WriteLine("____________________________________");
Console.WriteLine();
EfcoreServices ef = new EfcoreServices();

Console.WriteLine("Enter your number1");
string number1 = Console.ReadLine()!;
int num1 = Convert.ToInt32(number1);
Console.WriteLine(" + ,-, * , / ");
Console.WriteLine();
string sum = Console.ReadLine()!;
Console.WriteLine("Enter your number2");
Console.WriteLine();
string number2 = Console.ReadLine()!;
int num2 = Convert.ToInt32(number2);
Console.WriteLine();
ef.Calculation(num1,num2,sum);
ef.ShowOutput();

Console.WriteLine("Do you want to saved? (n) or (y)");
string save = Console.ReadLine()!;

if(save is "Y" || save is  "y")
{
    ef.AddResult();
}
else if(save is "N" || save is "n")
{
    Console.WriteLine("Thanks For Using");
}

Console.ReadLine();