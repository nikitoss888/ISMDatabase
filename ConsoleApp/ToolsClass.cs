using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using static System.Console;

namespace ConsoleApp
{
    static class ToolsClass
    {
        public static string local_set(string instruction, int minimum, int maximum)
        {
            string result;
            do
            {
                WriteLine(instruction);
                result = ReadLine();
            } while (result.Length < minimum || result.Length > maximum);
            return result;
        }
        public static int Category_Id()
        {
            WriteLine("Категория:");
            int id = 0;
            using (DBModel db = new DBModel())
            {
                foreach (Category category in db.Categories)
                {
                    WriteLine($"ID = {category.Id}, Название: {category.CatName}");
                }
                do
                {
                    WriteLine("Нужный ID = ");
                    id = int.Parse(ReadLine());
                } while (Categ_Flag(id));
            }
            return id;
        }
        public static bool Categ_Flag(int id)
        {
            using (DBModel db = new DBModel())
            {
                foreach (Category category in db.Categories)
                {
                    if (id == category.Id)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static int Company_Id()
        {
            WriteLine("Компания:");
            int id = 0;
            using (DBModel db = new DBModel())
            {
                foreach (Company company in db.Companies)
                {
                    WriteLine($"ID = {company.Id}, Название: {company.CompName}");
                }
                do
                {
                    WriteLine("Нужный ID = ");
                    id = int.Parse(ReadLine());
                } while (Company_Flag(id));
            }
            return id;
        }
        public static bool Company_Flag(int id)
        {
            using (DBModel db = new DBModel())
            {
                foreach (Company company in db.Companies)
                {
                    if (id == company.Id)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static int Users_Id()
        {
            WriteLine("Пользователи:");
            int id = 0;
            using (DBModel db = new DBModel())
            {
                foreach (User user in db.Users)
                {
                    WriteLine($"ID = {user.Id}, Полное имя: {user.FirstName} {user.SecondName} {user.SurName}\n");
                }
                do
                {
                    WriteLine("Нужный ID = ");
                    id = int.Parse(ReadLine());
                } while (User_Flag(id));
            }
            return id;
        }
        public static bool User_Flag(int id)
        {
            using (DBModel db = new DBModel())
            {
                foreach (User user in db.Users)
                {
                    if (id == user.Id)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static int Item_Id()
        {
            WriteLine("Товар:");
            int id = 0;
            using (DBModel db = new DBModel())
            {
                foreach (Item item in db.Items)
                {
                    WriteLine($"ID = {item.Id}, Название: {item.ItemName}\n");
                }
                do
                {
                    WriteLine("Нужный ID = ");
                    id = int.Parse(ReadLine());
                } while (Item_Flag(id));
            }
            return id;
        }
        public static bool Item_Flag(int id)
        {
            using (DBModel db = new DBModel())
            {
                foreach (Item item in db.Items)
                {
                    if (id == item.Id)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool Order_Flag(int id)
        {
            using(DBModel db = new DBModel())
            {
                foreach(Order order in db.Orders)
                {
                    if (id == order.Id)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //----------------------------------------------------------------------------------------------------

        public static void Get_User()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Users.Any())
                {
                    WriteLine("\nДоступные пользователи:\n");
                    foreach (User user in db.Users)
                    {
                        WriteLine($"ID = {user.Id}, Полное имя: {user.FirstName} {user.SecondName} {user.SurName}\n");
                    }
                }
                else WriteLine("Записи не найдены");
            }
            WriteLine("\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Get_Categ()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Users.Any())
                {
                    WriteLine("\nДоступные категории:\n");
                    foreach (Category categ in db.Categories)
                    {
                        WriteLine($"ID = {categ.Id}, Название: {categ.CatName}, Описание: {categ.CatDescrip}\n");
                    }
                }
                else WriteLine("Записи не найдены");
            }
            WriteLine("\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Get_Comp()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Companies.Any())
                {
                    WriteLine("\nДоступные компании:\n");
                    foreach (Company company in db.Companies)
                    {
                        WriteLine($"ID = {company.Id}, Название: {company.CompName}, " +
                            $"Описание: {company.CompDescrip}\n");
                    }
                }
                else WriteLine("Записи не найдены");
            }
            WriteLine("\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Get_Item()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Items.Any())
                {
                    WriteLine("\nДоступные товары:\n");
                    foreach (Item item in db.Items)
                    {
                        WriteLine($"ID = {item.Id}, Название: {item.ItemName}, " +
                            $"Описание: {item.ItemDescrip}, " +
                            $"Категория: {item.Category.CatName}, " +
                            $"Компания: {item.Company.CompName}\n");
                    }
                }
                else WriteLine("Записи не найдены");
            }
            WriteLine("\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Get_Order()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Orders.Any())
                {
                    WriteLine("\nЗаказы:\n");
                    foreach (Order order in db.Orders)
                    {
                        WriteLine($"ID заказа = {order.Id}, " +
                            $"Пользователь: {order.User.FirstName} " +
                            $"{order.User.SecondName} " +
                            $"{order.User.SurName}, " +
                            $"Товар: {order.Item.ItemName}\n");
                    }
                }
                else WriteLine("Записи не найдены");
            }
            WriteLine("\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Set_User()
        {
            using (DBModel db = new DBModel())
            {
                db.Users.Add(new User
                {
                    FirstName = local_set("Имя (от 3 до 50 символов): ", 3, 50),
                    SurName = local_set("Фамилия (от 3 до 50 символов): ", 3, 50),
                    SecondName = local_set("Отчество или второе имя (не обязательно, до 50): ", 0, 50)
                });
                db.SaveChanges();
            }
            WriteLine("Пользователь добавлен.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Set_Categ()
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
            WriteLine("Категория добавлена.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Set_Comp()
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
            WriteLine("Компания добавлена.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Set_Item()
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
            WriteLine("Товар добавлен.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Set_Order()
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
            WriteLine("Заказ добавлен.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Upd_User()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Users.Any())
                {
                    int id;
                    Get_User();
                    do
                    {
                        WriteLine("Нужный ID = ");
                        id = int.Parse(ReadLine());
                    } while (User_Flag(id));
                    User selected = db.Users.Find(id);
                    selected.FirstName = local_set("Имя (от 3 до 50 символов): ", 3, 50);
                    selected.SurName = local_set("Фамилия (от 3 до 50 символов): ", 3, 50);
                    selected.SecondName = local_set("Отчество или второе имя (не обязательно, до 50): ", 0, 50);
                    db.SaveChanges();
                }
                else WriteLine("Записи не найдены");
            }
            WriteLine("Пользователь обновлен.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Upd_Categ()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Categories.Any())
                {
                    int id;
                    Get_Categ();
                    do
                    {
                        WriteLine("Нужный ID = ");
                        id = int.Parse(ReadLine());
                    } while (Categ_Flag(id));
                    Category selected = db.Categories.Find(id);
                    selected.CatName = local_set("Название категории (от 3 до 10 символов): ", 3, 10);
                    selected.CatDescrip = local_set("Описание категории (не обязательно, до 50 символов): ", 0, 50);
                    db.SaveChanges();
                }
                else WriteLine("Записи не найдены");
            }
            WriteLine("Категория обновлена.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Upd_Comp()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Companies.Any())
                {
                    int id;
                    Get_Comp();
                    do
                    {
                        WriteLine("Нужный ID = ");
                        id = int.Parse(ReadLine());
                    } while (Company_Flag(id));
                    Company selected = db.Companies.Find(id);
                    selected.CompName = local_set("Название компании (от 3 до 10 символов): ", 3, 10);
                    selected.CompDescrip = local_set("Описание компании (не обязательно, до 50 символов): ", 0, 50);
                    db.SaveChanges();
                }
                else WriteLine("Записи не найдены");
            }
            WriteLine("Компания обновлена.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Upd_Item()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Items.Any())
                {
                    int id;
                    Get_Item();
                    do
                    {
                        WriteLine("Нужный ID = ");
                        id = int.Parse(ReadLine());
                    } while (Item_Flag(id));
                    Item selected = db.Items.Find(id);
                    selected.ItemName = local_set("Название товара (от 3 до 10 символов): ", 3, 10);
                    selected.ItemDescrip = local_set("Описание товара (не обязательно, до 50 символов): ", 0, 50);
                    selected.ItemCategoryId = Category_Id();
                    selected.ItemCompanyId = Company_Id();
                    db.SaveChanges();
                }
                else WriteLine("Записи не найдены");
            }
            WriteLine("Товар обновлен.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Upd_Order()
        {
            using (DBModel db = new DBModel())
            {
                if (db.Orders.Any())
                {
                    int id;
                    Get_Order();
                    do
                    {
                        WriteLine("Нужный ID = ");
                        id = int.Parse(ReadLine());
                    } while (Order_Flag(id));
                    Order selected = db.Orders.Find(id);
                    selected.UserId = Users_Id();
                    selected.ItemId = Item_Id();
                    db.SaveChanges();
                }
                else WriteLine("Записи не найдены");
            }
            WriteLine("Заказ обновлен.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Delete_User()
        {
            using (DBModel db = new DBModel())
            {
                int id;
                Get_User();
                do
                {
                    WriteLine("Нужный ID = ");
                    id = int.Parse(ReadLine());
                } while (User_Flag(id));
                User selected = db.Users.Find(id);
                db.Users.Remove(selected);
                db.SaveChanges();
            }
            WriteLine("Пользователь удалён.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Delete_Categ()
        {
            using (DBModel db = new DBModel())
            {
                int id;
                Get_Categ();
                do
                {
                    WriteLine("Нужный ID = ");
                    id = int.Parse(ReadLine());
                } while (Categ_Flag(id));
                Category selected = db.Categories.Find(id);
                db.Categories.Remove(selected);
                db.SaveChanges();
            }
            WriteLine("Категория удалена.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Delete_Comp()
        {
            using (DBModel db = new DBModel())
            {
                int id;
                Get_Comp();
                do
                {
                    WriteLine("Нужный ID = ");
                    id = int.Parse(ReadLine());
                } while (Company_Flag(id));
                Company selected = db.Companies.Find(id);
                db.Companies.Remove(selected);
                db.SaveChanges();
            }
            WriteLine("Компания удалена.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Delete_Item()
        {
            using (DBModel db = new DBModel())
            {
                int id;
                Get_Item();
                do
                {
                    WriteLine("Нужный ID = ");
                    id = int.Parse(ReadLine());
                } while (Item_Flag(id));
                Item selected = db.Items.Find(id);
                db.Items.Remove(selected);
                db.SaveChanges();
            }
            WriteLine("Товар удалён.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
        public static void Delete_Order()
        {
            using (DBModel db = new DBModel())
            {
                int id;
                Get_Order();
                do
                {
                    WriteLine("Нужный ID = ");
                    id = int.Parse(ReadLine());
                } while (Order_Flag(id));
                Order selected = db.Orders.Find(id);
                db.Orders.Remove(selected);
                db.SaveChanges();
            }
            WriteLine("Товар удалён.\nНажмите любую кнопку для продолжения");
            ReadKey();
        }
    }
}
