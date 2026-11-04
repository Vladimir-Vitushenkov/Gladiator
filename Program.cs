//короче начинаем 
using System;
using System.Collections;

namespace GladiatorBattle
{
    internal class Program
    {
        static Random Rand = new Random(); //создаем датчик случайных чисел
        static void Main(string[] args)
        {
            //блок задаваемых величин
            double armor1,armor2, healthone, healthtwo, attack1, attack2, damage1, damage2;
            int period;
            string temp;

            //входные данные 
            do
            {
                Console.Write("введите уровень здоровья первого гладиатора:");
                temp = Console.ReadLine();
                healthone = Convert.ToDouble(temp);
                if (healthone <= 0)
                {
                    Console.WriteLine("Здоровье не может принимать такое значение, повторите попытку");
                }
            } while (healthone <= 0);


            do
            {
                Console.Write("введите уровень здоровья второго гладиатора:");
                temp = Console.ReadLine();
                healthtwo = Convert.ToDouble(temp);
                if (healthtwo <= 0)
                {
                    Console.WriteLine("Здоровье не может принимать такое значение, повторите попытку");
                }
            } while (healthtwo <= 0);

            //броня
            armor1 = 25 + Rand.NextDouble() * 40;
            Console.WriteLine("уровень брони первого гладиатора составляет —> {0:F2}", armor1);

            armor2 = 25 + Rand.NextDouble() * 40;
            Console.WriteLine("уровень брони второго гладиатора составляет —> {0:F2}", armor2);

            //формирование полученной атаки
            do
            {
                ////if (healthtwo >= 10 && healthone >= 10)
                attack1 = 10 + Rand.NextDouble() * 30;

                attack2 = 10 + Rand.NextDouble() * 30;
                if (healthtwo > 0 && healthone > 0)
                {
                    ///attack1 = 10 + Rand.NextDouble() * 30;
                    Console.WriteLine("размер атаки первого гладиатора составляет —> {0:F2}", attack1);

                    damage2 = Math.Abs(attack1 - armor2);
                    Console.WriteLine("Урон полученный вторым гладиатором равен —> {0:F2}", damage2);

                    healthtwo = healthtwo - damage2;
                    Console.WriteLine("оставшееся здоровье второго гладиатора составляет —> {0:F2}", healthtwo);

                    ///attack2 = 10 + Rand.NextDouble() * 30;
                    Console.WriteLine("размер атаки второго гладиатора составляет —> {0:F2}", attack2);

                    damage1 = Math.Abs(attack2 - armor1);
                    Console.WriteLine("Урон полученный первым гладиатором равен —> {0:F2}", damage1);

                    healthone = healthone - damage1;
                    Console.WriteLine("оставшееся здоровье первого гладиатора составляет —> {0:F2}", healthone);
                }
            } while (healthtwo > 0 && healthone > 0);

        }
    }
}   