//int [] numbers = new int[10]
//int[] a = {1, 2, 3, 5, 6, 7, 8, 9, 0};
//System.Console.WriteLine(a[5]);
//1- что мы хотим получить (void - ничего, int-числовой массив, string - строка)
//2- название функции (любое)
//3- что мы хотим отдать

int[] CreateArray(int size)
{
    int[] array = new int[size]; // создаем массив задавая размер через size
    for (int i = 0; i < size; i++) // функция фор читай сам) заполнили
    {
        array[0] = i+1;
    }
    return array; //отдаем массив
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] numbers = CreateArray(10);
WriteArray (numbers);