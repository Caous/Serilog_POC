using Microsoft.Extensions.Logging;
using SerilogBase.Infraestructure.Interface;
using SerilogBase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Framework_Poc
{
    public partial class Contact : Page
    {
        private ILogBase _logBase;
        protected void Page_Load(object sender, EventArgs e, ILogBase logBase)
        {
            try
            {
                if (!IsPostBack)
                {
                    _logBase = logBase;
                    TestLog();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void TestLog()
        {
            var log = _logBase.CreateModel("Teste", LogLevel.Information, "Sem erro");
            _logBase.WriteLog(log);
        }
    }
}