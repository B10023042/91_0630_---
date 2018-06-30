using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BirthdayHandler
    {
        public string Is91Birthday()
        {
            var time = GetDateTime();
            if (time.Month == 9 && time.Day == 1)
                return "Happy Birthday";
            return "No";
        }

        protected virtual DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}
