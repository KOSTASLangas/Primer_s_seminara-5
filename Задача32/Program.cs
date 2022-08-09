// Напишите программу замены элементов массива: 
// положительные элементы массива замените на отрицательные и наоборот.
int[] array = new int[10];
for ( int i = 0; i < 10; i++)
    array[i] = new Random().Next (-12, 13);
Console.WriteLine( "[" + string.Join("," , array)+ "]");
for (int i = 0; i < 10; i++)
if (array[i] > 0)
array[i] = array[i] * -1;
else 
array[i] = array[i] * -1;
Console.WriteLine( "[" + string.Join("," , array)+ "]");