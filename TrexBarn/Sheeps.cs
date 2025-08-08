using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrexBarn
{
    internal class Sheeps : Animal
    {
        public override bool HasFood()
        {
            return ((Form1)System.Windows.Forms.Application.OpenForms[0]).GrassAmount > 0;
        }
    }
}
