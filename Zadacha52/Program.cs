Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("--------------");
GetAvg(array);

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

void GetAvg(int[,] array){ 
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
          sum += array[i,j];  
        }
    Console.Write($"{(sum / array.GetLength(0)):f2} |"); 
    }
}

