using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsklHm
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ex1
            /*            Passport pass1 = new Passport();
                        try
                        {
                            Console.Write("Введите имя владельца пасспорта:");
                            pass1.Name = Console.ReadLine();
                            if (pass1.Name == "" || pass1.Name == "Name" || pass1.Name == "admin")
                            {
                                throw new Exception("Введите имя владельца пасспорта!");
                            }
                            Console.Write("Введите номер пасспорта:");
                            pass1.numpass = Console.ReadLine();
                            if (pass1.Name == "" || pass1.Name == "Name" || pass1.Name == "admin")
                            {
                                throw new Exception("Введите номер пасспорта!");
                            }
                            Console.Write("Введите дату выдачи пасспорта:");
                            pass1.date = Console.ReadLine();
                            if (pass1.Name == "" || pass1.Name == "Name" || pass1.Name == "admin")
                            {
                                throw new Exception("Введите дату выдачи пасспорта!");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);

                        }
                        Console.Write(pass1);
                        Console.ReadLine();*/
            #endregion
            #region Ex2
            string arr;
            string numb = "><";
            int num1, num2,a=0;
            Console.Write("Введите выражение:");
            arr = Console.ReadLine();
            int result=0;
            int[] numbers = arr.Split('>', '<').Select(snum => int.Parse(snum)).Where(n => n != 0).ToArray();
            for(int i = 0; i < arr.Length; i++)
            {
                if ((arr[i]) == numb[0]) {
                    if(numbers[0] > numbers[1]) {
                        result = 1;
                    }
                    else { result = 0; };

                }
                if ((arr[i]) == numb[1])
                {
                    if (numbers[0] < numbers[1])
                    {
                        result = 1;
                    }
                    else { result = 0; };
                }
                
            }
            switch (result) {
                case 0:
                    Console.Write("False");
                    break;
                case 1:
                    Console.Write("True");
                    break;
            };
            Console.ReadLine();
            #endregion
        }
    }
}
