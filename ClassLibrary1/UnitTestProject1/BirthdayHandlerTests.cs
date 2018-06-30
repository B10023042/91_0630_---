using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class BirthdayHandlerTests
    {
        private FakeBirthdayHandler _fakeBirthdayHandler = new FakeBirthdayHandler();

        [TestMethod()]
        public void Is91BirthdayShouldReturnHappyBirthday()
        {
            _fakeBirthdayHandler.SetDateTime(new DateTime(2018, 9, 1));
            Assert.AreEqual("Happy Birthday", _fakeBirthdayHandler.Is91Birthday());
        }

        [TestMethod()]
        public void IsNot91BirthdayShouldReturnNo()
        {
            _fakeBirthdayHandler.SetDateTime(new DateTime(2018, 9, 2));
            Assert.AreEqual("No", _fakeBirthdayHandler.Is91Birthday());
        }
    }

    public class FakeBirthdayHandler : BirthdayHandler
    {
        private DateTime _dateTime;

        public void SetDateTime(DateTime dateTime)
        {
            _dateTime = dateTime;
        }

        protected override DateTime GetDateTime()
        {
            return _dateTime;
        }
    }
}