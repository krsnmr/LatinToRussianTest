using System;
using System.Collections.Generic;
using System.Text;

namespace LatinToRussianTest
{
    internal class Transliterator
    {
        //private static readonly string rus1 = "а б в г д е ё ж з и й к л м н о п р с т у ф х ц ч ш щ ъ ы ь э ю я";
        //private readonly string russianAlphabetUppercase = "А Б В Г Д Е Ё Ж З И Й К Л М Н О П Р С Т У Ф Х Ц Ч Ш Щ Ъ Ы Ь Э Ю Я";
        //private readonly string expectedLowercase = "a b v g d e yo zh z i y k l m n o p r s t u f kh ts ch sh shch \" y ' e yu ya";
        //private readonly string expectedUppercase = "A B V G D E Yo Zh Z I Y K L M N O P R S T U F Kh Ts Ch Sh Shch \" Y ' E Yu Ya";



        public static string Conv(string letters)
        {
            var rus1 = "";
            var rusCahrs = rus1.ToCharArray();
            var result = new StringBuilder();
            foreach (var letter in letters)
            {
                try
                {
                    result.Append(ConvertedLetters[letter]);
                }
                catch (KeyNotFoundException)
                {
                    result.Append(letter);
                }

            }
            return result.ToString();
        }

        public static char[] GetChars(string letters)
        {
            return letters.ToCharArray();
        }

        public static string GetRusLetter(string lat)
        {
            var res = lat;
            switch (lat)
            {
                case "a":
                    return "a";
                case "y":
                    return "й";
                default:
                    return lat;
            }
        }

        public static string[] SplitByLetters(string word)
        {
            var strAr = new string[] { };
            var charAr = word.ToCharArray();

            // если a --> a
            // если y --> то возможно й, ё-yo, ю-yu, я-ya  
            // если латинская буква быть 

            for (int i = 0; i < charAr.Length; i++)
            {

            }

            return strAr;
        }


        private static readonly Dictionary<string, char> ConvertedLettersBack = new Dictionary<string, char>
        {
            { "a",'а'},
            { "b",'б'},
            { "v",'в'},
            { "g",'г'},
            { "d",'д'},
            { "e",'е'},
            { "i",'и'},
            { "k",'к'},
            { "l",'л'},
            { "m",'м'},
            { "n",'н'},
            { "o",'о'},
            { "p",'п'},
            { "r",'р'},
            { "t",'т'},
            { "u",'у'},
            { "f",'ф'},
            { "h",'х'},


            { "j",'ъ'},
            { "y",'ы'},
            { "'",'ь'},
            { "e",'э'},
          

            /**/
            {"y" ,'й'  },
            {"yo",'ё'  },
            {"yu",'ю'  },
            {"ya",'я'  },


            {"z"  ,'з'},
            {"zh" ,'ж'},
            {"c"  ,'ц'},
            {"ch" ,'ч'},
            {"s"  ,'с'},
            {"sh" ,'ш'},
            {"sch",'щ'},

        };

        private static readonly Dictionary<char, string> ConvertedLetters = new Dictionary<char, string>
        {
            {'а', "a"},
            {'б', "b"},
            {'в', "v"},
            {'г', "g"},
            {'д', "d"},
            {'е', "e"},
            {'ё', "yo"},
            {'ж', "zh"},
            {'з', "z"},
            {'и', "i"},
            {'й', "y"},
            {'к', "k"},
            {'л', "l"},
            {'м', "m"},
            {'н', "n"},
            {'о', "o"},
            {'п', "p"},
            {'р', "r"},
            {'с', "s"},
            {'т', "t"},
            {'у', "u"},
            {'ф', "f"},
            {'х', "h"},
            {'ц', "c"},
            {'ч', "ch"},
            {'ш', "sh"},
            {'щ', "sch"},
            {'ъ', "j"},
            {'ы', "i"},
            {'ь', "'"},
            {'э', "e"},
            {'ю', "yu"},
            {'я', "ya"},
            {'А', "A"},
            {'Б', "B"},
            {'В', "V"},
            {'Г', "G"},
            {'Д', "D"},
            {'Е', "E"},
            {'Ё', "Yo"},
            {'Ж', "Zh"},
            {'З', "Z"},
            {'И', "I"},
            {'Й', "Y"},
            {'К', "K"},
            {'Л', "L"},
            {'М', "M"},
            {'Н', "N"},
            {'О', "O"},
            {'П', "P"},
            {'Р', "R"},
            {'С', "S"},
            {'Т', "T"},
            {'У', "U"},
            {'Ф', "F"},
            {'Х', "H"},
            {'Ц', "C"},
            {'Ч', "Ch"},
            {'Ш', "Sh"},
            {'Щ', "Sch"},
            {'Ъ', "\""},
            {'Ы', "Y"},
            {'Ь', "'"},
            {'Э', "E"},
            {'Ю', "Yu"},
            {'Я', "Ya"}
        };
    }
}
