using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Motorbike_rental
{
    public class Vehicle
    {
        //protected เป็น Access Modifier ชนิดหนึ่ง ใช้ควบคุมการเข้าถึงสมาชิกของ class (เช่น field, method)
        //สมาชิกที่ถูกประกาศด้วย protected จะสามารถเข้าถึงได้จาก: Class นั้นเอง Class ใดๆ ที่สืบทอด(inheritance) มาจาก class นั้น

        //Information hiding หรือ encapsulation ในภาษา C# คือหลักการเขียนโปรแกรมที่มุ่งเน้นไปที่การจำกัดการเข้าถึงโดยตรงไปยังข้อมูลภายในของ object หลักการนี้มุ่งเน้นไปที่การควบคุมวิธีการเข้าถึงและแก้ไขข้อมูลภายใน class
        protected string Name;
        protected string Brand;
        protected Image Pic;
        protected string Cylindervolume;
        protected string Fueltype;
        protected int Rental_price_Day;
        protected int Rental_price_Month;
        protected int NumberProducts;
        protected Category CategoryType;
        protected Color ColorMotorcycle;
        //รายละเอียดของ method:
        //public: เป็น Access Modifier ที่ทำให้ method นี้สามารถเข้าถึงได้จาก class ใดๆ
        //string: เป็น type ของค่าที่ method นี้ return
        //name(): เป็นชื่อ method
        public string name() { return Name; }
        public string brand() { return Brand; }
        public int Rental_price_DAY() { return Rental_price_Day; }
        public int Rental_price_MONTH() { return Rental_price_Month; }
        public string CylinderVolume() { return Cylindervolume; }
        public string FuelType() {  return Fueltype; }
        public int numberproducts() { return NumberProducts; }

        //Method กลุ่มคำสั่งที่ถูกกำหนดขึ้นเพื่อทำงานเฉพาะอย่าง มักถูกใช้เพื่อแบ่งงานออกเป็นส่วนย่อยๆ ช่วยให้โค้ดอ่านง่าย เข้าใจง่าย และสามารถนำกลับมาใช้ใหม่ได้
        //โค้ด public void decrease(int amount) เป็น method ในภาษา C# ที่ใช้ลดจำนวนสินค้า
        //public: เป็น Access Modifier ที่ทำให้ method นี้สามารถเข้าถึงได้จาก class ใดๆ
        //void: method นี้ไม่ return ค่าใดๆ
        //decrease: เป็นชื่อ method
        //(int amount): parameter ของ method นี้ type int


        public void decrease(int amount)
        {
            NumberProducts -= amount;
        }

        public void AddProducts(int amount1)
        {
            NumberProducts += amount1;
        }


        public Category categorytype
        {
            get { return CategoryType; }
            set { CategoryType = value; }
        }

        public Color colormotorcycle
        {
            get { return ColorMotorcycle; }
            set { ColorMotorcycle = value; }
        }

        //emum คือ ประเภทที่แจกแจง (enumerated type) หรือที่เรียกกันทั่วไปว่า enum เป็นชนิดข้อมูลที่ประกอบด้วยชุดของค่าคงที่ 
        //โค้ด public enum Category เป็น enum ในภาษา C# ที่ใช้ define ประเภทสินค้า (Category)
        public enum Category
        {
          Family, Sport_Family, Scooter, Big_Scooter, Sport_Bike, Sport_Touring, Touring_Bike, Naked_Bike, Dual_Purpose, Multi_Purpose, Enduro
        }

        public enum Color
        {
            Red , Black , Blue , Brown , Green , Gray , Orange , Pink , Purple , Silver , White , Yellow
        }

    }
}
