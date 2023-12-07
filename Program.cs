//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].


/*
int [] array = new int[10];
int count = 0;

for(int i = 0; i<array.Length; i++)
{
    array[i]= new Random().Next(1,101);  
    System.Console.Write(array[i]+ " ");

    if (array[i]>=20 && array[i]<=90)
    {
        count = count + 1;
    }

}
System.Console.WriteLine();
System.Console.Write(count " элементов массива, значения которых лежат в отрезке [20,90].");
*/




//Задача 2: Задайте массив на 10 целых чисел. 
//Напишите программу, которая определяет количество чётных чисел в массиве.


/*
int [] array = new int[10];
int count = 0;

for(int i = 0; i<array.Length; i++)
{
    array[i]= new Random().Next(1,21);  
    System.Console.Write(array[i]+ " ");
    
    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
}
System.Console.WriteLine();
System.Console.Write(count + " четных чисел в массиве");
*/




//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.
//Гуглила гуглила, но до конца не понимаю как это работает, и для чего вот эта строчка Random rand = new Random();

/* 
using System.ComponentModel.DataAnnotations;


Console.Write("Введите размерность массива: ");
int num = Convert.ToInt32(Console.ReadLine());

double[] randomArray = new double [num];

{
double r = 0;
int i;
Random rand = new Random();
for (i = 0; i < num; i++)
{
Console.WriteLine();

randomArray[i] = rand.NextDouble()*100;
Console.Write($"{randomArray[i]} ");
double max = randomArray[0];
double min = randomArray[0];

    if(randomArray[i] > max)
    {
        max = randomArray[i];
    }
    if (randomArray[i] < min)
    {
        min = randomArray[i];
    }
r = max-min;
}System.Console.WriteLine("Разница между максимальным и минимальным элементом: " + r);
}
*/



//Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
//Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
//Размер массива должен быть равен количеству цифр.


Console.WriteLine("Введите число в диапазоне от 1 до 100 000: ");//86 425
int num = Convert.ToInt32(Console.ReadLine());

int size = 0;

while(num%10 !<=9)
{
    size = size +1;
}
int[] array = new int[size];

array[size-1] = num%10;
if (num == 100000)
{
    array[0] = num%100000;
} 
if (num <= 99999 && num > 9999)
{
    array[0] = num%10000;
}
if (num <= 9999 && num > 999)
{
    array[0] = num%1000;
}
if (num <= 999 && num > 99)
{
    array[0] = num%100;
}
if (num <= 99 && num > 9)
{
    array[0] = num%100;
}


for(int i = 0; i<array.Length; i++)
{
    System.Console.Write(array[i]+ ", ");

}
