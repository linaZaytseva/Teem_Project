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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            MealCategory bev = new MealCategory("Beverage");
            MealCategory por = new MealCategory("Poridge&Breakfast");
            MealCategory fru = new MealCategory("Fruit");
            MealCategory veg = new MealCategory("Vegetables");
            MealCategory fc = new MealCategory("First Course");
            MealCategory gar = new MealCategory("Garnish");
            MealCategory meat = new MealCategory("Entree");
            MealCategory sld = new MealCategory("Salad");
            MealCategory tst = new MealCategory("Toast");


            Dish d1 = new Dish("Гречневая каша", 228, 8.6, 5.16, 40.21, por );
            Dish d2 = new Dish("Манная каша", 234, 7.3, 6.54, 36.51, por);
            Dish d3 = new Dish("Овсяная каша", 244, 9.24, 8.63, 34.14, por);
            Dish d4 = new Dish("Рисовая каша", 232, 5.06, 5.99, 39.06, por);
            Dish d5 = new Dish("Щи с мясом", 120, 9.58, 6.28, 6.89, fc);
            Dish d6 = new Dish("Борщ", 78, 3.36, 4.02, 8.26, fc);
            Dish d7 = new Dish("Куриный суп", 95, 4.62, 3.56, 10.89, fc);
            Dish d8 = new Dish("Гороховый суп", 165, 8.6, 2.92, 26.5, fc);
            Dish d9 = new Dish("Рассольник", 98, 2.79, 3.77, 14.03, fc);
            Dish d10 = new Dish("Рыбный суп", 86, 8.83, 2.72, 6.39, fc);
            Dish d11 = new Dish("Пюре на молоке и масле", 237, 3.93, 8.86, 35.22, gar);
            Dish d12 = new Dish("Свиная отбивная", 217, 24.28, 12.68, 0, meat);
            Dish d13 = new Dish("Гречка Отварная", 138, 3.7, 4.8, 21.91, gar);
            Dish d14 = new Dish("Голубцы", 157, 5.96, 11.33, 8.38, gar);
            Dish d15 = new Dish("Варёная курица", 231, 34.1, 9.71, 0, meat);
            Dish d16 = new Dish("Рис Отварной", 139, 3.29, 0.42, 29.49, meat);
            Dish d17 = new Dish("Жареная куриная грудка", 187, 33.44, 4.71, 0.51, meat);
            Dish d18 = new Dish("Жареная картошка с грибами", 126, 1.94, 8.05, 12.69, gar);
            Dish d19 = new Dish("Жареная семга", 178, 18.15, 11.09, 0, meat);
            Dish d20 = new Dish("Варёная рыба", 125, 26.07, 1.35, 0, meat);
            Dish d21 = new Dish("Жаркое из свинины", 210, 22.93, 12.4, 0, meat);
            Dish d22 = new Dish("Капуста тушёноя с мясом", 117, 10.77, 4.91, 7.08, gar);
            Dish d23 = new Dish("Бефстроганов", 296, 19.51, 19.03, 11.46, meat);
            Dish d24 = new Dish("Куриная котлета", 214, 17.82, 9.68, 12.99, meat);
            Dish d25 = new Dish("Говяжья котлета", 204, 13.15, 10.77, 12.71, meat);
            Dish d26 = new Dish("Пюре на воде", 105, 1.89, 3.72, 16.51, gar);
            Dish d27 = new Dish("Чай с сахаром", 47, 0.02, 0, 12.51, bev);
            Dish d28 = new Dish("Чай с лимоном", 4, 0.24, 0, 1.09, bev);
            Dish d29 = new Dish("Зелёный чай", 2, 0,0, 0.47, bev);
            Dish d30 = new Dish("Кофе с сахаром и молоком", 41, 0.42, 0.19, 9.56, bev);
            Dish d31 = new Dish("Молоко 3,2 %", 59, 2.9, 3.2, 4.7, bev);
            Dish d32 = new Dish("Кефир 1 %", 37, 3, 1, 4, bev);
            Dish d33 = new Dish("Компот", 141, 1.39, 0.42, 35.43, bev);
            Dish d34 = new Dish("Апельсиновый сок", 112, 1.74, 0.5, 25.79, bev);
            Dish d35 = new Dish("Яблочный сок", 117, 0.15, 0.27, 28.97, bev);
            Dish d36 = new Dish("Омлет", 114, 7.71, 8.62, 0.96, por);
            Dish d37 = new Dish("Варёное яйцо", 77, 6.26, 5.28, 0.56, tst);
            Dish d38 = new Dish("Бутерброд с колбасой", 275, 10.48, 11.46, 31.57, tst);
            Dish d39 = new Dish("Бутерброд с сыром", 261, 9.1, 12.67, 27.6, tst);
            Dish d40 = new Dish("Бутерброд с маслом", 152, 2.37, 9.15, 15.16, tst);
            Dish d41 = new Dish("Овсяное печенье", 70, 0.8, 2.85, 10.31, tst);
            Dish d42 = new Dish("Банан", 105, 1.29, 0.39, 26.95, fru);
            Dish d43 = new Dish("Яблоко", 72, 0.36, 19.06, 26, fru);
            Dish d44 = new Dish("Груша", 96, 0.63, 0.2, 25.66, fru);
            Dish d45 = new Dish("Апельсин", 62, 1.23, 0.16, 15.39, fru);
            Dish d46 = new Dish("Помидор", 22, 1.08, 0.25, 4.82, veg);
            Dish d47 = new Dish("Огурец", 45, 1.96, 0.33, 10.93, veg);
            Dish d48 = new Dish("Цезарь с курицей", 283, 15.5, 21.15, 8.2, sld);
            Dish d49 = new Dish("Овощной салат", 22, 0.39, 1.69, 1.66, sld);
            Dish d50 = new Dish("Оливье", 167, 5.82, 11.23, 11.01, sld);
            Dish d51 = new Dish("Селёдка под шубой", 189, 5.03, 15.75, 7.21, sld);
            Dish d52 = new Dish("Морковь по - корейски", 107, 0.78, 7.93, 9.05, sld);
            Dish d53 = new Dish("Винегрет", 98, 0.77, 8.36, 5.35, sld);
            
        }
    }
    }
