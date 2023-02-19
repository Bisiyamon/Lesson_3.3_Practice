System.Console.Write("PLease input a number: ");
int input_number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Please input value of exponent: ");
int exponent = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();
System.Console.WriteLine("Result: ");
for (int index = 1; index<=input_number; index++)
{
    int calculated_number = Convert.ToInt32(Math.Pow(index, exponent));
    System.Console.Write(calculated_number);
    System.Console.Write(" / ");
}
System.Console.WriteLine();
System.Console.WriteLine();