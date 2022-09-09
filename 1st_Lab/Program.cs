using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Testing
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в первую лаборатоную работу!");
            Console.WriteLine("Номера заданий:");
            Console.WriteLine("1. Типы \n2. Строки \n3. Массивы \n4. Кортежи");
            Console.WriteLine("Выберите номер задания: ");
            string? Choose = Console.ReadLine();
            int intChoose = Convert.ToInt16(Choose);
            Console.WriteLine($"Вы выбрали задание номер: {intChoose}");
            if (intChoose >= 0 && intChoose <= 4)
            {
                switch (intChoose)
                {
                    case 1:
                        Variables();
                        Console.WriteLine("\n");
                        Main();
                        break;
                    case 2:
                        Strings();
                        Console.WriteLine("\n");
                        Main();
                        break;
                    case 3:
                        Arrays();
                        Main();
                        break;
                    case 4:
                        Typles();
                        Main();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введите корректное значение: 1-4.");
            }
        }

        static void Variables()
        {
            // Задание a:
            string name = "John";
            int age = 21;
            bool isWorking = true;
            double weight = 72.5;

            Console.WriteLine("Задание А:");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Работает?: {isWorking}");
            Console.WriteLine($"Вес: {weight}");

            // Задание b:
            int first = 15;
            byte first_to_byte = Convert.ToByte(first); //операция явного приведения int в byte с помощью Convert class

            double second = 3.14;
            int second_to_int = Convert.ToInt16(second); //операция явного приведения числа с плавающей точкой в целочисленный тип

            float third = 28234237;
            //int third_to_int = Convert.ToInt16(third);
            //Console.WriteLine(third_to_int);
            //операция выше вернет ошибку при явном приведеии, т.к число third больше максимального значения пренимаемого типом данных int16

            int third_to_int = (int)third; //данная операция НЕЯВНОГО присвоения вернет нужное нам число, т.к int32/64 может принимать число такого размера
            Console.WriteLine(third_to_int);
            Console.WriteLine("\n");

            // Задание c:
            //выполняем операция упаковки
            object to_box;
            to_box = 3.14; //упаковываем тип double => object

            //выполняем операция распаковки
            double from_box = (double)to_box; //распаковываем object => double

            // Задание c:
            Console.WriteLine("\n");
            var person = new 
            {
                Name = "Ivan",
                Ages = 25
            }; //объявляем неявно типизированную переменную содержащую несколько полей
            Console.WriteLine($"Имя: {person.Name}");
            Console.WriteLine($"Возраст: {person.Ages}");

            // Задание e:

            Nullable<int> i = null; //объявляем переменную типа Nullable, переменная может хранить значения null либо int. Переменная типа int ен может хранить зачения Null без объявления Nullable
      
            if (i.HasValue)
            {
                Console.WriteLine($"i is: {i}");
            }
            if(i == null)
            {
                Console.WriteLine($"i is a NULL");
            }

            // Задание f:

            //var task_f = "Ivan";
            //task_f = 25;
            /*данная операция приведет к ошибке, т.к несмотря на неопределенный тип данных var, значение уже присвоено.
             *Для выполнения подобной операции нужно использовать конструкцию из задания 'c' выше (строка 70-74)
            */

        }

        static void Strings()
        {
            // Задание a:

            string A = "A";
            string a = "a";

            if(A == a)
            {
                Console.WriteLine("Значения литералов не имеют отличий.");
            }
            else
            {
                Console.WriteLine("Значения литералов различаются!");
            }
            Console.WriteLine("Сравнение строк с помощью метода Compare: ");
            Console.WriteLine(String.Compare(A, a));

            // Задание b:

            string s1 = "Lorem ipsum dolor sit amet, ",
            s2 = "consectetur adipiscing elit",
            s3 = "<copied value>";

            
            string result = String.Concat(s1, s2);      //сцепление
            Console.WriteLine("- Concat: " + result);
            Console.WriteLine("\n- Split:");   // разделение строки на слова

            string[] words = result.Split(' ');
            foreach (string word in words)
                Console.WriteLine($"    <{word}>");

            result = result.Insert(10, "<inserted value>");   // вставки подстроки в заданную позицию
            Console.WriteLine("\n- Insert: " + result);

            result = result.Remove(10, 16);                 // удаление заданной подстроки
            Console.WriteLine("\n- Remove: " + result);
            Console.WriteLine("\n- Substring: " + result.Substring(0, 17)); // выделение подстроки

            char[] dest = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ',         // копирование
                'a', 'r', 'r', 'a', 'y',  ' ', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ',
                'a', 'r', 'r', 'a', 'y'};
            s3.CopyTo(0, dest, 4, s3.Length);
            Console.Write("\n- Copy: ");
            Console.WriteLine(dest);



            // Задание c:

            string test_string = "";

            if (string.IsNullOrEmpty(test_string))
            {
                Console.WriteLine("Строка пуста!");
            }

            // Задание d:

            StringBuilder hello = new StringBuilder("Привет, меня зовут  и я учусь в Гарварде!", 100); //создаем константную строку определенного размера
            Console.WriteLine("Введите ваше имя: "); //запрашиваем имя пользователя
            string? user_name = Console.ReadLine(); //считываем введенное имя в переменную, предположительного типа string
            hello.Insert(19, user_name); //вставляем нашу строку с именем в исходную строку на заранее указанную разработчиком позицию
            Console.WriteLine(hello); //выводим полученную строку после вставки в нее имени 
        }

        static void Arrays()
        {
            // Задание a:

            int[,] myArr = new int[4,4];

            Random ran = new Random(); //создаем переменную которая будет иметь рандомные значения

            for (int i = 0; i < 4; i++) //инициализируем массив
            {
                for (int j = 0; j < 4; j++)
                {
                    myArr[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }

            // Задание b:

            string[] Arr_ay = { "Hello ", " guys ", " i love ", " big ", " boobs"};
            Console.WriteLine($"Массив: {Arr_ay}, \n Его длина: {Arr_ay.Length}."); //выводим содержимое массива и длину

            string? position = Console.ReadLine();

            Arr_ay[Convert.ToInt16(position)].Replace(Arr_ay[Convert.ToInt16(position)], Console.ReadLine());

            // Задание c:

            double[][] steppedArr = new double[3][];
            steppedArr[0] = new double[2];
            steppedArr[1] = new double[3];
            steppedArr[2] = new double[4];

            for (int row = 0; row < steppedArr.Length; row++)
                for (int column = 0; column < steppedArr[row].Length; column++)
                {
                    Console.Write($"Enter element [{row}][{column}]: ");
                    steppedArr[row][column] = Double.Parse(Console.ReadLine());
                }

            Console.WriteLine("\n- Stepped array:\n");
            for (int row = 0; row < steppedArr.Length; row++)
            {
                for (int column = 0; column < steppedArr[row].Length; column++)
                    Console.Write($" {steppedArr[row][column]} ");
                Console.WriteLine();
            }

            // Задание d:

            var arr_str = new
            {
                array = new int[4],
                inizial = "My Squad Array"
            };
        }

        static void Typles()
        {
            var my_tuple = ((int)5, (string)"We have", "z", (string)"someone", (ulong)53343452);
            var my_tuple2 = ((int)6, (int)2343, "zxc", (string)"SOmeone", (double)53.343452);

            if (my_tuple.Item3.GetType() == typeof(string))
            {
                Console.WriteLine("It's true!");
            }
            
            //int final = my_tuple.Item1 + my_tuple2.Item1;
            Console.WriteLine($"Кортеж целиком: {my_tuple}"); // выводим кортеж целиком
            Console.WriteLine($"1,2 и 4-й элементы кортежа: {my_tuple.Item1}, {my_tuple.Item2}, {my_tuple.Item4}"); // выводим конкретный элемент кортежа по его индексу с помощью оператора Item
            Console.WriteLine($"\n- Tuple compare: {(my_tuple.Equals(my_tuple2) ? "Equal" : "Not equal")}"); // сравнение эквивалентов кортежей

            (int, int, int, char) func(int[] arr, string st) // задаем маску кортежа/локальная функция с условием из задания 5
            {
                return (arr.Max(), arr.Min(), arr.Sum(), st.First()); // возвращаем в кортеж полученные элементы
            }

            int[] array = { 1, 2, 3, 4, 5 }; // задаем массив
            Console.WriteLine("\n- Function call: " + func(array, "Hello world!"));

        }
    }
}