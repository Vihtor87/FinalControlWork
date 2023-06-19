/*
Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] ChangeArray(string[] inArray)
{
    string[] res = new string[inArray.Length];
    int j = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            res[j] = inArray[i];
            j++;
        }
    }
    return res;
}

string[] a = { "high", "low", "left", "right", "now", "map" };
string[] b = { "summer", "winter", "spring", "fall" };
string[] c = { "1234", "432", "34", "-12", "10" };

Console.WriteLine(String.Join(" ", ChangeArray(a)));
Console.WriteLine(String.Join(" ", ChangeArray(b)));
Console.WriteLine(String.Join(" ", ChangeArray(c)));
