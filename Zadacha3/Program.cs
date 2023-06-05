/*Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
Console.Clear();
double[] array = {10.25,15.30,85.15,90.25};
Console.WriteLine(string.Join(", ",array));
double max= double.MinValue;
double min = double.MaxValue;
for(int i = 0; i < array.Length;i++)
{
if (array[i]> max)
       {
          max= array[i];
       }
    if(array[i]<min)
       {
          min= array[i];
      }
}
double diff = max - min;
Console.WriteLine($"Разница между максимальным и минимальным значением "+ diff);

