using System;

namespace Sharp4
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите номер задания для проверки: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            int maximum;

            switch (choice)
            {
                case 1:
                    Tasks.GetSquare();
                    break;
                
                case 2:
                    maximum = Convert.ToInt32(Console.ReadLine());
                    Tasks.GetSum(maximum);
                    break;
                
                case 3:
                    maximum = Convert.ToInt32(Console.ReadLine());
                    Tasks.GetMultiply(maximum);
                    break;
                
                case 8:
                    Tasks.CheckDivideByThreeNotFive();
                    break;
                
                case 9:
                    Tasks.CheckDivide();
                    break;
                
                case 10:
                    Tasks.CheckDivideByTenFive();
                    break;
                
                
                default:
                    Console.WriteLine("хохлы");
                    break;
            }
        }
    }
}
