using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static ConsoleApp.ToolsClass;

namespace ConsoleApp
{
    class DeleteClass
    {
        public static void Delete()
        {
            int flag;
            do
            {
                Clear();
                WriteLine("Что нужно сделать?\n" +
                    "1 - удалить пользователя\n" +
                    "2 - удалить категорию\n" +
                    "3 - удалить компанию\n" +
                    "4 - удалить товар\n" +
                    "5 - удалить заказ (1 товар)\n" +
                    "6 - вернуться на главное меню");
                flag = int.Parse(ReadLine());
                Clear();
                switch (flag)
                {
                    case 1:
                        Delete_User();
                        break;
                    case 2:
                        Delete_Categ();
                        break;
                    case 3:
                        Delete_Comp();
                        break;
                    case 4:
                        Delete_Item();
                        break;
                    case 5:
                        Delete_Order();
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
