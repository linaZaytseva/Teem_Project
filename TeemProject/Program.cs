using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeemProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Dish> Dishes = new List<Dish>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Application.Run(new Form1());

            MealCategory bev = new MealCategory("Beverage");// Напитки
            MealCategory por = new MealCategory("Poridge&Breakfast");// Каша и завтраки
            MealCategory fru = new MealCategory("Fruit");
            MealCategory veg = new MealCategory("Vegetables");
            MealCategory fc = new MealCategory("First Course");
            MealCategory gar = new MealCategory("Garnish");
            MealCategory meat = new MealCategory("Entree");
            MealCategory sld = new MealCategory("Salad");
            MealCategory tst = new MealCategory("Toast");

            Dishes.Add(new Dish("Гречневая каша", 228, 8.6, 5.16, 40.21, por));
            Dishes.Add(new Dish("Манная каша", 234, 7.3, 6.54, 36.51, por));
            Dishes.Add(new Dish("Овсяная каша", 244, 9.24, 8.63, 34.14, por));
            Dishes.Add(new Dish("Рисовая каша", 232, 5.06, 5.99, 39.06, por));
            Dishes.Add(new Dish("Щи с мясом", 120, 9.58, 6.28, 6.89, fc));
            Dishes.Add(new Dish("Борщ", 78, 3.36, 4.02, 8.26, fc));
            Dishes.Add(new Dish("Куриный суп", 95, 4.62, 3.56, 10.89, fc));
            Dishes.Add(new Dish("Гороховый суп", 165, 8.6, 2.92, 26.5, fc));
            Dishes.Add(new Dish("Рассольник", 98, 2.79, 3.77, 14.03, fc));
            Dishes.Add(new Dish("Рыбный суп", 86, 8.83, 2.72, 6.39, fc));
            Dishes.Add(new Dish("Пюре на молоке и масле", 237, 3.93, 8.86, 35.22, gar));
            Dishes.Add(new Dish("Свиная отбивная", 217, 24.28, 12.68, 0, meat));
            Dishes.Add(new Dish("Гречка Отварная", 138, 3.7, 4.8, 21.91, gar));
            Dishes.Add(new Dish("Голубцы", 157, 5.96, 11.33, 8.38, gar));
            Dishes.Add(new Dish("Варёная курица", 231, 34.1, 9.71, 0, meat));
            Dishes.Add(new Dish("Рис Отварной", 139, 3.29, 0.42, 29.49, meat));
            Dishes.Add(new Dish("Жареная куриная грудка", 187, 33.44, 4.71, 0.51, meat));
            Dishes.Add(new Dish("Жареная картошка с грибами", 126, 1.94, 8.05, 12.69, gar));
            Dishes.Add(new Dish("Жареная семга", 178, 18.15, 11.09, 0, meat));
            Dishes.Add(new Dish("Варёная рыба", 125, 26.07, 1.35, 0, meat));
            Dishes.Add(new Dish("Жаркое из свинины", 210, 22.93, 12.4, 0, meat));
            Dishes.Add(new Dish("Капуста тушёноя с мясом", 117, 10.77, 4.91, 7.08, gar));
            Dishes.Add(new Dish("Бефстроганов", 296, 19.51, 19.03, 11.46, meat));
            Dishes.Add(new Dish("Куриная котлета", 214, 17.82, 9.68, 12.99, meat));
            Dishes.Add(new Dish("Говяжья котлета", 204, 13.15, 10.77, 12.71, meat));
            Dishes.Add(new Dish("Пюре на воде", 105, 1.89, 3.72, 16.51, gar));
            Dishes.Add(new Dish("Чай с сахаром", 47, 0.02, 0, 12.51, bev));
            Dishes.Add(new Dish("Чай с лимоном", 4, 0.24, 0, 1.09, bev));
            Dishes.Add(new Dish("Зелёный чай", 2, 0, 0, 0.47, bev));
            Dishes.Add(new Dish("Кофе с сахаром и молоком", 41, 0.42, 0.19, 9.56, bev));
            Dishes.Add(new Dish("Молоко 3,2 %", 59, 2.9, 3.2, 4.7, bev));
            Dishes.Add(new Dish("Кефир 1 %", 37, 3, 1, 4, bev));
            Dishes.Add(new Dish("Компот", 141, 1.39, 0.42, 35.43, bev));
            Dishes.Add(new Dish("Апельсиновый сок", 112, 1.74, 0.5, 25.79, bev));
            Dishes.Add(new Dish("Яблочный сок", 117, 0.15, 0.27, 28.97, bev));
            Dishes.Add(new Dish("Омлет", 114, 7.71, 8.62, 0.96, por));
            Dishes.Add(new Dish("Варёное яйцо", 77, 6.26, 5.28, 0.56, tst));
            Dishes.Add(new Dish("Бутерброд с колбасой", 275, 10.48, 11.46, 31.57, tst));
            Dishes.Add(new Dish("Бутерброд с сыром", 261, 9.1, 12.67, 27.6, tst));
            Dishes.Add(new Dish("Бутерброд с маслом", 152, 2.37, 9.15, 15.16, tst));
            Dishes.Add(new Dish("Овсяное печенье", 70, 0.8, 2.85, 10.31, tst));
            Dishes.Add(new Dish("Банан", 105, 1.29, 0.39, 26.95, fru));
            Dishes.Add(new Dish("Яблоко", 72, 0.36, 19.06, 26, fru));
            Dishes.Add(new Dish("Груша", 96, 0.63, 0.2, 25.66, fru));
            Dishes.Add(new Dish("Апельсин", 62, 1.23, 0.16, 15.39, fru));
            Dishes.Add(new Dish("Помидор", 22, 1.08, 0.25, 4.82, veg));
            Dishes.Add(new Dish("Огурец", 45, 1.96, 0.33, 10.93, veg));
            Dishes.Add(new Dish("Цезарь с курицей", 283, 15.5, 21.15, 8.2, sld));
            Dishes.Add(new Dish("Овощной салат", 22, 0.39, 1.69, 1.66, sld));
            Dishes.Add(new Dish("Оливье", 167, 5.82, 11.23, 11.01, sld));
            Dishes.Add(new Dish("Селёдка под шубой", 189, 5.03, 15.75, 7.21, sld));
            Dishes.Add(new Dish("Морковь по - корейски", 107, 0.78, 7.93, 9.05, sld));
            Dishes.Add(new Dish("Винегрет", 98, 0.77, 8.36, 5.35, sld));

            Application.Run(new Form1(Dishes));
        }
    }
    }
