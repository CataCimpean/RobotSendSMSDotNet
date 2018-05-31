using RobotSendSMS.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMS.utils
{
    class ContentParserUtil
    {
       
            public static List<ProgramareVideoproiectiePojo> GetListOfRecipients(List<ProgramareVideoproiectiePojo> programmingList)
            {
                List<ProgramareVideoproiectiePojo> listOfRecipients =null;

                    if (programmingList != null)
                    {

                        listOfRecipients = new List<ProgramareVideoproiectiePojo>();
                        foreach (ProgramareVideoproiectiePojo currentPojo in programmingList)
                        {

                            if (currentPojo.DateProgramming.Equals(DateConverterUtil.GetTodayAsString()))
                            {
                                listOfRecipients.Add(currentPojo);
                            }else if (currentPojo.DateProgramming.Equals(DateConverterUtil.GetTomorrowAsString())){
                           
                              DayOfWeek today = DateTime.Now.DayOfWeek;

                              if ((today == DayOfWeek.Saturday) || (today == DayOfWeek.Sunday))
                              {
                                  listOfRecipients.Add(currentPojo);
                              }
                              
                            }

                        }

                    }

                 return listOfRecipients;
             }
      }
 }

