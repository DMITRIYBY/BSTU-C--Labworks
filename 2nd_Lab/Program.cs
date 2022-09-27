// Вариант 2, class Airline
using Second_Lab;

using System;
using System.Linq;

namespace Lab_Work_2
{
    abstract class Program
    {
        static void Main()
        {
            int[] time1 = new int[2] {21,50};
            int[] time2 = new int[2] {19,25};
            int[] time3 = new int[2] {13,45};
            int[] time4 = new int[2] {18,55};
            Airline sqt1 = new Airline("Miami", 1931378, time1, "Britten-Norman", "Monday");
            Airline sqt2 = new Airline("Moscow", 145768, time2, "Boeing", "Saturday");
            Airline sqt3 = new Airline("New-York", 2445768, time3, "Boeing","Tuesday");
            sqt1 = new Airline("Bankok", 1935378, time1, "Aerospace");
           
            Airline[] Info = new Airline[] {sqt1, sqt2, sqt3};

            //int count = Info.Length;

            var charter = new { gap = "Paris", air_number = 387653, plane_type = "Agusta", days = "Mon, Tue, Fri", id = 387653 * 3, start_time = time4 };
 
            Console.WriteLine("\nВыберите способ вывода: \n 1. Вывод всех рейсов.\n 2. Вывод по точке прибытия.\n 3. Вывод по номеру рейса.\n 4.Вывод анонимного типа.\n 5. Exit\n");
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
                        inf.ToString();
                    };
                    Main();
                    break;
                case 2:
                    Console.WriteLine("Введите точку назначения: ");
                    string CURRENT_GAP = Console.ReadLine();
                    foreach (Airline inf in Info)
                    {
                        inf.Output_by_Gap(ref CURRENT_GAP);
                    };
                    Main();
                    break;
                case 3:
                    Console.WriteLine("Введите номер рейса: ");
                    double CURRENT_NUMB = Convert.ToDouble(Console.ReadLine());
                    foreach (Airline inf in Info)
                    {
                        inf.Output_by_ID(ref CURRENT_NUMB);
                    };
                    Main();
                    break;
                case 4:
                    Console.WriteLine($"Анонимный тип: \nПункт назначения: {charter.gap} \nНомер рейса: {charter.air_number}\nВремя вылета: {charter.start_time[0]}:{charter.start_time[1]}\nТип самолета: {charter.plane_type}\nДни: {charter.days}");
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Main();
                    break;
            }
        }
    }
}
