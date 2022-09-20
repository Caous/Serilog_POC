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

namespace Web_Framework_Poc
{
    public partial class About : Page
    {
        [Import] private readonly ILogBase _logBase;

        protected void Page_Load(object sender, EventArgs e)
        {
            TestLog();
        }

        private void TestLog()
        {
            var log = _logBase.CreateModel("Teste", LogLevel.Information, "Sem erro");
            _logBase.WriteLog(log);
        }
    }
}