using System;
using System.Collections.Generic;
using System.Text;

namespace Del02
{
    //Sealed classes are used to restrict the inheritance feature of object oriented programming. Once a class is defined as a sealed class, this class cannot be inherited.
    //https://www.c-sharpcorner.com/article/sealed-class-in-C-Sharp/


    public sealed class Cons<TA> : List<TA>
    {
        public TA X { get; }
        public List<TA> Tail { get; }

        public Cons(TA x, List<TA> tail)
        {
            X = x;
            Tail = tail;
        }
    }
}
