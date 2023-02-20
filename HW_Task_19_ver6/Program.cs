Console.Write("Input your number: ");
string num = string.Empty;

while(true)
{
    num = Console.ReadLine();
    bool isNumeric = int.TryParse(num, out _);
    if(isNumeric == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("Incorrect input, you have to enter only number");
    }
}

int num2 = Convert.ToInt32(num);
int fin = 0;
double num_left = 0;
double num_right = 0;
bool check = false;

while(fin != num.Length/2)
{
    if (fin==0)
    {
        num_right = Math.Truncate((num2/Math.Pow(10, fin))%10);
        num_left = Math.Truncate((num2/Math.Pow(10, num.Length-1)));
        fin++;
        System.Console.WriteLine("Num Left {0}", num_left);
        System.Console.WriteLine("Num Right {0}", num_right);
    }
    else
    {
        num_right = Math.Truncate((num2/Math.Pow(10, fin))%10);
        num_left = Math.Truncate((num2/Math.Pow(10, num.Length-1-fin))%10);
        fin++;
        System.Console.WriteLine("Num Left {0}", num_left);
        System.Console.WriteLine("Num Right {0}", num_right);
    }
   
    if (num_left == num_right)
    {
        check = true;
        Console.WriteLine(check);
    }
    else
    {
        check = false;
        break;
    }
}

Console.WriteLine();
if (check == true)
{
    Console.WriteLine("The entered number {0} is polinom", num);
}
else
{
    Console.WriteLine("The entered number {0} isn't polinom", num);
}
Console.WriteLine();