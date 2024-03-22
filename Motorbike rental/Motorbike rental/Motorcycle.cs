using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorbike_rental
{
    internal class Fazzio : Vehicle
    {
        public Fazzio()
        {
            Name = "Fazzio";
            Brand = "Honda";
            CategoryType = Category.Scooter;
            ColorMotorcycle = Color.White;
            Cylindervolume = "มีปริมาตรกระบอกสูบ 125 ซีซี";
            Fueltype = "รองรับน้ำมันแก๊สโซฮอล์ E20";
            Rental_price_Day = 500;
            Rental_price_Month = 4500;
            NumberProducts = 3;
        }
        
    }

    internal class PCX150 : Vehicle
    {
        public PCX150()
        {
            Name = "PCX150";
            Brand = "Honda";
            CategoryType = Category.Big_Scooter;
            ColorMotorcycle = Color.Red;
            Cylindervolume = "มีปริมาตรกระบอกสูบ 149.3 ซีซี";
            Fueltype = "รองรับน้ำมันหลายประเภท ดังนี้ เบนซิน 91 , แก๊สโซฮอล์ 95 (E10) , แก๊สโซฮอล์ 91 ,เบนซิน 95";
            Rental_price_Day = 700;
            Rental_price_Month = 6500;
            NumberProducts = 2;
        }
    }

    internal class YZFR3 : Vehicle
    {
        public YZFR3()
        {
            Name = "YZF-R3";
            Brand = "Honda";
            CategoryType = Category.Big_Scooter;
            ColorMotorcycle = Color.Black;
            Cylindervolume = "มีปริมาตรกระบอกสูบ 321 ซีซี";
            Fueltype = "รองรับน้ำมันแก๊สโซฮอล์ E20 หรือเบนซินค่าออกเทน 91 ขึ้นไป";
            Rental_price_Day = 1100;
            Rental_price_Month = 12200;
            NumberProducts = 1;
        }
    }

    internal class XMAX : Vehicle
    {
        public XMAX()
        {
            Name = "X-MAX 300 ";
            Brand = "Honda";
            CategoryType = Category.Big_Scooter;
            ColorMotorcycle = Color.White;
            Cylindervolume = "มีปริมาตรกระบอกสูบ 292 ซีซี";
            Fueltype = "รองรับน้ำมันแก๊สโซฮอล์ แก๊สโซฮอล์ 95 (E10)";
            Rental_price_Day = 1100;
            Rental_price_Month = 12200;
            NumberProducts = 2;
        }
    }

}
