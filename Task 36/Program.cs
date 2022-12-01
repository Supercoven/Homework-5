// Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void SummNum(int [] arr)
        {
            int summ = 0;
            for (int i = 1; i < arr.Length; i += 2)
            {
                arr[i] = new Random().Next(100, 999);
                if (arr[i] % 2 != 0) 
                summ += arr[i];

            }
            Console.WriteLine($"i  find  sum  of the odd numbers in the array, his equals is: {sum}");
        }

SummNum();