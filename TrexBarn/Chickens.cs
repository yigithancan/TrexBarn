using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrexBarn
{
    public class Chicken : Animal
    {
        public override bool HasFood()
        {
            return ((Form1)System.Windows.Forms.Application.OpenForms[0]).BaitAmount > 0;
        }
    }
}

