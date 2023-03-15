//Написать программу, которая из имеющегося массива строе формирует массив из строк, 
//длина которых, меньше либо равна 3 символа. 
//Первоначальный массим вводится с клавиатуры.
// ["hello","2","world",":-)"] - > ["2",":-)"]
// ["1234","126","computer science"] - > ["126"]
// ["Russia","Denmark","Kazan"] - > []

using System.Linq;
string[] StringMassInputAndPromt(string message)
{

    System.Console.WriteLine(message);
    string tempString = Console.ReadLine() ?? String.Empty;
    if (tempString == string.Empty)
        return new string[0];
    string[] strings = tempString.Split();
    return strings;
}
void StringMassPrint(string[] mass)
{
    if (mass.Length > 0)
        for (int i = 0; i < mass.Length; i++)
            System.Console.Write($"{mass[i]}\t");
    else
        System.Console.WriteLine("Массив пуст");
    System.Console.WriteLine();
}
string[] ModifyStringMassQuick(string[] mass)
{
    mass = mass.Where(e => e.Length <= 3).ToArray();
    return mass;
}
string[] ModifyStringMass(string[] mass)
{
    int newLength = 0;
    for (int i = 0; i < mass.Length; i++)
        if (mass[i].Length <= 3)
            newLength++;

    string[] result = new string[newLength];
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
        if (mass[i].Length <= 3)
        {
            result[count++] = mass[i];
        }
    return result;
}
// Script text
string[] strings = StringMassInputAndPromt("Введите строку из нескольких слов разной длины");
if (strings.Length > 0)
{
    string[] newMassOne = ModifyStringMass(strings);
    string[] newMassTwo = ModifyStringMassQuick(strings);
    System.Console.WriteLine("Результат: первый метод:");
    StringMassPrint(newMassOne);
    System.Console.WriteLine("второй метод:");
    StringMassPrint(newMassTwo);
}
else
{
    System.Console.WriteLine("Вы ничего не ввели");
}
