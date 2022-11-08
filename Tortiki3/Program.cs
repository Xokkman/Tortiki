using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tortiki3;

Console.WriteLine("  Заказ тортов в Ривьера, торты на Ваш выбор!");
Console.WriteLine("  Выберите параметр торта");
Console.WriteLine("  -----------------------");

Class1 forma1 = new Class1("  Круг",500);
Class1 forma2 = new Class1("  Квадрат", 500);
Class1 forma3 = new Class1("  Прямоугольник", 500);
Class1 forma4 = new Class1("  Сердечко", 700);

Class1 kolichestvokorzhik1 = new Class1("  1 корж", 200);
Class1 kolichestvokorzhik2 = new Class1("  2 коржа", 400);
Class1 kolichestvokorzhik3 = new Class1("  3 коржа", 600);
Class1 kolichestvokorzhik4 = new Class1("  4 коржа", 800);

Class1 size1 = new Class1("  Маленький (Диаметр - 18 см, 10 порций)", 1000);
Class1 size2 = new Class1("  Обычный (Диаметр - 20 см, 12 порций)", 1200);
Class1 size3 = new Class1("  Большой (Диаметр - 28 см, 26 порций)", 2000);

Class1 korzhi1 = new Class1("  Ванильный", 100);
Class1 korzhi2 = new Class1("  Шоколадный", 100);
Class1 korzhi3 = new Class1("  Карамельный", 150);
Class1 korzhi4 = new Class1("  Ягодный", 200);

Class1 shugar1 = new Class1("  Не с сахаром", 0);
Class1 shugar2 = new Class1("  Немного сахара", 100);
Class1 shugar3 = new Class1("  Много сахара", 150);

Class1 glaz1 = new Class1("  Шоколад", 100);
Class1 glaz2 = new Class1("  Ягоды", 200);

Console.WriteLine("  Цена:");
Console.WriteLine("  Ваш торт:");

Menu forma = new();
forma.Class1 = new List<Class1>()
{
    forma1,
    forma2,
    forma3,
    forma4,
};
forma.Name = "  Форма торта";

Menu korzhi = new();
korzhi.Class1 = new List<Class1>()
{
    korzhi1,
    korzhi2,
    korzhi3,
    korzhi4,
};
korzhi.Name = "  Вкус коржей";

Menu kolichestvokorzhik = new();
kolichestvokorzhik.Class1 = new List<Class1>()
{
    kolichestvokorzhik1,
    kolichestvokorzhik2,
    kolichestvokorzhik3,
    kolichestvokorzhik4,
};
kolichestvokorzhik.Name = "  Количество коржей";

Menu size = new();
size.Class1 = new List<Class1>()
{
   size1,
   size2,
   size3,
};
size.Name = "  Размер торта";

Menu shugar = new();
shugar.Class1 = new List<Class1>()
{
   shugar1,
   shugar2,
   shugar3,
};
shugar.Name = "  Сахар";

Menu glaz = new();
glaz.Class1 = new List<Class1>()
{
    glaz1,
    glaz2,
};
glaz.Name = "  Глазурь";

List<Menu> allMenus = new List<Menu>()
    {
        forma,
        size,
        korzhi,
        kolichestvokorzhik,
        shugar,
        glaz, 
    };

while (true)
{
    foreach (Menu item in allMenus)
    {
        Console.WriteLine(item.Name);
    }
    int position = strelka();
    Console.Clear();
    foreach (Class1 podPunkt in allMenus[position].Class1)
    {
        Console.WriteLine(podPunkt.Name);
    }
    strelka();
    Console.Clear();
}

static int strelka()
{
    var key = Console.ReadKey();
    int position = 1;
    while (key.Key != ConsoleKey.Enter)
    {
        ClearArrows();
        switch (key.Key)
        {
            case ConsoleKey.UpArrow:
                position--;
                if (position < 0)
                {
                    position++;
                }
                break;

            case ConsoleKey.DownArrow:
                position++;
                break;
        }
        Console.SetCursorPosition(0, position);
        Console.WriteLine("->");
        key = Console.ReadKey();
    }
    return position;
}

static void ClearArrows()
{
    for (int i = 0; i < 10; i++)
    {
        Console.SetCursorPosition(0, i);
        Console.WriteLine("  ");
    }
}