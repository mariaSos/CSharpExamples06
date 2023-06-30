//Ввод чисел
int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}

//Подсчет количества положительных чисел
int Counter(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

//Выполнение задачи
int[] array = ReadInt("Введите числа через пробел: ");

System.Console.WriteLine($"Количество положительных чисел равно {Counter(array)}");