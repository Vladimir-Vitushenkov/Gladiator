//короче начинаем 
using System;

namespace GladiatorBattle
{
    internal class Program
    {
        static Random Rand = new Random(); //создаем датчик случайных чисел
        static void Main(string[] args)
        {
            //блок задаваемых величин
            double armor, health, attack, damage;
            int period;
            string temp;

            //входные данные 
            Console.Write("введите уровень здоровья:");
            temp = Console.ReadLine();
            health = Convert.ToDouble(temp);

            Console.Write("введите уровень брони:");
            temp = Console.ReadLine();
            armor = Convert.ToDouble(temp);

            //формирование полученной атаки
            attack = 10 + Rand.NextDouble() * 30;
            Console.WriteLine(" размер атаки составляет -> {0:F2}", attack);

            damage = health - (armor - attack);
            Console.WriteLine(" Полученый урон равен: {0:F2}", damage);

        }
    }
}   