using System;

namespace TestLib
{
    public class SquareLib
    {
       
       public static void squareT(double sideA, double sideB, double sideC)
        {
            double Result;
            if (sideA > 0 && sideB > 0 && sideC > 0) {
                if (sideC + sideB > sideA && sideA + sideB > sideC && sideC + sideA > sideB)
                {
                    if (sideC > sideA && sideC > sideB)
                    {
                        if ((sideA * sideA) + (sideB * sideB) == (sideC * sideC))//Math.Pow работает ну очень странно :\
                        {
                            Result = (sideA * sideB) / 2;
                            Console.WriteLine("Треугольник прямоугольный. Площадь : " + Result);
                        }
                        else
                        {
                            double p = (sideA + sideB + sideC) / 2;
                            Result = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                            Console.WriteLine("Треугольник не прямоугольный: " + Result);
                        }
                    }
                    else if (sideA > sideB && sideA > sideC)
                    {
                        if ((sideC * sideC) + (sideB * sideB) == (sideA * sideA))//И тут..
                        {
                            Result = (sideC + sideB) / 2;
                            Console.WriteLine("Треугольник прямоугольный. Площадь : " + Result);
                        }
                        else
                        {
                            double p = (sideA + sideB + sideC) / 2;
                            Result = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                            Console.WriteLine("Треугольник не прямоугольный: " + Result);
                        }
                    }
                    else if (sideB > sideA && sideB > sideC)
                    {
                        if ((sideA * sideA) + (sideC * sideC) == (sideB * sideB))//И даже тут..
                        {
                            Result = (sideA * sideC) / 2;
                            Console.WriteLine("Треугольник прямоугольный. Площадь : " + Result);
                        }
                        else
                        {
                            double p = (sideA + sideB + sideC) / 2;
                            Result = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                            Console.WriteLine("Треугольник не прямоугольный: " + Result);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Треугольник не существует!");
                }
            }
            else
            {
                Console.WriteLine("Одной из сторон не существует!");
            }

        }
        public static void squareC(double R)
        {
            if (R > 0)
            {
                double S = R * R * Math.PI;
                Console.WriteLine("Площадь круга: " + S);
            }
            else
                Console.WriteLine("Радиус меньше или равен нулю!");
        }
        /* Так же можно заменить тип функций на double и через return возвращать результат. 
         * Например, для .net веб-приложений :)
         * 
         */
    }
}
