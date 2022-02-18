using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Excepciones
{
    public class TestException : Exception
    {
        public TestException(string errorMessage) : base(errorMessage)
        {
            Console.WriteLine($"\n- EXCEPTION: {errorMessage} -");
        }

        public static void Fail()
        {
            throw new TestException("WHOOPSIES THIS IS AN EXCEPTION.");
        }

    }

}
