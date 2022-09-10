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
        protected int ID;

        public override int GetHashCode()
        { 
            return Convert.ToInt32(air_number * 3);
        }
        public Airline(string gap, double air_number, int[] start_time)
        {
            //this.ID = Convert.ToString(air_number);
            this.ID = air_number.GetHashCode();
            this.gap = gap;
            this.air_number = air_number;
            this.start_time = start_time;
        }
        
        private void Output_Default()
        {
            if (Equals())
            {
                Console.WriteLine($"\nПункт назначения: {this.gap} \nНомер рейса: {this.air_number}\nВремя вылета: {this.start_time[0]}:{this.start_time[1]}");
            }
        }
        public void Output_All()
        {
            Output_Default();
        }
        public void Output_by_ID(double air_number)
        {
            if (this.air_number.Equals(air_number))
            {
                Output_Default();
            }
        }

        public void Output_by_Gap(string gap)
        {
            if (this.gap.Equals(gap))
            {
                Output_Default();
            }
            //else
            //{
            //    Console.WriteLine("\nРейсов в данную точку нет, проверьте введённые данные!");
            //}
        }
    }
}

