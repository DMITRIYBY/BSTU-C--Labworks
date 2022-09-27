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

        private string Gap
        {
            get
            {
                return gap;
            }
            set
            {
                gap = value;
            }
        }

        private double Air_Number
        {
            get
            {
                return air_number;
            }
            set
            {
                air_number = value;
            }
        }

        private string Plane_Type
        {
            get
            {
                return plane_type;
            }
            set
            {
                plane_type = value;
            }
        }

        private int[] Start_Time
        {
            get
            {
                return start_time;
            }
            set
            {
                start_time = value;
            }
        }

        private string Days
        {
            get
            {
                return days;
            }
            set
            {
                days = value;
            }
        }

        protected int ID
        {
            set
            {
                id = value;
            }
        }
    }
}
