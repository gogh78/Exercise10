using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Угол задан с помощью целочисленных значений gradus - градусов,
            //min - угловых минут, sec - угловых секунд. Реализовать класс,
            //в котором указанные значения представлены в виде свойств.
            //Для свойств предусмотреть проверку корректности данных.
            //Класс должен содержать конструктор для установки начальных значений,
            //а также метод ToRadians для перевода угла в радианы.
            //Создать объект на основе разработанного класса.
            //Осуществить использование объекта в программе.

            Angle angle = new Angle(00, 00, 00);
            Console.WriteLine("Введите значение градуса угла");
            angle.Gradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение минут угла");
            angle.Min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение секунд угла");
            angle.Sec = Convert.ToInt32(Console.ReadLine());
            angle.Output();
            Console.ReadKey();
            Console.WriteLine();
        }
    }
    class Angle
    {
        //int gradus;
        public int Gradus { get; set; }
        int min;
        public int Min
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Минуты должны быть в диапазоне от 0 до 59");
                }
            }
            get
            {
                return min;
            }
        }
        int sec;
        public int Sec
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Секунды должны быть в диапазоне от 0 до 59");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        static double ToRadians(double Gradus, double Min, double Sec)
        {
            double decimalAngle = Gradus + Min / 60 + Sec / 3600;
            double radianAngle = Math.PI * decimalAngle / 180;
            return radianAngle;
        }


        public void Output()
        {
            double radianAngle = ToRadians(Gradus, Min, Sec);
            Console.WriteLine("Значение угла в градусах = {0}гр {1}мин {2}сек", Gradus, Min, Sec);
            Console.WriteLine("Значение угла в радианах = {0:0.000}рад", radianAngle);
        }
    }
}
