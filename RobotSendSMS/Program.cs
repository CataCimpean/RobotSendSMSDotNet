using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Diagnostics;
using RobotSendSMS.model;
using RobotSendSMS.utils;
using RobotSendSMS.controller;

namespace RobotSendSMS
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerSMS controllerApp = new ControllerSMS();
            controllerApp.startApp();
        }
    }
}
