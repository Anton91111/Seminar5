/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();
int[] numbers = new int[4];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(100, 1000);
                Console.Write(numbers[i] + " ");
            }
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) 
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество четных чисел в массиве: {count}");