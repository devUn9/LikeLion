using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task250306
{
    public abstract class Coffee
    {
        public string name;
        public int Price { get; set; }
        public string Beans { get; set; }

        public abstract void Buy();
        public abstract void Drink();
        public abstract void Attack(Coffee target);

    }
}
