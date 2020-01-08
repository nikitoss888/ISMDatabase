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
                    "2 - прочесть запись\n" +
                    "3 - выход\n");
                flag = int.Parse(ReadLine());
                switch (flag)
                {
                    case 1:
                        Set.set();
                        break;
                    case 2:
                        break;
                    case 3:
                        WriteLine("До свидания!");
                        break;
                    default:
                        WriteLine("Выберите рабочее значение\n");
                        break;
                }
            } while (flag != 3);
        } 
    }
    class Set {
        public static void set()
        {
            int flag = 0;
            do
            {
                WriteLine("Что нужно сделать?\n" +
                    "1 - добавить пользователя\n" +
                    "2 - добавить категорию\n" +
                    "3 - добавить компанию\n" +
                    "4 - добавить товар\n" +
                    "5 - добавить заказ (1 товар)\n" +
                    "6 - вернуться на главное меню\n");
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
        static void Set_User()
        {
            using (DBModel db = new DBModel())
            {
                db.Users.Add(new User
                {
                    FirstName = local_set("Имя (от 3 до 50 символов): ", 3, 50),
                    SurName = local_set("Фамилия (от 3 до 50 символов): ", 3, 50),
                    SecondName = local_set("Отчество или второе имя (не обязательно, до 50)", 0, 50)
                });
                db.SaveChanges();
            }
        }
        static void Set_Categ()
        {
            using (DBModel db = new DBModel())
            {
                db.Categories.Add(new Category
                {
                    CatName = local_set("Название категории (от 3 до 10 символов): ", 3, 10),
                    CatDescrip = local_set("Описание категории (не обязательно, до 50 символов): ", 0, 50)
                });
                db.SaveChanges();
            }
        }
        static void Set_Comp()
        {
            using (DBModel db = new DBModel())
            {
                db.Companies.Add(new Company
                {
                    CompName = local_set("Название компании (от 3 до 10 символов): ", 3, 10),
                    CompDescrip = local_set("Описание компании (не обязательно, до 50 символов): ", 0, 50)
                });
                db.SaveChanges();
            }
        }
        static void Set_Item()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Categories.Any() && db.Companies.Any())
                {
                    db.Items.Add(new Item
                    {
                        ItemName = local_set("Название товара (от 3 до 10 символов): ", 3, 10),
                        ItemDescrip = local_set("Описание товара (не обязательно, до 50 символов): ", 0, 50),
                        ItemCategoryId = Category_Id(),
                        ItemCompanyId = Company_Id()
                    });
                    db.SaveChanges();
                }
                else WriteLine("Нет доступных компаний или категорий для обязательного выбора. Пожалуйста, добавьте новые записи.\n" +
                    "Вас будет выброшено обратно в подменю\n");
            }
        }
        static void Set_Order()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Users.Any() && db.Items.Any())
                {
                    db.Orders.Add(new Order { UserId = Users_Id(), ItemId = Item_Id() });
                    db.SaveChanges();
                }
                else WriteLine("Нет доступных пользователей или товаров для обязательного выбора. Пожалуйста, добавьте новые записи.\n" +
                    "Вас будет выброшено обратно в подменю\n");
            }
        }
        static string local_set(string instruction, int minimum, int maximum)
        {
            WriteLine(instruction);
            string result;
            do
            {
                result = ReadLine();
            } while (result.Length < minimum || result.Length > maximum);
            return result;
        }
        static int Category_Id()
        {
            WriteLine("Категория:");
            int id = 0;
            using (DBModel db = new DBModel())
            {
                for (int n = 1; n <= db.Categories.Count(); n++)
                {
                    WriteLine($"ID = {n}, Название: {db.Categories.Find(n).CatName}\n");
                }
                do
                {
                    WriteLine("Нужный ID = ");
                    id = int.Parse(ReadLine());
                } while (id < 1 || id > db.Categories.Count());
            }
            return id;
        }
        static int Company_Id()
        {
            WriteLine("Компания:");
            int id = 0;
            using (DBModel db = new DBModel())
            {
                for (int n = 1; n <= db.Companies.Count(); n++)
                {
                    WriteLine($"ID = {n}, Название: {db.Companies.Find(n).CompName}\n");
                }
                do
                {
                    WriteLine("Нужный ID = ");
                    id = int.Parse(ReadLine());
                } while (id < 1 || id > db.Companies.Count());
            }
            return id;
        }
        static int Users_Id()
        {
            WriteLine("Пользователь:");
            int id = 0;
            using (DBModel db = new DBModel())
            {
                for (int n = 1; n <= db.Users.Count(); n++)
                {
                    WriteLine($"ID = {n}, Полное имя: {db.Users.Find(n).FirstName} {db.Users.Find(n).SecondName} {db.Users.Find(n).SurName}\n");
                }
                do
                {
                    WriteLine("Нужный ID = ");
                    id = int.Parse(ReadLine());
                } while (id < 1 || id > db.Users.Count());
            }
            return id;
        }
        static int Item_Id()
        {
            WriteLine("Товар:");
            int id = 0;
            using (DBModel db = new DBModel())
            {
                for (int n = 1; n <= db.Items.Count(); n++)
                {
                    WriteLine($"ID = {n}, Название: {db.Items.Find(n).ItemName}\n");
                }
                do
                {
                    WriteLine("Нужный ID = ");
                    id = int.Parse(ReadLine());
                } while (id < 1 || id > db.Items.Count());
            }
            return id;
        }
    }
}
