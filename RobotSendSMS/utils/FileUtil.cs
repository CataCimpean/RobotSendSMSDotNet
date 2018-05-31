using RobotSendSMS.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;




namespace RobotSendSMS.utils
{
    class FileUtil
    {


        #region variables(filenameJSON,filepathJSON)
        public const string filenameJSON = "VideoProiectieProgramare.json";
        public static string filePathJSON = AppDomain.CurrentDomain.BaseDirectory + filenameJSON;
        #endregion


        public static List<ProgramareVideoproiectiePojo> GetListFromJSONFile() {

                List<ProgramareVideoproiectiePojo> list = null;

                using (StreamReader r = new StreamReader(filePathJSON))
                {
                    String json = r.ReadToEnd();
                    var jsonAsString = JsonConvert.DeserializeObject<List<ProgramareVideoproiectiePojo>>(json);

                    if (jsonAsString != null)
                    {
                        list = new List<ProgramareVideoproiectiePojo>();

                        foreach (var current in jsonAsString)
                        {
                            list.Add(new ProgramareVideoproiectiePojo(current.Username, current.PhoneNumber, current.DateProgramming, current.Sunday_morning, current.Sunday_evening));
                        }
                    }
                    
                }
                return list;
          }


        public static string checkPathFormat(string path)
        {
            return (path.Contains(" ")) ? "'" + path + "'" : path;
        }


    }
}
