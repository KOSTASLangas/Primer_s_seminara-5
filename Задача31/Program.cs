// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. 
// Найдите сумму отрицательных и положительных элементов массива 

int[] array = new int[12];
for ( int i = 0; i < 12; i++)
    array[i] = new Random().Next (-9, 10);
Console.WriteLine( "[" + string.Join("," , array)+ "]");
int sum_pol = 0;
int sum_neg = 0;    
for (int i = 0; i < 12; i++)
{
    if (array[i] > 0)
    sum_pol = sum_pol + array[i];
    else
    sum_neg = sum_neg + array[i];
}
Console.WriteLine( "Сумма положительных равна: " + sum_pol );
Console.WriteLine( "Сумма отрицательных равна: " + sum_neg );