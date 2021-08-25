
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

        readonly string russianAlphabetLowercase = "� � � � � � � � � � � � � � � � � � � � � � � � � � � � � � � � �";
        readonly string russianAlphabetUppercase = "� � � � � � � � � � � � � � � � � � � � � � � � � � � � � � � � �";
        readonly string expectedLowercase = "a b v g d e yo zh z i j k l m n o p r s t u f kh ts ch sh shch \" y ' e yu ya";
        readonly string expectedUppercase = "A B V G D E Yo Zh Z I J K L M N O P R S T U F Kh Ts Ch Sh Shch \" Y ' E Yu Ya";

        readonly string russian1 = "� � �";

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

        [TestCase("Priladozhskiy", "������������")]
        [TestCase("Naziya", "�����")]
        [TestCase("Sinyavino", "��������")]
        [TestCase("Shlissel'burg", "������������")]
        public void ConvTest(string res, string str)
        {
            //var str = "������������";
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