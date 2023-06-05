/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Clear();
int[] arr = new int[4];
         Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 100);
        }
        Console.WriteLine(string.Join(", ", arr));
        int Sum = 0;
        for (int i = 1; i < arr.Length; i +=2)
        {
            Sum += arr[i];
        }
        Console.WriteLine($"Сумма элементов на нечетных позициях: " + Sum);
 




