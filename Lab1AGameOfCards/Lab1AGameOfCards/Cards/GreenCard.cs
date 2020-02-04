﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1AGameOfCards.Cards
{
    class GreenCard : Card
    {
        //In c#, base keyword is used to access a base class members such as properties, methods, etc. in derived class.
        //https://www.tutlane.com/tutorial/csharp/csharp-base-keyword

        public GreenCard(int number) : base()
        {
            Number = number;
            SuitNumber = 3;
            SuitName = "Green";
        }
    }
}
