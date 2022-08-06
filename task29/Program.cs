// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
// заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
int[] FillArray () 
{
    int[] nums = new int[8];
    for (int i = 0; i < 8; i++)
    {
        nums[i] = new Random().Next(1,100);
    }
    return nums;
}
Console.WriteLine(String.Join(", ",FillArray()));    
