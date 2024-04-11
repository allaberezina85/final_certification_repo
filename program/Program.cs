// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
//печать элементов массива в строку через пробел
void PrintArray(string [] mas)
{

    foreach (var item in mas)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

//заполнение элементов массива размером num
string [] FillArray(int num)
{
    string[] mas = new string[num];
    for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine("Введите элемент массива: ");
        mas[i] = Console.ReadLine()!;
    }
    return mas;
}

//подсчет количества элементов массива длиной не больше 3 символов
int CountElemWithLength3(string [] arrey)
{
    int count = 0;
  
    foreach (var item in arrey)
    {
        if(item.Length<=3)
        {
           count ++;
        }
    }
    
    return count;
}

//создание нового массива с элементами прежнего массива длина которых не больше 3 символов
string [] NewArrayWithLength3(string [] arrey)
{
    string [] arreyNew=new string [CountElemWithLength3(arrey)] ;
   for (int j = 0; j < arreyNew.Length; j++)
        {
            for (int i = 0; i < arrey.Length; i++)
            {
                if(arrey[i].Length<=3)
                {
                       arreyNew[j]=arrey[i];
                       arrey[i]="null";
                       break;
                }
            }
        }
    return arreyNew;
}

//основная программа
int num=0;
Console.WriteLine("Введите размер массива: ");
try
{
    num=Convert.ToInt32(Console.ReadLine());

}
catch (ArgumentException e)
{
    Console.WriteLine($"Processing failed: {e.Message}");
}
if (num!=0)
{
    string [] arrey=FillArray(num);

    Console.WriteLine("Исходный массив: ");
    PrintArray(arrey);

    
    string [] arreyNew=NewArrayWithLength3(arrey);
    if (arreyNew.Length!=0)
    {

    Console.WriteLine("Новый массив с элементами длиной не больше 3 символов: ");
    PrintArray(arreyNew);
    }
    else
     Console.WriteLine("В исходном массиве нет элементов длиной не больше 3 символов. ");
   

}
 
