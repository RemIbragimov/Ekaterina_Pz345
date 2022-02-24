using System;
using System.Collections.Generic;
using System.Text;

namespace pz2._3
{
    class Package
    {
        public string nameDest;
        public string nameSor;
        public string addres;
        public string type;
        public string receiptDate;
        public int Weight;
        public Random rnd = new Random();
        public static int Packagee;
        public static int Weightt;

        public Package()
        {

        }
        public Package(string _nameDest, string _nameSor, string _addres, string _type, int _Weight)
        {
            nameDest = _nameDest;
            nameSor = _nameSor;
            addres = _addres;
            type = _type;
            if (Weight >= 0.01 && Weight <= 10)
                Weight = _Weight;
            else
                Weight = rnd.Next((int)0.01, 10);
            receiptDate = DateTime.Now.ToString();
            Packagee++;
            Weightt += Weight;
        }

        public Package(string _nameDest, string _nameSor, string _addres, string _type)
        {
            nameDest = _nameDest;
            nameSor = _nameSor;
            addres = _addres;
            type = _type;
            Weight = rnd.Next((int)0.01, 10);
            receiptDate = DateTime.Now.ToString();
            Packagee++;
            Weightt += Weight;
        }
        public static int GetPackagee()
        {
            return Packagee;
        }
        public static int GetWeightt()
        {
            return Weightt;
        }
        public virtual void GetPackageInfo()
        {            
            Console.WriteLine($"nameDest = {nameDest}, nameSor = {nameSor}, addres = {addres}, receiptDate = {receiptDate}, type = {type}, Weight={Weight}");
        }
        public static void GetTotal()
        {
            Console.WriteLine($"Всего посылок: {Package.GetPackagee()}" + $"\nОбщий вес посылок: {Package.GetWeightt()}");
        }
    }
}