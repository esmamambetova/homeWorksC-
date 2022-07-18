// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int GetNum() 
{   
    int num = Convert.ToInt32(Console.ReadLine());    
    return num;
}

double Cub(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Round(Math.Sqrt(
                                        Math.Pow(x2-x1,2) + 
                                        Math.Pow(y2-y1,2) + 
                                        Math.Pow(z2-z1,2)
                                        ),
                                        2);  
    return result;
}
Console.WriteLine("Введите координаты двух точек А и В: ");
Console.WriteLine("Введите координаты точки A: ");
int x1 = GetNum();
int y1 = GetNum();
int z1 = GetNum();

Console.WriteLine("Введите координаты точки B: ");
int x2 = GetNum();
int y2 = GetNum();
int z2 = GetNum();

Console.WriteLine(Cub(x1,y1,z1,x2,y2,z2));

