using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task250306
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee megacoffee = new Mega();
            megacoffee.name = "메가";
            megacoffee.Price = 2000;
            megacoffee.Beans = "아라비카 원두";
            megacoffee.Buy();
            megacoffee.Drink();

            Console.WriteLine();

            Coffee composecoffee = new Compose();
            composecoffee.name = "컴포즈";
            composecoffee.Price = 1800;
            composecoffee.Beans = "브라질 원두";
            composecoffee.Buy();
            composecoffee.Drink();

            Console.WriteLine();

            megacoffee.Attack(composecoffee);
            composecoffee.Attack(megacoffee);
        }
    }
}
