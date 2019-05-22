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

            Assert.AreEqual("222222", converter.CodingMessage("abc"));
        }
        
        [TestMethod]
        public void CodingMessage_Symbol_3_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("333333", converter.CodingMessage("def"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_4_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("444444", converter.CodingMessage("ghi"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_5_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("555555", converter.CodingMessage("jkl"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_6_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("666666", converter.CodingMessage("mno"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_7_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("7777777777", converter.CodingMessage("pqrs"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_8_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("888888", converter.CodingMessage("tuv"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_9_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("9999999999", converter.CodingMessage("wxyz"));
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

            Assert.AreEqual("", converter.CodingMessage("1"));
        }

        [TestMethod]
        public void CodingMessage_Symbol_EndMessage_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual(Constants.EndMessage.ToString(), converter.CodingMessage(Constants.EndMessage.ToString()));
        }

        [TestMethod]
        public void CodingMessage_DoubleSymbol_A_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("2 2", converter.CodingMessage("aa"));
        }

        [TestMethod]
        public void CodingMessage_Real_Text_Test()
        {
            var converter = new Converter(fakeLogger.Object);

            Assert.AreEqual("833777780633", converter.CodingMessage("test me"));
        }
    }
}
