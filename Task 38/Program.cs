// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.0 7.2 22.7 2.1 78.3] -> 76.2
void ArrDif()
        {
            Random rnd = new Random();
            int[] arr = new int[20];
            int min = 100, max = 0;
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(100);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
              
            }
            int difference = max - min;
            Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {difference} ");
        }
 ArrDif();