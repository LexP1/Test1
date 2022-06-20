// 1. Дано: массива строк 
// Первоначанальный массив можно ввести с клавитуры, либо задать на старте выполнения алгоритма

Console.Write("Please enter the Length of Initial Array: ");
int arrayInLength = Convert.ToInt32(Console.ReadLine());
string [] arrayIn = new string [arrayInLength];
Console.WriteLine("Please enter StringArray with Enter devidor");
for(int i = 0; i < arrayIn.Length; i++)
{
    arrayIn[i] = Console.ReadLine();
}

// string [] arrayIn = {"hello world", "2", ";-)", "1234", "Hi!"};
string [] arrayOut = new string [ArrayNewSize(arrayIn)];
Solve (arrayIn, arrayOut);
File.WriteAllText("OutputArray.txt", PrintArray(arrayOut));

// 1.1. Вычисление размера финального массива
int ArrayNewSize (string [] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <=3 )
        count++;
    }
    return count;
}

// 2. Выбрать элементы с длиной меньше либо равно 3 символа
void Solve (string [] arrA, string [] arrB)
{
    int count = 0;
    for(int i = 0; i < arrA.Length; i++)
    {
        if (arrA[i].Length <=3 )
        {
            arrB[count] = arrA[i];
            count++;
        }
    }
    // foreach (string item  in arrA)
    // {
    //     if (item.Length <=3 )
    //     {
    //         arrOutput[count] = item;
    //         count++;
    //     }
    // }
} 

// 3. Записать результат в массив // новый?
string PrintArray (string [] arr)
{
    string res = string.Empty;
    int size = arr.Length;
    res = "[ ";
    for (int i = 0; i < size; i++)
    {
        res += $" {arr[i]}  ;";
    }
    res += " ]";
    return res;
}
