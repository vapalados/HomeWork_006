//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите количеество чисел"); 
int howmuch = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа в количестве " + howmuch);
int[] Vvod_massiva(int h)
{
    int [] massiv = new int[h]; 
    for (int i = 0; i<h; i++)
    {
        massiv[i] = Convert.ToInt32(Console.ReadLine());
    }
    return massiv;
}
void morethannull(int [] mass)
{
    int Count = 0;
    for (int i = 0; i<mass.Length; i++)
    {
        if (mass[i]>0)
        {
            Count++;
        }
    }    
    Console.WriteLine("Всего больше нуля введено " + Count + " чисел.");
}
morethannull(Vvod_massiva(howmuch));