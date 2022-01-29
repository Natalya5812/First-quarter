// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int X = 3; //значение, с которым будем сравнивать длину строки
string []OriginalArray = new string [5]; // исходный массив, произвольная длина из 5 строк
//int i = 0; // Номер индекса элемента в исходном массиве
int count = 0; // начальное количество строк в полученном массиве 
string []ResultArray = new string [count]; // полученный массив


void EnterFirstArray (string []OriginalArray) // метод заполнения исходного массива
{Console.WriteLine("Введите текст из " + OriginalArray.Length + " строк");
    for (int i = 0; i < OriginalArray.Length; i++)
    {
        OriginalArray [i] = Console.ReadLine();}
Console.WriteLine ();}

   
void PrintFirstArray (string []OriginalArray) // вывод исходного массива в консоль для наглядности
{Console.Write ("Исходный массив: [");
    for (int i = 0; i < OriginalArray.Length; i++)
{
    Console.Write ($"'{OriginalArray [i]}' ");}}


void PrintSecondArray (string []ResultArray) // вывод полученного массива после соответствующей сортировки 
{Console.Write ("Полученный массив: [");  
    for (int i = 0; i < OriginalArray.Length; i++)
        {string Text = OriginalArray [i]; // Строка, которая находится по указанному индексу
        int S = Text.Length; // Длина строки 
            {if (S <= X) 
                {Array.Resize (ref ResultArray, count+1);
                ResultArray [count] = OriginalArray [i];
                Console.Write ($"'{ResultArray [count]}' ");}
        }
}}



EnterFirstArray (OriginalArray);
PrintFirstArray (OriginalArray);
Console.Write ("] => "); 
PrintSecondArray (ResultArray);
Console.Write ("]"); 

