// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
bool CheckNum(int num) {
    if (num > 100) return true;
    return false;
}
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (CheckNum(num)) {
    int newNum = num;
    while (true) {
        if (newNum >=1000) newNum = newNum/10;
        if (newNum < 1000) {
            Console.WriteLine($"Третья цифра в числе {num} -> {newNum%10}");
            break;
        }
    }
} else Console.WriteLine($"Третьей цифры в числе {num} нет");