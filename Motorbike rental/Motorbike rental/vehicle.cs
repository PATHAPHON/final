using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorbike_rental
{
    public class Vehicle
    {

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
        
        public string name() { return Name; }
        public string brand() { return Brand; }
        public int Rental_price_DAY() { return Rental_price_Day; }
        public int Rental_price_MONTH() { return Rental_price_Month; }
        public string CylinderVolume() { return Cylindervolume; }
        public string FuelType() {  return Fueltype; }
        public int numberproducts() { return NumberProducts; }

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
