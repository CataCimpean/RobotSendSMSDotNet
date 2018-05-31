using RobotSendSMS.model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Collections.Specialized;
 
        
namespace RobotSendSMS.utils
{
    class SendSMSUtil
    {

        public static String SendSMSToRecipient(ProgramareVideoproiectiePojo recipient) {

            String result = "";
            using (var wb = new WebClient())
            {
                String messageToSend = getSMSContent(recipient);
                String number = String.Concat("4", recipient.PhoneNumber);
                String encoddedMessageToSend = WebUtility.UrlEncode(messageToSend);

                if (messageToSend != "")
                {
                    byte[] response = wb.UploadValues("http://api.txtlocal.com/send/", new NameValueCollection()    
                   {  
                       {"username","catacimpean@yahoo.com"},
                       {"hash" , "bbb4b7d397b2c6d6183e436f4b9593bfa1e1dec933d349e51a245784c30d5098"},    
                       {"numbers" ,  number},            
                       {"message" , encoddedMessageToSend},            
                       {"sender" , "VP"}         
                   });

                    result = System.Text.Encoding.UTF8.GetString(response);

                    Console.WriteLine(result);
                }

            }
            return result;
        
        }

        public static String getSMSContent(ProgramareVideoproiectiePojo recipient) {

            if (recipient != null) {

                string message = "Buna ";
                message = String.Concat(message, recipient.Username);

                if (recipient.DateProgramming.Equals(DateConverterUtil.GetTomorrowAsString()))
                {
                    string sunday_morning = recipient.Sunday_morning;
                    string y = "yes";
                    string n = "no";
                    if (sunday_morning.ToLower().Equals(y.ToLower()))
                    {
                        message = String.Concat(message, ", iti reamintim ca maine dimineata " + DateConverterUtil.GetTomorrowAsString() + " esti la proiectie.Multumim de implicare, echipa VideoProiectie Speranta.");
                    }
                    else if (sunday_morning.ToLower().Equals(n.ToLower()))
                    {
                        message = String.Concat(message, ", iti reamintim ca maine dupamasa " + DateConverterUtil.GetTomorrowAsString() + " esti la proiectie.Multumim de implicare, echipa VideoProiectie Speranta.");
                    }

                }
                else if(recipient.DateProgramming.Equals(DateConverterUtil.GetTodayAsString()))
                {
                    message = String.Concat(message, ", iti reamintim ca astazi " + DateConverterUtil.GetTodayAsString() + " esti la proiectie.Multumim de implicare, echipa VideoProiectie Speranta.");
                }

                return message;
            }
            return "";
        }


      
    }
}
