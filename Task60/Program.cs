// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateKubMatrixInt(int rows, int columns, int depth, int min, int max )
{
    int[,,] matrixKub = new int[rows, columns, depth];

    for (int i = 0; i < matrixKub.GetLength(0); i++)
    {
        for (int j = 0; j < matrixKub.GetLength(1); j++)
        {
            for (int k = 0; k < matrixKub.GetLength(2); k++)
            {
                matrixKub[i, j, k] = UniqueElementsMatrix(matrixKub, i, j, k, min, max );
            }
        }
    }
    return matrixKub;

}


int UniqueElementsMatrix(int[,,] matrixKub, int i, int j, int k, int min, int max )
{
    var rnd = new Random();
    int unique = default;
    bool current = true;
    while (current)
    {
        bool massivUnique = false;
        unique = rnd.Next(min, max + 1);
        for (int i1 = 0; i1 < matrixKub.GetLength(0); i1++)
        {
            if (massivUnique) { break; }
            for (int j1 = 0; j1 < matrixKub.GetLength(1); j1++)
            {
                if (massivUnique) { break; }
                for (int k1 = 0; k1 < matrixKub.GetLength(2); k1++)
                {
                    if (matrixKub[i1, j1, k1] == unique)
                    {
                        massivUnique = true;
                        break;
                    }
                    if (i1 == i && j1 == j && k1 == k)
                    {
                        current = false;
                        break;
                    }
                }
            }
        }
    }
    return unique;
}


void PrintMatrixKub(int[,,] matrixKub)
{
    for (int i = 0; i < matrixKub.GetLength(0); i++)
    {
        for (int j = 0; j < matrixKub.GetLength(1); j++)
        {
            Console.Write("  |");
            for (int k = 0; k < matrixKub.GetLength(2); k++)
            {
                if (k < matrixKub.GetLength(2)) Console.Write($"{matrixKub[i, j, k],3}({i}, {j}, {k})");
                else Console.Write($"{matrixKub[i, j, k],3}");
            }
        }
        Console.WriteLine("  |");
    }
}


int[,,] arr = CreateKubMatrixInt(4, 4, 4, 10, 40);

UniqueElementsMatrix(arr,0,0,0,0,0);
PrintMatrixKub(arr);


