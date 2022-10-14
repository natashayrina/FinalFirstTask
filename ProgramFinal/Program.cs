// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначально массив можно ввсети с клавиатуры, либо задать на старте выполненния алгоритма. 
//Пример ( "hello", "2", "world" --- ("2", ";").

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array = new string[5] {"hello", "2", "world", "10", ";"};
string [] result = new string [array.Length];

int pos = 0;
int len = 3;

for (int j=0; j < array.Length; j++)
      
   {
      if (array[j].Length <= len)
      {
        result[pos] = array [j]; 
        pos++;
      } 
   }  

Console.WriteLine();
PrintArray (array);
Console.WriteLine();
PrintArray (result);
   