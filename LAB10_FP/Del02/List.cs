using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Del02
{
    public abstract class List<TA>
    {
        //Mutating meathod:
        public static List<TA> Init(params TA[] a)
        {
            // If the list is empyty a empty Nil<TA> object is returned.
            if(a.Length == 0)
            {
                return Nil<TA>.GetNil();
            }
            // If the List isn't empty the new Cons object is called recursive, with the function Init.
            // This Creates a nesed object, whith index 0 assigned to Cons' X and the rest of the array(index 1 to end) to Cons' tail,
            // this tail then consists of a new Cons object with the new index 0(In the original Array index 1) is assigned to X and the 
            // rest is assigned to the tail, which again consists of a new Cons' object.
            return new Cons<TA>(a[0], Init(a.Skip(1).ToArray()));
        }

        // Add element to the start of the list.
        // Lambda function since we only return the content of another function.
        public static List<TA> SetHead(List<TA> l, TA element) => new Cons<TA>(element, l);

        // A function that drops the all indexes up to index n for list l. The List l is already a nested object List/Cons.
        public static List<TA> Drop(List<TA> l, int n)
        {
            // If the given list is empyty a empty Nil<TA> object is returned.
            if (l is Nil<TA>)
            {
                return Nil<TA>.GetNil();
            }
            // If the given index is less than or equal to 0 then the list is just returned as it was given.
            if (n <= 0)
            {
                return l;
            }

            // l is a nested cons object and that way we can drop the first index by only returning the tail.
            // By then decrementing the element and calling Drop recursive we remove all indexes up to n.
            var cons = (Cons<TA>)l;
            return Drop(cons.Tail, n - 1);
        }

        //The f parameter is a function of type Func<TA, bool>. This allows for the caller to pass in the functionality 
        //that determines which items should be included in the result and which one should be excluded. In C# functions can return other functions.
        //http://functionalprogrammingcsharp.com/higher-order-functions
        public static List<TA> DropWhile(List<TA> l, Func<TA, bool> f)
        {
            // If the given list is empyty a empty Nil<TA> object is returned.
            if (l is Nil<TA>)
            {
                return Nil<TA>.GetNil();
            }

            var cons = (Cons<TA>)l;
            if (f(cons.X))
            {
                DropWhile(cons.Tail, f);
            }
            return l;
        }
    }
}
