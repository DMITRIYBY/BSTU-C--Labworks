using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Lab
{

    partial class Airline
    {
        private string gap;
        private double air_number; // используется как ключ в методе Output_by_ID
        private string plane_type;
        private int[] start_time;
        private string days;
        protected int id;
        static string Owner;
        static int count;
       
        public override int GetHashCode()
        {
            return Convert.ToInt32(air_number * 3);
        }
        
        public Airline(string gap, double air_number, int[] start_time, string plane_type, string days = "Monday")
        {
            this.ID = air_number.GetHashCode();
            this.gap = gap;
            this.air_number = air_number;
            this.start_time = start_time;
            this.plane_type = plane_type;
            this.days = days;
            count++;
        }

        private Airline()
        {
            this.ID = 5;
        }
        static Airline(){
            Owner = "DMITRIYBY";
        }
        
        private void Output_Default()
        {
            if (Equals())
            {
                Console.WriteLine($"\nПункт назначения: {this.gap} \nНомер рейса: {this.air_number}\nВремя вылета: {this.start_time[0]}:{this.start_time[1]}\n Тип самолета: {this.plane_type}\n Дни: {this.days}\n Владелец: {Owner}");
                Count();
            }
        }
        static void Count()
        {
            Console.WriteLine($"Количество активных рейсов: {count}\n");
        }
        public void ToString()              // преопределение ToString()
        {
            Output_Default();
        }

        public void Output_by_ID(ref double air_number)
        {
            if (this.air_number.Equals(air_number))
            {
                Output_Default();
            }
        }

        public void Output_by_Gap(ref string gap)
        {
            if (this.gap.Equals(gap))
            {
                Output_Default();
            }
            else
            {
                Console.WriteLine("\nРейсов в данную точку нет, проверьте введённые данные!");
            }
        }
    }
}

