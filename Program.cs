/* 1. программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трёхзначное число N");
int N = int.Parse(Console.ReadLine());
int temp = (N/10)%10;
Console.WriteLine($"вторая цифра числа - {temp}");
*/

/* 2. программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
if ((N*N/N)<100) Console.WriteLine("Третьей цифры нет");  // умножили и поделили на N, чтобы получить положительное число, иначе любое отрицательное число <100
else {
    int temp = (N/100)%10;
    Console.WriteLine($"третья цифра числа {temp}");
}*/

/* 3. программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Введите цифру, обозначающую день недели");
int day = int.Parse(Console.ReadLine());
if (day==7) Console.WriteLine("да, это воскресенье");
else if (day==6) Console.WriteLine("да, это суббота");
else Console.WriteLine("нет");
*/

// дополнительное задание

Console.WriteLine("Введите число элементов массива");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];
int index=0;
int Kol20=0;
Console.WriteLine("Введите массив столбцом");
while (index<length){
    int elementmassiva = int.Parse(Console.ReadLine());
    array[index]=elementmassiva;
    if (elementmassiva==20) Kol20++;
    index++;
}
Console.WriteLine();
Console.WriteLine("Обратный массив без числа 20");

int ind=length-1;
while (ind>-1) {
    if (array[ind] != 20) {
        Console.WriteLine(array[ind]);
        ind=ind-1;}
    else ind=ind-1;}

Console.WriteLine($"Количество невошедших чисел 20 - {Kol20}");




