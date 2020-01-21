using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using static System.Console;
using static ConsoleApp.ToolsClass;

namespace ConsoleApp
{
    class ReadClass
    {
        public static void Get()
        {
            int flag;
            do
            {
                Clear();
                WriteLine("Что нужно сделать?\n" +
                    "1 - вывести пользователей\n" +
                    "2 - вывести категории\n" +
                    "3 - вывести компании\n" +
                    "4 - вывести товары\n" +
                    "5 - вывести заказы (1 товар)\n" +
                    "6 - вернуться на главное меню");
                flag = int.Parse(ReadLine());
                Clear();
                switch (flag)
                {
                    case 1:
                        Get_User();
                        break;
                    case 2:
                        Get_Categ();
                        break;
                    case 3:
                        Get_Comp();
                        break;
                    case 4:
                        Get_Item();
                        break;
                    case 5:
                        Get_Order();
                        break;
                    case 6:
                        break;
                    default:
                        WriteLine("Введите рабочее значение");
                        break;
                }
            } while (flag != 6);
        }
    }
}
