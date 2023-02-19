//Задача - проверить введенные данные являются ли словом или числом, и являются ли эти данные полиномом.

//Вводим слово/число
Console.Write("Input your number: ");
string num = Console.ReadLine();

//Переводим данные в массив из символов
char[] number1 = num.ToCharArray();
char[] number2 = new char[number1.Length];
int index2 = number1.Length-1;
bool isNumeric = int.TryParse(num, out _); //логическая переменная для проверки на число

//Формируем второй массив в виде реверса первого
for(int index1 = 0; index1<number1.Length; index1++)
{
    number2[index2] = number1[index1];
    index2=index2-1;
}

Console.Write("You entered: ");
foreach (char ch in number1)
{
    Console.Write(" / ");
    Console.Write(ch);
}
Console.WriteLine(" /");

Console.Write("Reverse:     ");
foreach (char ch in number2)
{
    Console.Write(" / ");
    Console.Write(ch);
}
Console.WriteLine(" /");

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
if (check == true & isNumeric == true)
{
    Console.WriteLine("The entered number is polinom");
}
else if (check == false & isNumeric == true)
{
    Console.WriteLine("The entered number isn't polinom");
}
else if (check == true & isNumeric == false)
{
    Console.WriteLine("The entered word is polinom");
}
else if (check == false & isNumeric == false)
{
    Console.WriteLine("The entered word isn't polinom");
}
Console.WriteLine();