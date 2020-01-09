using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using static System.Console;

namespace ConsoleApp
{
    class Get
    {
        public static void get()
        {
            int flag = 0;
            do
            {
                WriteLine("Что нужно сделать?\n" +
                    "1 - вывести пользователей\n" +
                    "2 - вывести категориb\n" +
                    "3 - вывести компаниb\n" +
                    "4 - вывести товарs\n" +
                    "5 - вывести заказs (1 товар)\n" +
                    "6 - вернуться на главное меню");
                flag = int.Parse(ReadLine());
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
        static void Get_User()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Users.Any())
                {
                    WriteLine($"Доступны пользователи:");
                    int max = db.Users.Count();
                    for (int n = 1; n <= max; n++)
                    {
                        WriteLine($"ID = {db.Users.Find(n).Id}, Полное имя: {db.Users.Find(n).FirstName} {db.Users.Find(n).SecondName} {db.Users.Find(n).SurName}");
                    }
                }
                else WriteLine("Записи не найдены");
            }
        }
        static void Get_Categ()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Users.Any())
                {
                    WriteLine($"Доступны категории:");
                    int max = db.Categories.Count();
                    for (int n = 1; n <= max; n++)
                    {
                        WriteLine($"ID = {db.Categories.Find(n).Id}, Название: {db.Categories.Find(n).CatName}, Описание: {db.Categories.Find(n).CatDescrip}");
                    }
                }
                else WriteLine("Записи не найдены");
            }
        }
        static void Get_Comp()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Companies.Any())
                {
                    WriteLine($"Доступны компании:");
                    int max = db.Companies.Count();
                    for (int n = 1; n <= max; n++)
                    {
                        WriteLine($"ID = {db.Companies.Find(n).Id}, Название: {db.Companies.Find(n).CompName}, " +
                            $"Описание: {db.Companies.Find(n).CompDescrip}");
                    }
                }
                else WriteLine("Записи не найдены");
            }
        }
        static void Get_Item()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Items.Any())
                {
                    WriteLine($"Доступны пользователи:");
                    int max = db.Items.Count();
                    for (int n = 1; n <= max; n++)
                    {
                        WriteLine($"ID = {db.Items.Find(n).Id}, Название: {db.Items.Find(n).ItemName}, " +
                            $"Описание: {db.Items.Find(n).ItemDescrip}, " +
                            $"Категория: {db.Categories.Find(db.Items.Find(n).ItemCategoryId).CatName}, " +
                            $"Компания: {db.Companies.Find(db.Items.Find(n).ItemCompanyId).CompName}");
                    }
                }
                else WriteLine("Записи не найдены");
            }
        }
        static void Get_Order()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Orders.Any())
                {
                    WriteLine($"Заказы:");
                    int max = db.Orders.Count();
                    for (int n = 1; n <= max; n++)
                    {
                        WriteLine($"ID заказа = {db.Orders.Find(n).Id}, " +
                            $"Пользователь: {db.Users.Find(db.Orders.Find(n).UserId).FirstName} " +
                            $"{db.Users.Find(db.Orders.Find(n).UserId).SecondName} " +
                            $"{db.Users.Find(db.Orders.Find(n).UserId).SurName}, " +
                            $"Товар: {db.Items.Find(db.Orders.Find(n).ItemId).ItemName}");
                    }
                }
                else WriteLine("Записи не найдены");
            }
        }
    }
}
