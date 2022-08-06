// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int GetDiff()
{
    int[] mas = {3, 7, 22, 2, 78};
    int tmp = 0;
    
    for (int i = 0; i < mas.Count(); i++)
    {
        for (int y = i+1; y < mas.Count(); y++)
        {
            if (mas[i]>mas[y]) 
            {
                tmp = mas[i];
                mas[i] = mas[y];
                mas[y] = tmp;
            }
        }
    }

    return mas[mas.Count()-1]-mas[0];
}

Console.WriteLine(GetDiff());