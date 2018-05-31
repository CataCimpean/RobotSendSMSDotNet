using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMS.utils
{
    class DateConverterUtil
    {

        public static String GetTomorrowAsString()
        {
            DateTime tomorrow = DateTime.Now.AddDays(1); // As DateTime
            string s_tomorrow = tomorrow.ToString("MM/dd/yyyy"); // As String
            return s_tomorrow;
        }

        public static String GetTodayAsString()
        {
            DateTime today = DateTime.Today; // As DateTime
            string s_today = today.ToString("MM/dd/yyyy"); // As String
            return s_today;
        }
    }
}
