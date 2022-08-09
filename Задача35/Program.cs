// Задайте одномерный массив из 123 случайных чисел. Найдите кол-во элементов массива, значения 
// которых лежат в отрезке [10,99].
int[] array = new int[123];
for ( int i = 0; i < 123; i++)
    array[i] = new Random().Next (0, 123);
Console.WriteLine( "[" + string.Join("," , array)+ "]");
int n = 0;
for (int i = 0; i < 123; i++)
if (array[i] >= 10 && array[i] <= 99)
n++;
Console.WriteLine(n);
