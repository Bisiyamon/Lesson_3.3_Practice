//Задача - проверить введенные данные являются ли числом, и являются ли эти данные полиномом.

//Вводим слово/число
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

//Переводим данные в массив из символов
char[] number1 = num.ToCharArray();

bool check = false; //логическая переменная для проверки совпадения всех символов обоих массивов

for (int index1 = 0; index1<number1.Length; index1++)
{
    int index2 = number1.Length-1-index1;
    if(number1[index1] == number1[index2])
    {
        check = true;
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