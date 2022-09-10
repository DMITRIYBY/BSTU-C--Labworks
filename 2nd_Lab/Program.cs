// Вариант 2, class Airline
using Second_Lab;

using System;
using System.Linq;

namespace Lab_Work_2
{
    partial class Program
    {
        static void Main()
        {
            int[] time1 = new int[2] {21,50};
            int[] time2 = new int[2] {19,30};
            int[] time3 = new int[2] {13,00};
            Airline sqt1 = new Airline("Singapoore", 1931378, time1);
            Airline sqt2 = new Airline("Moscow", 145768, time2);
            Airline sqt3 = new Airline("New-York", 2445768, time3);
            sqt1 = new Airline("Bankok", 1935378, time1);
           
            Airline[] Info = new Airline[] {sqt1, sqt2, sqt3};
            
            int count = Info.Length;


            Console.WriteLine("\nВыберите способ вывода: \n 1. Вывод всех рейсов.\n 2. Вывод по точке прибытия.\n 3. Вывод по номеру рейса.\n 4. Exit\n");
            int choose = 0;
            try
            {
                choose = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введите значение в диапазоне 1-4!");
            }

            switch (choose)
            {
                case 1:
                    foreach (Airline inf in Info)
                    {
                        inf.Output_All();
                    };
                    Main();
                    break;
                case 2:
                    Console.WriteLine("Введите точку назначения: ");
                    string CURRENT_GAP = Console.ReadLine();
                    foreach (Airline inf in Info)
                    {
                        inf.Output_by_Gap(CURRENT_GAP);
                    };
                    Main();
                    break;
                case 3:
                    Console.WriteLine("Введите номер рейса: ");
                    double CURRENT_NUMB = Convert.ToDouble(Console.ReadLine());
                    foreach (Airline inf in Info)
                    {
                        inf.Output_by_ID(CURRENT_NUMB);
                    };
                    Main();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Main();
                    break;
            }

            
        }
    }
}
