// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите размер массива");
int size_array = int.Parse(Console.ReadLine()!);
string[] array = new string[size_array];
FillArray(array);
size_array = 0;
for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {

            size_array++;
        }
    }
string[] small_array = new string[size_array];
ArrayCutter(array, small_array);
PrintArray(array, small_array);

void FillArray(string[] array){
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Console.ReadLine()!;
    }
}


void ArrayCutter(string[] array, string[] small_array)
{
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            small_array[j] = array[i];
            j++;
        }
    }
}


void PrintArray(string[] array1, string[] array2)
{
    for(int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.Write(" →  ");
    
    for(int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
}