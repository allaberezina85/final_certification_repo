# Итоговая контрольная работа по основному блоку

## Содержание задания: 

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

**Задача:** *Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

## <u>Выполнение работы</u>
### Блок схемы программы
**Блок схема основной программы**


![блок схема основной программы ](https://github.com/allaberezina85/final_certification_repo/blob/main/img/1.jpg).


**Блок схемы подпрограмм**


![блок схема подпрограммы ](https://github.com/allaberezina85/final_certification_repo/blob/main/img/2.jpg).
![блок схема подпрограммы ](https://github.com/allaberezina85/final_certification_repo/blob/main/img/3.jpg).
### Код программы

```sh
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

```

### Описание программы
1. Пользователь вводит размер массива.
2. Далее пользователь заполняет все элементы массива.
3. В результате работы программы выводится в консоль исходный массив и новый массив с элементами длиной не больше 3 символов.
### Результат работы программы

Скриншот выполнения программы ниже:


![консоль ](https://github.com/allaberezina85/final_certification_repo/blob/main/img/4.png)


Посмотреть программу можно на удаленном [репозитории](https://github.com/allaberezina85/final_certification_repo "открыть репозиторий").

