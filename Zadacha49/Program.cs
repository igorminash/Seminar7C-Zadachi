Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine("Введите номер строки: ");
int rNum = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер столбца: ");
int cNum = int.Parse(Console.ReadLine()!);

PrintNumber(array);

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
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
 
void PrintNumber(int [,] array){
    if (rNum < array.GetLength(0) && cNum < array.GetLength(1)){
        Console.WriteLine($"{array[rNum,cNum]}");
    }
    else{
        Console.WriteLine("Такого элемента нет");
    }    
}