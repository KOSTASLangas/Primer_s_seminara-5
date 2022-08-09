// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.
Console.WriteLine("Введите кол-во элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array_first = new int[n];
int m;
if (n % 2 == 0)
    m = n / 2;          
    else
    m = n / 2 + 1;  // иф здесь нужен для корректного задавания длины второго массива с произведениями. Т.е. чтобы при четном кол-ве элементов было нечетное кол-во произведений. 
int[] array_second = new int[m]; 
for ( int i = 0; i < n; i++)
    array_first[i] = new Random().Next (1, 10);
Console.WriteLine( "Исходный массив: [" + string.Join("," , array_first)+ "]");
Console.WriteLine();
for ( int i = 0; i < array_second.Length; i++)
    array_second[i] = array_first[i] * array_first [n - 1 - i ]; // во второй массив запоминаем произведение 1 элемента с увеличением и последнего с убыванием
Console.WriteLine( "Конечный массив: [" + string.Join("," , array_second)+ "]");
