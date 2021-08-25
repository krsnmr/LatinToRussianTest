
using NUnit.Framework;

namespace LatinToRussianTest
{
    public class Tests
    {
        [Test]
        public void EqTest()
        {
            var result = 1;
            Assert.That(result, Is.EqualTo(1));
        }

        readonly string russianAlphabetLowercase = "а б в г д е ё ж з и й к л м н о п р с т у ф х ц ч ш щ ъ ы ь э ю я";
        readonly string russianAlphabetUppercase = "А Б В Г Д Е Ё Ж З И Й К Л М Н О П Р С Т У Ф Х Ц Ч Ш Щ Ъ Ы Ь Э Ю Я";
        readonly string expectedLowercase = "a b v g d e yo zh z i j k l m n o p r s t u f kh ts ch sh shch \" y ' e yu ya";
        readonly string expectedUppercase = "A B V G D E Yo Zh Z I J K L M N O P R S T U F Kh Ts Ch Sh Shch \" Y ' E Yu Ya";

        readonly string russian1 = "а б в";

        [Test]
        public void GetLengthTest()
        {
            var result = Transliterator.GetChars(russian1);
            Assert.That(result.Length, Is.EqualTo(5));
        }

        [Test]
        public void RussianAlphabetTest()
        {
            Assert.AreEqual(expectedLowercase,
                Transliterator.Conv(russianAlphabetLowercase));
            Assert.AreEqual(expectedUppercase,
                Transliterator.Conv(russianAlphabetUppercase));
        }

        [TestCase("Priladozhskiy", "Приладожский")]
        [TestCase("Naziya", "Назия")]
        [TestCase("Sinyavino", "Синявино")]
        [TestCase("Shlissel'burg", "Шлиссельбург")]
        public void ConvTest(string res, string str)
        {
            //var str = "Приладожский";
            //var result = "Priladozhskiy";
            Assert.That(res, Is.EqualTo(Transliterator.Conv(str)));
        }



        [TestCase("naziya", 5)]
        public void SplitByLettersTest(string str, int cnt)
        {
            var res = Transliterator.SplitByLetters(str);
            Assert.That(res.Length, Is.EqualTo(cnt));
        }
    }
}