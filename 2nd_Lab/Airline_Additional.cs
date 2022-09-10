// совместимый (partial) класс содержащий проверку данных о рейсах

using System;
namespace Second_Lab
{
    partial class Airline
    {
        public bool Equals()
        {
            if (this.start_time[0] <= 24 && this.start_time[0] >= 0 && this.start_time[1] >= 0 && this.start_time[1] <= 60)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Время для {this.gap} указано некорректно!\n");
                return false;
            }
        }
    }
}

