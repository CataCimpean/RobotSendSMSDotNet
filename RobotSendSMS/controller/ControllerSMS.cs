using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotSendSMS.model;
using RobotSendSMS.utils;

namespace RobotSendSMS.controller
{
    class ControllerSMS
    {


            private List<ProgramareVideoproiectiePojo> listOfRecipients = null;
            private List<ProgramareVideoproiectiePojo> listWithAllDataFromJSON = null;

            public void startApp(){

                listWithAllDataFromJSON = FileUtil.GetListFromJSONFile();

                if (listWithAllDataFromJSON != null)
                {

                    listOfRecipients = ContentParserUtil.GetListOfRecipients(listWithAllDataFromJSON);
                    if (listOfRecipients != null && listOfRecipients.Count != 0)
                    {
                        foreach (ProgramareVideoproiectiePojo currentRecipient in listOfRecipients)
                        {

                            String serviceResponse = SendSMSUtil.SendSMSToRecipient(currentRecipient);
                            //mesaje in eventViewer de succes respectiv eroare.
                            if (serviceResponse.Contains("\"status\":\"success\""))
                            {
                                LogMessage.PrintEventMessage("Mesaj trimis cu succes catre " + currentRecipient.Username + " in data de " + DateTime.Now);

                            }
                            else
                            {
                                HandlerErrorsUtil.handlerErrorFromService(serviceResponse);
                            }
                        }
                    }
                    else
                    {
                        HandlerErrorsUtil.handlerWarningFromFileJSON(1);
                    }

                    Console.ReadLine();

                }
                else
                {
                    HandlerErrorsUtil.handlerWarningFromFileJSON(2);
                }


            }


            internal List<ProgramareVideoproiectiePojo> ListOfRecipients
            {
                get { return listOfRecipients; }
                set { listOfRecipients = value; }
            }
            internal List<ProgramareVideoproiectiePojo> ListWithAllDataFromJSON
            {
                get { return listWithAllDataFromJSON; }
                set { listWithAllDataFromJSON = value; }
            }

        

    }
}
