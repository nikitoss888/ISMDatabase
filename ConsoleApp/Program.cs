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
        static void Main()
        {
            int flag;
            do
            {
                WriteLine("Выберите нужную функцию:\n" +
                    "1 - добавить запись\n" +
                    "2 - вывести записи\n" +
                    "3 - модифицировать запись\n" +
                    "4 - удалить запись\n" +
                    "5 - выход");
                flag = int.Parse(ReadLine());
                switch (flag)
                {
                    case 1:
                        CreateClass.Set();
                        break;
                    case 2:
                        ReadClass.Get();
                        break;
                    case 3:
                        UpdateClass.Update();
                        break;
                    case 4: 
                        DeleteClass.Delete();
                        break;
                    case 5:
                        WriteLine("До свидания!");
                        break;
                    default:
                        WriteLine("Выберите рабочее значение");
                        break;
                }
            } while (flag != 5);
        } 
    }
}
