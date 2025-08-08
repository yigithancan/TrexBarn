using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrexBarn
{
    public class Cow : Animal
    {
        public override bool HasFood()
        {
            return ((Form1)System.Windows.Forms.Application.OpenForms[0]).StrawAmount > 0;
        }

    }
}

