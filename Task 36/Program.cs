// Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void SummNum(int [] array)
        {
            int summ = 0;
            for (int i = 1; i < array.Length; i ++)
            {
                array[i] = new Random().Next(100, 999);
                if (array[i] % 2 != 0) 
                summ += array[i];

            }
            Console.WriteLine($"Сумма элементов на нечётных позициях {summ}");
        }

SummNum();