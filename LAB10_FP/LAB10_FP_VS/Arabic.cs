using System;
using System.Collections.Generic; //For KeyValuePair


namespace LAB10_FP_VS
{
    // Vi har ingen states ud over det som denne bliver oprettet med 
    public class Arabic
    {
        // Number er readnoly da den kun har en Get metode. Derfor har man ikke nogle sideeffekter fra at kunne ændre på værdien udefra et ukendt sted.
        public int Number { get; }

        public Arabic(int number)
        {
            Number = number;
        }

        //Her retunere vi en ny string og holder derved ikke nogle states hvilket vil sige at den er imutable.
        public string ToRoman()
        {
            var number = Number;
            var roman = "";
            foreach(var numerial in GetRomAraList())
            {
                // Compares the number with the values in GetRomAraList
                // And Adds the Roman Value To a String while substracting
                // the coresponding value from the original number, until the
                // value have been translated.
                while(number >= numerial.Value)
                {
                    roman = roman + numerial.Key;
                    number -= numerial.Value;
                }

            }
            return roman;
        }


        // Rerunere en ny liste af KeyValuePair's altså holder denne ingen states og er imutable.
        public List<KeyValuePair<string, int>> GetRomAraList()
        {
            // Must be in decending order
            return new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>("M",1000),
                new KeyValuePair<string, int>("CM",900),
                new KeyValuePair<string, int>("D",500),
                new KeyValuePair<string, int>("CD",400),
                new KeyValuePair<string, int>("C",100),
                new KeyValuePair<string, int>("XC",90),
                new KeyValuePair<string, int>("L",50),
                new KeyValuePair<string, int>("XL",40),
                new KeyValuePair<string, int>("X",10),
                new KeyValuePair<string, int>("IX",9),
                new KeyValuePair<string, int>("V",5),
                new KeyValuePair<string, int>("IV",4),
                new KeyValuePair<string, int>("I", 1),
            };
        }
    }
}