using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzada1.Excercises.Variance
{
    //Simple class hierarchy
    public class Person { }
    public class Worker : Person { }
    public class Student : Person { }
    public class Teacher : Worker { }

    //Variant Interface Definition
    public interface ICovariant<out T> { }
    public interface IContravariant<in T> { }
    
    public interface IInvariant<T> : ICovariant<T>, IContravariant<T> { }

    //Variant Interface Implementations
    public class Covariant<T> : ICovariant<T> { }
    public class Contravariant<T> : IContravariant<T> { }
    public class Invariant<T> : IInvariant<T> { }

    //Test in main program


    
}
