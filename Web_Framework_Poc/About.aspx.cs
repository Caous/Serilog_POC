using SerilogBase.Infraestructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.Composition;
using Microsoft.Extensions.Logging;
using SerilogBase.Model;
using Web_Framework_Poc.Service;

namespace Web_Framework_Poc
{
    public partial class About : Page
    {
        private ILogBase LogBase;

        protected void Page_Load(object sender, EventArgs e)
        {
            TestLog();
        }

        public About(ILogBase logBase)
        {
            LogBase = logBase;
        }

        private void TestLog()
        {
            var log = this.LogBase.CreateModel("Teste", LogLevel.Information, "Sem erro");
            LogBase.WriteLog(log);
        }
    }
}