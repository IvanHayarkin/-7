
/*
Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 for (int j = 0; j < array.GetLength(1); j++)
        {
 array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 Console.Write("[ ");
 for (int j = 0; j < array.GetLength(1); j++)
        {
 Console.Write(array[i, j] + " ");
        }
 Console.Write("]");
 Console.WriteLine("");
    }
}
*/

/*
Console.Write("Введите строку:");

 int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;

 Console.Write("Введите столбец:");

int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

 int n = 5; 

int m = 7; 

Random random = new Random();

 int[,] arr = new int[n, m];

 Console.WriteLine("Исходный массив:");

for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
arr[i, j] = random.Next(10, 99);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует");
}
else
{
Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}
Console.ReadLine();
*/

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}