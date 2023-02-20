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
char[] number2 = new char[number1.Length];
int index2 = number1.Length-1;

//Формируем второй массив в виде реверса первого
for(int index1 = 0; index1<number1.Length; index1++)
{
    number2[index2] = number1[index1];
    index2=index2-1;
}

bool check = false; //логическая переменная для проверки совпадения всех символов обоих массивов
index2=0;

for (int index1 = 0; index1<number1.Length; index1++)
{
    if(number1[index1] == number2[index2])
    {
        check = true;
        index2++;
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