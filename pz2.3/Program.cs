using System;

namespace pz2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Package p1 = new Package("Вика", "Рэм", "г.Екатеренбург", "Подарок");
            Package p2 = new Package("Арсений", "Тамара", "г.Тамбов", "Деньги");
            Package p3 = new Package("Лев", "Люда", "г.Оренбург", "Письмо");
            Package p4 = new Package("Катарина", "Анна", "г.Москва", "Деньги");
            UndeliveredPackage p5 = new UndeliveredPackage("ПОКА ЧТО В ПУТИ", "женя", "тоня", "г.Орск", "Автомобиль");
            UndeliveredPackage p6 = new UndeliveredPackage("ПОТЕРЯЛАСЬ НА СОРТИРОВКЕ", "Tom", "Вася", "г.Питер", "Подарок");

            p1.GetPackageInfo();
            p2.GetPackageInfo();
            p3.GetPackageInfo();
            p4.GetPackageInfo();
            p5.GetPackageInfo();
            p6.GetPackageInfo();

            Package.GetTotal();
        }
    }
}