using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        internal override DateTime GetDateTime()
        {
            
            return _dateTime;
        }

        public void SetDateTime(DateTime dateTime)
        {
            _dateTime = dateTime;
        }
    }
}