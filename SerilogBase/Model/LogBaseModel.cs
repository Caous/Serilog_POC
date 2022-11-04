using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace SerilogBase.Model
{
    public class LogBaseModel
    {
        public LogBaseModel(string appName, string enviroment, string host, short port)
        {
            AppName = appName;
            Enviroment = enviroment;
            Host = host;
            Port = port;
        }

        public string AppName { get; }
        public string Enviroment{ get; }
        public string Host { get; }
        public short Port { get; }
    }
}
