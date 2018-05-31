using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMS.model
{
    class ProgramareVideoproiectiePojo
    {



        #region fields(username,phoneNumber,dateProgramming,sunday_morning,sunday_evening)

            private string username;
            private string phoneNumber;
            private string dateProgramming;
            private string sunday_morning;
            private string sunday_evening;

            public string Username
            {
                get { return username; }
                set { username = value; }
            }

            public string PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }

            public string DateProgramming
            {
                get { return dateProgramming; }
                set { dateProgramming = value; }
            }

            public string Sunday_morning
            {
                get { return sunday_morning; }
                set { sunday_morning = value; }
            }

            public string Sunday_evening
            {
                get { return sunday_evening; }
                set { sunday_evening = value; }
            }

        #endregion

        #region constructor

            public ProgramareVideoproiectiePojo(string user, string number, string date, string sunday_m, string sunday_e)
            {
                username = user;
                phoneNumber = number;
                dateProgramming = date;
                sunday_morning = sunday_m;
                sunday_evening = sunday_e;
            }

        #endregion
    
    }
}
