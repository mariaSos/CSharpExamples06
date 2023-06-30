// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
 void Koordinate(int b1, int k1, int b2, int k2, out double y1, out double y2){
     double x = (b2-b1)/(k1-k2);
     y1 = k1 * x + b1;
     y2 = k2 * x + b2;
 }
 
 //Ввод чисел
int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}

int[] nums = ReadInt("Введите k1, b1, k2, b2 через пробел: ");
//int x = 0;
//int y = 0;
Koordinate(nums[0],nums[1],nums[2],nums[3],out double y1, out double y2);
System.Console.WriteLine($"Координаты точки пересечения двух прямых({y1},{y2})");