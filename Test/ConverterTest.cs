using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using Moq;

namespace Test
{
    [TestClass]
    public class ConverterTest
    {
        Mock<ILogger> fakeLogger = new Mock<ILogger>();

        public void Init(){
            fakeLogger.Setup(t => t.Write(It.IsAny<string>()));
        }

        [TestMethod]
        public void CodingMessage_Symbol_2_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("2 22 222", converter.CodingMessage("abc"));
        }
        
        [TestMethod]
        public void CodingMessage_Symbol_3_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("3 33 333", converter.CodingMessage("def"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_4_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("4 44 444", converter.CodingMessage("ghi"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_5_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("5 55 555", converter.CodingMessage("jkl"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_6_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("6 66 666", converter.CodingMessage("mno"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_7_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("7 77 777 7777", converter.CodingMessage("pqrs"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_8_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("8 88 888", converter.CodingMessage("tuv"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_9_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("9 99 999 9999", converter.CodingMessage("wxyz"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_0_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("0", converter.CodingMessage(" "));
        }

        [TestMethod]
        public void CodingMessage_Other_Symbol_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual(string.Empty, converter.CodingMessage("1"));
        }

        [TestMethod]
        public void CodingMessage_DoubleSymbol_A_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("2 2", converter.CodingMessage("aa"));
        }

        [TestMethod]
        public void CodingMessage_hi_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("44 444", converter.CodingMessage("hi"));
        }

        [TestMethod]
        public void CodingMessage_Yes_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("999337777", converter.CodingMessage("yes"));
        }

        [TestMethod]
        public void CodingMessage_Foo__Bar_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("333666 6660 022 2777", converter.CodingMessage("foo  bar"));
        }

        [TestMethod]
        public void CodingMessage_Hello__World_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("4433555 555666096667775553", converter.CodingMessage("hello world"));
        }
    }
}
