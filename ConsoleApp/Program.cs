using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            do
            {
                WriteLine("Выберите нужную функцию:\n" +
                    "1 - добавить запись\n" +
                    "2 - вывести записи\n" +
                    "3 - выход");
                flag = int.Parse(ReadLine());
                switch (flag)
                {
                    case 1:
                        Set.set();
                        break;
                    case 2:
                        Get.get();
                        break;
                    case 3:
                        WriteLine("До свидания!");
                        break;
                    default:
                        WriteLine("Выберите рабочее значение");
                        break;
                }
            } while (flag != 3);
        } 
    }
}
