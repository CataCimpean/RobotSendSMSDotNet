using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RobotSendSMS.utils
{
    class HandlerErrorsUtil
    {

        public static void handlerWarningFromFileJSON(int type)
        {

            if (type == 1)
            {
                LogMessage.PrintEventWarning("Nu avem date de incarcat,va rugam actualizati fisierul JSON");
            }
            else if (type == 2) {
                if (!File.Exists(FileUtil.filePathJSON))
                {
                    LogMessage.PrintEventWarning("Nu a fost gasit fisierul JSON in locatie cu proiectul.Va rugam verificati!.");
                }
                else
                {
                    LogMessage.PrintEventWarning("Fisierul JSON este gol/null va rugam verificati continutul acestuia.");
                }
            }
        }


        public static void handlerErrorFromService(String errorMessage) {


            int errorCode = 0;
            string recivedStatus = "";
            if (errorMessage.Contains("\"code\":3"))
            {
                recivedStatus = "Invalid_Number";
                errorCode = 3;
            }
            else if (errorMessage.Contains("\"code\":6"))
            {
                recivedStatus = "Message_too_long";
                errorCode = 6;
            }
            else if (errorMessage.Contains("\"code\":7"))
            {
                recivedStatus = "Insufficient_Credits";
                errorCode = 7;
            }

            displayErrorFromService(recivedStatus, errorCode);

        }

        public static void displayErrorFromService(String recivedStatusFromService, int errorCode)
        {
            LogMessage.PrintEventError("A aparut o eroare la trimiterea SMS-ului in data de "
                              + DateConverterUtil.GetTodayAsString() + " Denumire eroare: " + recivedStatusFromService + " Cod eroare: " + errorCode + " ."
                              + "Pt mai multe detalii consultati siteul https://api.txtlocal.com/docs/sendsms ");
        }
    }
}
