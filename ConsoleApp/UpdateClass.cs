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
    class UpdateClass
    {
        public static void Update()
        {
            int flag;
            do
            {
                Clear();
                WriteLine("Что нужно сделать?\n" +
                    "1 - модифицировать пользователя\n" +
                    "2 - модифицировать категорию\n" +
                    "3 - модифицировать компанию\n" +
                    "4 - модифицировать товар\n" +
                    "5 - модифицировать заказ (1 товар)\n" +
                    "6 - вернуться на главное меню");
                flag = int.Parse(ReadLine());
                Clear();
                switch (flag)
                {
                    case 1:
                        Upd_User();
                        break;
                    case 2:
                        Upd_Categ();
                        break;
                    case 3:
                        Upd_Comp();
                        break;
                    case 4:
                        Upd_Item();
                        break;
                    case 5:
                        Upd_Order();
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
