using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrexBarn
{
    public abstract class Animal
    {
        public string Species { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public bool IsAlive { get; set; } = true;

        public int Produced { get; set; } = 0;
        public int Sold { get; set; } = 0;

        public DateTime BirthTime { get; set; } = DateTime.Now;
        public DateTime NextProductionTime { get; set; } = DateTime.Now;

        //  Üretim aralığı
        public int GetProductionInterval()
        {
            if (Age >= 1 && Age < 5) return 10;
            if (Age >= 5 && Age < 8) return 15;
            return -1;
        }

        //  Üretim yapabilme kontrolü
        public virtual bool CanProduce()
        {
            return IsAlive && Age >= 1 && Age < 8 && HasFood();
        }

        //  Besin kontrolü (alt sınıflar override edecek)
        public virtual bool HasFood()
        {
            return true;
        }

        //  Yaş hesaplama ve ölüm kontrolü
        public void UpdateAge()
        {
            int newAge = (int)((DateTime.Now - BirthTime).TotalSeconds / 15);
            if (newAge > Age)
            {
                Age = newAge;
            }

            if (IsAlive && Age >= 10)
            {
                IsAlive = false;
            }
        }
    }
}
