using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace HWshopOperatorReload
{
    internal class Program
    {
        class Shop
        {
            public static string _classifier = "Classification is \"InternetShop\"";
            public static uint _counerObjShop = 0;
            readonly string _nameShop;
            public double Square { get; set; }
            string _description;
            string _address;
            string _telephoneNumber;
            string _eMail;
            public Shop(string nameShop, string eMail = "_____@______.___", string description = " ", string address = " ", string telephoneNumber = "+7_________")
            {
                _nameShop = nameShop;
                _description = description;
                _address = address;
                _telephoneNumber = telephoneNumber;
                _eMail = eMail;
                _counerObjShop++;
            }
            //public string NameShop { get; set; }
            public string Description
            {
                get { return _description; }
                set { _description = value; }
            }
            public string Address
            {
                get { return _address; }
                set { _address = value; }
            }
            public string TelephoneNumber
            {
                get { return _telephoneNumber; }
                set { _telephoneNumber = value; }
            }
            public string EMail
            {
                get { return _eMail; }
                set { _eMail = value; }
            }
            public override string ToString()
            {
                return $"Name \"{_nameShop}\"\t" + $"Description:{_description}\t" + $"Address:{_address}\t" + $"Tel.:{_telephoneNumber}\t" + $"EMail:{_eMail}\t";
            }
            public static Shop operator +(Shop shop, double squareAdd)
            {
                shop.Square += squareAdd; 
                return shop;
            }
            public static Shop operator - (Shop shop, double squareSub)
            {
                shop.Square -= squareSub;
                return shop;
            }
            public static bool operator == (Shop shop1, Shop shop2)
            {
                return shop1.Square == shop2.Square; 
            }
            public static bool operator != (Shop shop1, Shop shop2)
            {
                return shop1.Square != shop2.Square; 
            }
            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public static bool operator > (Shop shop1, Shop shop2)
            {
                return shop1.Square > shop2.Square;
            }
            public static bool operator < (Shop shop, Shop shop1)
            {
                return shop.Square < shop1.Square;
            }
        }
        static void Main(string[] args)
        {
            Shop shop1 = new Shop("Adibos\\\\\\");
            Shop shop2 = new Shop("Abidos///"); 
            shop1.Square = 12.6;
            shop2.Square = 12.5;
            //WriteLine(shop1.Square);
            //shop1 += 0.78;
            //WriteLine($"{shop1.Square}");
            //shop1 -= 0.5;
            //WriteLine(shop1.Square);
            //if (shop1 == shop2) WriteLine("The shops is Equal!"); 
            //else WriteLine("Isn't Equal");
            //if (shop2.Equals(shop1)) WriteLine("The same ref to shops"); else WriteLine("Different ref to shops"); 
            //if (shop1 > shop2) WriteLine("shop1>shop2"); else WriteLine("shop1<shop2"); 
        }
    }
}
