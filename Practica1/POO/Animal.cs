using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.POO
{
    internal abstract class Animal
    {
        protected internal abstract bool HasFur { get; set; }
        protected internal abstract int LegNumber { get; set; }
        protected internal abstract string Name { get; set; }

        protected internal abstract void Eat();
        protected internal abstract void Sleep();
    }
}
