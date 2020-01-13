using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static ConsoleApp.ToolsClass;

namespace ConsoleApp
{
    class CreateClass
    {
        public static void Set()
        {
            int flag;
            do
            {
                WriteLine("Что нужно сделать?\n" +
                    "1 - добавить пользователя\n" +
                    "2 - добавить категорию\n" +
                    "3 - добавить компанию\n" +
                    "4 - добавить товар\n" +
                    "5 - добавить заказ (1 товар)\n" +
                    "6 - вернуться на главное меню");
                flag = int.Parse(ReadLine());
                switch (flag)
                {
                    case 1:
                        Set_User();
                        break;
                    case 2:
                        Set_Categ();
                        break;
                    case 3:
                        Set_Comp();
                        break;
                    case 4:
                        Set_Item();
                        break;
                    case 5:
                        Set_Order();
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
