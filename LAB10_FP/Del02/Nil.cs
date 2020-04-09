using System;
using System.Collections.Generic;
using System.Text;

namespace Del02
{
    //Sealed classes are used to restrict the inheritance feature of object oriented programming. Once a class is defined as a sealed class, this class cannot be inherited.
    //https://www.c-sharpcorner.com/article/sealed-class-in-C-Sharp/

    // Class That returnes a empty new nill object that is an empty list.
    public sealed class Nil<TA> : List<TA>
    {
        private static readonly Nil<TA> instance_ = new Nil<TA>();
        
        private Nil() { }

        // Lambda expression that returnes A new Nill Object of the Type TA.
        public static Nil<TA> GetNil() => instance_;
    }
}
