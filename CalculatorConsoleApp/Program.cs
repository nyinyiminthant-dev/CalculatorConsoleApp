using CalculatorConsoleApp.Services;

Console.WriteLine("Welcome To Console Calculator App.");
Console.WriteLine("____________________________________");
Console.WriteLine();
EfcoreServices ef = new EfcoreServices();

int i = 1;

void Round()
{
    Console.WriteLine("Do you want to sart again? (y) or (n) ");
    string round = Console.ReadLine()!;
    
    if(round is "Y" || round is "y")
    {

        Console.WriteLine("Welcome To Console Calculator App Again.");
        Console.WriteLine("____________________________________");
        i++;
    }
    else if (round is "N" || round is "n")
    {
        Console.WriteLine("Thanks For Using");
    }
}

while (i == 1 || i > 0)
{

    #region calculator

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
    ef.Calculation(num1, num2, sum);
    ef.ShowOutput();

    Console.WriteLine("Do you want to saved? (n) or (y)");
    string save = Console.ReadLine()!;

    if (save is "Y" || save is "y")
    {
        ef.AddResult();
        Round();
        
    }
    else if (save is "N" || save is "n")
    {
        Round();
    }
    #endregion
}

Console.ReadLine();