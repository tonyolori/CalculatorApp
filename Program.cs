bool end = false;
double num1 = 0, num2 = 0;
string operand;

List<string> acceptedOperands = new List<string> { "*", "/", "-", "+" };
while (!end)
{


    do
    {
        Console.WriteLine("Input a number");
    } while (!double.TryParse(Console.ReadLine(), out num1));




    while (true)
    {
        Console.WriteLine("input an operand");
        operand = Console.ReadLine();

        if (string.IsNullOrEmpty(operand) || operand.Length != 1 || !acceptedOperands.Contains(operand))
            Console.WriteLine("Invalid input");
        else
        {
            break;
        }

    }


    do
    {
        Console.WriteLine("input a second number");

    } while (!double.TryParse(Console.ReadLine(), out num2));



    try
    {

        switch (operand)
        {

            case "+":
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("cannot divide by 0");
                    break;
                }
                string formattedNumber = string.Format("{0:F" + 2 + "}", num1 / num2);
                Console.WriteLine($"{num1} / {num2} = {formattedNumber}");
                break;
            case "*":
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
            default:
                Console.WriteLine("Invalid operand chosen!");
                break;
        }
    }
    catch
    {
        Console.WriteLine("error during calculation");
    }


    Console.WriteLine("would you like to continue, Y/N");
    while (true)
    {
        string response = Console.ReadLine() ?? "";
        //empty string for a new line   
        Console.WriteLine("");


        if (response.ToUpper().Equals("Y"))
        {
            break;
        }
        else if (response.ToUpper().Equals("N"))
        {
            end = true;
            break;
        }

        Console.WriteLine("invalid input, try again");


    }
}
