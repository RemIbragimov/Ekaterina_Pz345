using System;
using System.Collections.Generic;
using System.Text;

namespace pz2._3
{
    class UndeliveredPackage:Package
    {
        private string reason;

        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        public UndeliveredPackage()
        {

        }

        public UndeliveredPackage(string _reason,string _nameDest, string _nameSor, string _addres, string _type) : base()
        {
            nameDest = _nameDest;
            nameSor = _nameSor;
            addres = _addres;
            type = _type;
            Weight = rnd.Next((int)0.1, 10);
            receiptDate = DateTime.Now.ToString();
            reason = _reason;
        }

        public override void GetPackageInfo()
        {
            Console.WriteLine($"\t!!!!!!НЕДОСТАВЛЕНЫЙ по причине {reason}");
            base.GetPackageInfo();
        }
    }
}
