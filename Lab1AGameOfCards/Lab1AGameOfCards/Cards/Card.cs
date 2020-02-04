using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1AGameOfCards
{
    public abstract class Card
    {
        public int GetValue()
        {
            return Number * SuitNumber;
        }

        //protected: is useful when you want your class and all derived (child) classes to be able to access the method or variable,
        //but you don't want it to be public.
        public int Number { get; protected set; }

        public int SuitNumber { get; protected set; }

        public string SuitName { get; protected set; }

    }
}
