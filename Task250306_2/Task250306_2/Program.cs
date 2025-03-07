using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task250306_2
{
    class INFO
    {
        public string BrandName { get; set; }
        public string MenuName { get; set; }
        public int Price { get; set; }
        public float Rating { get; set; }

       
    }
    
    interface ICoffee
    {
        void GetBrand();


        void GetMenu();


        void Attack(string target);
       
    }
    class Starbucks : INFO
    {
        public void GetBrand()
        {
            Console.WriteLine($"브랜드 : {BrandName}");
        }

        public void GetMenu()
        {
            Console.WriteLine($"메뉴 : {MenuName}, 가격 : {Price}, 평점 : {Rating}");
        }

        public void Attack(string target)
        {
            Console.WriteLine($"{BrandName}(이/가) {target}(은/는) 맛이 없다고 소문냅니다.");
        }
    }
    class Mega : INFO
    {
        public void GetBrand()
        {
            Console.WriteLine($"브랜드 : {BrandName}");
        }

        public void GetMenu()
        {
            Console.WriteLine($"메뉴 : {MenuName}, 가격 : {Price}, 평점 : {Rating}");
        }

        public void Attack(string target)
        {
            Console.WriteLine($"{BrandName}(이/가) {target}(은/는) 맛이 없다고 소문냅니다.");
        }
    }
    class Compose : INFO
    {
        public void GetBrand()
        {
            Console.WriteLine($"브랜드 : {BrandName}");
        }

        public void GetMenu()
        {
            Console.WriteLine($"메뉴 : {MenuName}, 가격 : {Price}, 평점 : {Rating}");
        }

        public void Attack(string target)
        {
            Console.WriteLine($"{BrandName}(이/가) {target}(은/는) 맛이 없다고 소문냅니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Starbucks starbucks = new Starbucks
            {
                BrandName = "스타벅스",
                MenuName = "카페라떼",
                Price = 5200,
                Rating = 4.5f
            };

            Mega mega = new Mega
            {
                BrandName = "메가커피",
                MenuName = "딸기라떼",
                Price = 3500,
                Rating = 4.4f
            };

            Compose compose = new Compose
            {
                BrandName = "컴포즈커피",
                MenuName = "아이스아메리카노",
                Price = 1800,
                Rating = 3.9f
            };

            starbucks.GetBrand();
            starbucks.GetMenu();
            Console.WriteLine();

            mega.GetBrand();
            mega.GetMenu();
            Console.WriteLine();

            compose.GetBrand();
            compose.GetMenu();
            Console.WriteLine();

            mega.Attack(compose.BrandName);
        }
    }
}
