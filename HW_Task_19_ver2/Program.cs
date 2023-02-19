//Задача - проверить введенные данные являются ли словом или числом, и являются ли эти данные полиномом.
//Второй вариант - перевели оба массива в строки и сравнили их

//Вводим слово/число
Console.Write("Input your number: ");
string num = Console.ReadLine();

//Переводим данные в массив из символов
char[] number1 = num.ToCharArray();
char[] number2 = num.ToCharArray();

Array.Reverse(number2);

bool isNumeric = int.TryParse(num, out _); //логическая переменная для проверки на число

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

string array = new string(number1);
string reverse_array = new string(number2);

Console.WriteLine();
if (array == reverse_array & isNumeric == true)
{
    Console.WriteLine("The entered number is polinom");
}
else if (array != reverse_array & isNumeric == true)
{
    Console.WriteLine("The entered number isn't polinom");
}
else if (array == reverse_array & isNumeric == false)
{
    Console.WriteLine("The entered word is polinom");
}
else if (array != reverse_array & isNumeric == false)
{
    Console.WriteLine("The entered word isn't polinom");
}
Console.WriteLine();