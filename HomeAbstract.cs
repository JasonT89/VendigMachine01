using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendigMachine01
{
    abstract class DrinksAbstract
    {
        public Cash cash = new Cash();      
        public bool End = false;
        public static int a;
        public static int b;
        public static int c;
        public abstract void BuyDrinks();
        public abstract void ExamineDrinks();
        public abstract void UseDrinks();
    }

    abstract class FoodAbstract
    {
        public Cash cash = new Cash();
        public bool End = false;
        public static int a;
        public static int b;
        public static int c;
        public abstract void BuyFood();
        public abstract void ExamineFood();
        public abstract void UseFood();
    }

    abstract class PhoneAbstract
    {
        public Cash cash = new Cash();
        public bool End = false;
        public static int a;
        public static int b;
        public static int c;
        public abstract void BuyPhone();
        public abstract void ExaminePhone();
        public abstract void UsePhone();
    }



}
