// Есть одномерный массив целых чисел, который автоматически заполняется. Сформируйте новый массив из квадратов чисел исходного массива.

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int min = 0, int max = 10)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
int[] SolveEx(int[] array)
{
    int size = array.Length;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[i];
    }
    return result;
}
void NotTruePrint(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine(array[i]);
    }
}


string TruePrint(int[] array)
{
    string res = string.Empty;
    int size = array.Length;

    res = "[ ";
    for (int i = 0; i < size; i++)
    {
        res += $"{array[i],3} ";
    }
    res += "]";

    return res;
}

string TruePrint2(int[] array)
{
   return $"[{string.Join(' ',array)} ]";
}

int[] startArray = CreateArray(10);
//System.Console.WriteLine(TruePrint(startArray));
//File.WriteAllText("file.txt", TruePrint(a));
FillArray(startArray, -10, 20);
System.Console.WriteLine(TruePrint2(startArray));
int[] resultArray = SolveEx(startArray);
System.Console.WriteLine(TruePrint2(resultArray));
