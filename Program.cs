using System;
using System.Collections.Generic;
using R.R;

namespace trpo
{
    class Program
    {
     
        static void Main(string[] args)
        {
            SolvingLinearEquation linearEquation = new SolvingLinearEquation();
            SolvingQuadraticEquation quadraticEquation = new SolvingQuadraticEquation();


            Console.WriteLine("Введите 3 параметра a, b, c ");
            float a = 3, b = 8, c = 6;


            if (a == 0 && (b == 0 || c == 0))
                Console.WriteLine("Уравнения не существует!!!");

            else
            {
                if (a == 0)
                {
                    Console.WriteLine($"Введено уравнение {b}x + {c} = 0");
                    Console.WriteLine("Это линейное уравнение");
                    float result = linearEquation.Solve(b, c);

                    if (result == float.MaxValue)
                        Console.WriteLine("Уравнение не имеет корней!");

                    else
                        Console.WriteLine($"x = {result}");
                }
                else
                {
                    Console.WriteLine($"Введено уравнение {a}^2x + {b}x + {c} = 0");
                    Console.WriteLine("Это квадратное уравнение");
                    List<float> result = quadraticEquation.Solve(a, b, c);

                    if (result[0] == float.MaxValue && result[1] == float.MaxValue)
                        Console.WriteLine("Уравнение не имеет корней!");

                    else
                        Console.WriteLine($"x1 = {result[0]}\nx2 = {result[1]}");
                }    
            }

        }
    }
}
