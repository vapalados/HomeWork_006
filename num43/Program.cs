//Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double[] Vvod_Peremennih()
{
    double[] mass_per = new double[4];
    Console.WriteLine("Введите значение к1 в формулу y = k1 * x + b1"); 
    mass_per[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение b1 в формулу y = k1 * x + b1"); 
    mass_per[1] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение к2 в формулу y = k2 * x + b2"); 
    mass_per[2] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение b2 в формулу y = k2 * x + b2"); 
    mass_per[3] = Convert.ToDouble(Console.ReadLine());
    return mass_per;
}
void peresechenie(double [] mass)
{
    double resx = 0;
    resx = (mass[3] - mass[1])/(mass[0]-mass[2]);
    double result = mass[0] * resx + mass[1];
    Console.WriteLine("Точка пересечения равна: " + resx + "," + result ); 
}
peresechenie(Vvod_Peremennih());